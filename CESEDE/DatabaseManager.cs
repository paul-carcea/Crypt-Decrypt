using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace CESEDE
{
    public class DatabaseManager
    {
        private const string DATABASE_PATH = "C:\\Users\\Paul\\OneDrive\\Desktop\\CESEDE_Final\\CESEDE\\database.db";
        private const string DATABASE_SOURCE = "Data Source=\"" + DATABASE_PATH + "\"";

        public static bool HasPasswordSet()
        {
            SqliteConnection conn = new SqliteConnection(DATABASE_SOURCE);
            conn.Open();

            var commandCreate = conn.CreateCommand();
            commandCreate.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS password(pass VARCHAR(10))
            ";
            commandCreate.ExecuteNonQuery();

            var commandSelect = conn.CreateCommand();
            commandSelect.CommandText = @"SELECT COUNT(*) FROM password";

            int passwordCount = 0;

            using(var reader = commandSelect.ExecuteReader())
            {
                reader.Read();
                passwordCount = reader.GetInt32(0);
            }

            conn.Close();
            return passwordCount > 0;
        }

        public static void SetPassword(string password)
        {
            if (!HasPasswordSet())
            {
                SqliteConnection conn = new SqliteConnection(DATABASE_SOURCE);
                conn.Open();

                var command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO password(pass) VALUES($p)";
                // TODO: CRIPTEAZA PAROLA INAINTE SA O BAGI IN VAZA DE DATE
                command.Parameters.AddWithValue("$p", password);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public static bool CheckPassword(string password)
        {
            int passwordCount = 0;

            if (HasPasswordSet())
            {
                SqliteConnection conn = new SqliteConnection(DATABASE_SOURCE);
                conn.Open();

                var command = conn.CreateCommand();
                command.CommandText = @"SELECT COUNT(*) FROM password WHERE pass=$p";
                // TODO: CRIPTEAZA PAROLA INAINTE SA O BAGI IN VAZA DE DATE
                command.Parameters.AddWithValue("$p", password);

                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    passwordCount = reader.GetInt32(0);
                }

                conn.Close();
            }
            return passwordCount > 0;
        }

        private static void CreateTableIfNotExists(SqliteConnection conn)
        {
            var commandCreate = conn.CreateCommand();
            commandCreate.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS files(filename VARCHAR(256), hash BLOB, filesize INT, algo VARCHAR(128), key1 BLOB, key2 BLOB, performance DOUBLE, encryption_time DATETIME)
            ";
            commandCreate.ExecuteNonQuery();
        }

        public static void SaveEntry(string filename, int fileSize, string algoName, byte[] key1, byte[] key2, double performance)
        {
            SqliteConnection conn = new SqliteConnection(DATABASE_SOURCE);
            conn.Open();
            CreateTableIfNotExists(conn);

            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO files(filename, hash, filesize, algo, key1, key2, performance, encryption_time) VALUES($fn, $h, $fs, $a, $k1, $k2, $p, CURRENT_TIMESTAMP)";
            command.Parameters.AddWithValue("$fn", filename);
            command.Parameters.AddWithValue("$h", Hash.SHA1(Encoding.ASCII.GetBytes(filename)));
            command.Parameters.AddWithValue("$fs", fileSize);
            command.Parameters.AddWithValue("$a", algoName);
            command.Parameters.AddWithValue("$k1", key1);
            command.Parameters.AddWithValue("$k2", key2);
            command.Parameters.AddWithValue("$p", performance);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static bool GetEntry(string filename, out int fileSize, out string algoName, out byte[] key1, out byte[] key2)
        {
            SqliteConnection conn = new SqliteConnection(DATABASE_SOURCE);
            conn.Open();
            CreateTableIfNotExists(conn);

            var command = conn.CreateCommand();
            command.CommandText = @"SELECT filesize, algo, key1, key2 FROM files WHERE filename=$fn ORDER BY encryption_time DESC";
            command.Parameters.AddWithValue("$fn", filename);

            bool returnValue;

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    fileSize = reader.GetInt32(0);
                    algoName = reader.GetString(1);
                    var stream = reader.GetStream(2);
                    key1 = new byte[stream.Length];
                    stream.Read(key1, 0, key1.Length);

                    stream = reader.GetStream(3);
                    key2 = new byte[stream.Length];
                    stream.Read(key2, 0, key2.Length);
                    returnValue = true;
                }
                else
                {
                    fileSize = 0;
                    algoName = "";
                    key1 = new byte[0];
                    key2 = new byte[0];
                    returnValue = false;
                }
            }

            conn.Close();

            return returnValue;
        }

    }
}
