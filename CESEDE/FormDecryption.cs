using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CESEDE
{
    public partial class FormDecryption : Form
    {
        private string filename;

        public FormDecryption(string filename)
        {
            this.filename = filename;
            InitializeComponent();
        }

        private void buttonDecriptare_Click(object sender, EventArgs e)
        {
            string password = textBoxPass.Text;
            if (DatabaseManager.CheckPassword(password))
            {
                int fileSize;
                string algoName;
                byte[] key1;
                byte[] key2;
                if(DatabaseManager.GetEntry(filename, out fileSize, out algoName, out key1, out key2))
                {
                    EncryptionAlgorithm ea = null;
                    foreach(var enc in Program.Algorithms)
                    {
                        if (enc.GetName().Equals(algoName))
                        {
                            ea = enc;
                            break;
                        }
                    }
                    if(ea == null)
                    {
                        MessageBox.Show("Algoritmul folosit la criptarea acestui fisier este necunoscut!");
                    }
                    else
                    {
                        byte[] fileBytes = File.ReadAllBytes(filename);

                        byte[] decrypted = ea.Decrypt(fileBytes, key2);

                        //byte[] originalBytes = new byte[fileSize];
                        // TODO: v^v^v^v^
                        //Array.Copy(decrypted, 0, originalBytes, 0, fileSize);

                        //File.WriteAllBytes(filename + ".decrypted", originalBytes);
                        File.WriteAllBytes(filename + ".decrypted", decrypted);
                    }
                }
                else
                {
                    MessageBox.Show("Fisierul nu a fost criptat cu acest program!");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Parola incorecta!");
            }
        }
    }
}
