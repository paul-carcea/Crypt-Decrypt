namespace CESEDE
{
    partial class FormEncryption
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAlgoritm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonCriptare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritm:";
            // 
            // comboBoxAlgoritm
            // 
            this.comboBoxAlgoritm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgoritm.FormattingEnabled = true;
            this.comboBoxAlgoritm.Location = new System.Drawing.Point(65, 12);
            this.comboBoxAlgoritm.Name = "comboBoxAlgoritm";
            this.comboBoxAlgoritm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgoritm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(65, 44);
            this.textBoxPass.MaxLength = 10;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '♥';
            this.textBoxPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 3;
            // 
            // buttonCriptare
            // 
            this.buttonCriptare.Location = new System.Drawing.Point(65, 84);
            this.buttonCriptare.Name = "buttonCriptare";
            this.buttonCriptare.Size = new System.Drawing.Size(75, 23);
            this.buttonCriptare.TabIndex = 4;
            this.buttonCriptare.Text = "Cripteaza";
            this.buttonCriptare.UseVisualStyleBackColor = true;
            this.buttonCriptare.Click += new System.EventHandler(this.buttonCriptare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 115);
            this.Controls.Add(this.buttonCriptare);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAlgoritm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Criptare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAlgoritm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonCriptare;
    }
}

