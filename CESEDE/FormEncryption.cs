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
using System.Diagnostics;

namespace CESEDE
{
    public partial class FormEncryption : Form
    {
        private string filename;

        public FormEncryption(string filename)
        {
            this.filename = filename;
            InitializeComponent();
            foreach(var alg in Program.Algorithms)
            {
                comboBoxAlgoritm.Items.Add(alg.GetName());
            }
        }

        private void buttonCriptare_Click(object sender, EventArgs e)
        {
            if (comboBoxAlgoritm.SelectedIndex < 0)
            {
                return;
            }
            EncryptionAlgorithm ea = Program.Algorithms[comboBoxAlgoritm.SelectedIndex];

            string password = textBoxPass.Text;
            if (DatabaseManager.CheckPassword(password))
            {
                List<byte[]> keys = ea.GenerateKeyPair();
                byte[] fileBytes = File.ReadAllBytes(filename);

                Stopwatch sw = new Stopwatch();
                sw.Start();
                byte[] encrypted = ea.Encrypt(fileBytes, keys[0]);
                sw.Stop();

                double performance = sw.Elapsed.TotalMilliseconds;

                File.WriteAllBytes(filename + ".encrypted", encrypted);

                DatabaseManager.SaveEntry(filename + ".encrypted", fileBytes.Length, ea.GetName(), keys[0], keys[1], performance);

                //TODO: DELETE FILE AFTER ENCRYPTION

                this.Close();
            }
            else
            {
                MessageBox.Show("Parola incorecta!");
            }

        }
    }
}
