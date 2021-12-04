using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CESEDE
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonSetareParola_Click(object sender, EventArgs e)
        {
            if(textBoxPass.Text.Length > 0)
            {
                if(textBoxPass.Text == textBoxPassConf.Text)
                {
                    DatabaseManager.SetPassword(textBoxPass.Text);
                    MessageBox.Show("Parola a fost setata cu succes!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Parola nu a fost scrisa corect!");
                }
            }
        }
    }
}
