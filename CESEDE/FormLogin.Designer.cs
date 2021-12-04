namespace CESEDE
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetareParola = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetareParola
            // 
            this.buttonSetareParola.Location = new System.Drawing.Point(65, 77);
            this.buttonSetareParola.Name = "buttonSetareParola";
            this.buttonSetareParola.Size = new System.Drawing.Size(122, 23);
            this.buttonSetareParola.TabIndex = 2;
            this.buttonSetareParola.Text = "Seteaza parola";
            this.buttonSetareParola.UseVisualStyleBackColor = true;
            this.buttonSetareParola.Click += new System.EventHandler(this.buttonSetareParola_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(101, 25);
            this.textBoxPass.MaxLength = 10;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '♥';
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola:";
            // 
            // textBoxPassConf
            // 
            this.textBoxPassConf.HideSelection = false;
            this.textBoxPassConf.Location = new System.Drawing.Point(101, 51);
            this.textBoxPassConf.MaxLength = 10;
            this.textBoxPassConf.Name = "textBoxPassConf";
            this.textBoxPassConf.PasswordChar = '♥';
            this.textBoxPassConf.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassConf.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inainte de a folosi programul tre\' sa setezi o parola!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Confirmare:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 109);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassConf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetareParola);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetareParola;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}