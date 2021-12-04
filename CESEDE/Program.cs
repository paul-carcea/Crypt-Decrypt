using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;
using OpenSSL.Crypto;

namespace CESEDE
{
    public static class Program
    {

        public static EncryptionAlgorithm[] Algorithms =
        {
            new AES(),
            new GenericSymmetricAlgo(Cipher.AES_192_ECB, "AES-192", 24),
            new GenericSymmetricAlgo(Cipher.AES_256_ECB, "AES-256", 32),
            new Blowfish(),
            new GenericSymmetricAlgo(Cipher.Cast5_ECB, "Cast5", 16),
            new GenericSymmetricAlgo(Cipher.DES_ECB, "DES", 8),
            new GenericSymmetricAlgo(Cipher.DES_EDE3_ECB, "Triple DES", 8),
            new GenericSymmetricAlgo(Cipher.Idea_ECB, "Idea", 16),
            new GenericSymmetricAlgo(Cipher.RC2_ECB, "RC2", 8),
            new GenericSymmetricAlgo(Cipher.RC4, "RC4", 16),
            new RSA()
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!DatabaseManager.HasPasswordSet())
            {
                Application.Run(new FormLogin());
                // If closed and password still not set
                if (!DatabaseManager.HasPasswordSet())
                {
                    Environment.Exit(-1);
                }
            }


            if (args.Length < 2)
            {
                Debug.WriteLine("Argumente insuficiente");
                return;
            }
            string arg1 = args[0];
            if (arg1.Equals("-encrypt"))
            {
                Application.Run(new FormEncryption(args[1]));
            }
            else if (arg1.Equals("-decrypt"))
            {
                Application.Run(new FormDecryption(args[1]));
            }
            else
            {
                Debug.WriteLine("Argument nerecunoscut");
            }


        }
    }
}
