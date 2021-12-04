namespace CESEDE
{
    partial class FormDecryption
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
            this.buttonDecriptare = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDecriptare
            // 
            this.buttonDecriptare.Location = new System.Drawing.Point(43, 52);
            this.buttonDecriptare.Name = "buttonDecriptare";
            this.buttonDecriptare.Size = new System.Drawing.Size(75, 23);
            this.buttonDecriptare.TabIndex = 7;
            this.buttonDecriptare.Text = "Decripteaza";
            this.buttonDecriptare.UseVisualStyleBackColor = true;
            this.buttonDecriptare.Click += new System.EventHandler(this.buttonDecriptare_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.HideSelection = false;
            this.textBoxPass.Location = new System.Drawing.Point(55, 12);
            this.textBoxPass.MaxLength = 10;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '♥';
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 87);
            this.Controls.Add(this.buttonDecriptare);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Decriptare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecriptare;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label2;
    }
}