namespace PruebaWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnContar = new Button();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.BackColor = SystemColors.MenuHighlight;
            btnContar.ForeColor = SystemColors.ButtonHighlight;
            btnContar.Location = new Point(50, 50);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(200, 100);
            btnContar.TabIndex = 0;
            btnContar.Text = "botonzote";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Form1";
            
            ResumeLayout(false);
        }

        #endregion

        private Button btnContar;
    }
}
