namespace Aula_1
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
            btn_aviso = new Button();
            SuspendLayout();
            // 
            // btn_aviso
            // 
            btn_aviso.Location = new Point(200, 60);
            btn_aviso.Margin = new Padding(0);
            btn_aviso.Name = "btn_aviso";
            btn_aviso.Size = new Size(100, 40);
            btn_aviso.TabIndex = 0;
            btn_aviso.Text = "AULA NOITE";
            btn_aviso.UseVisualStyleBackColor = true;
            btn_aviso.Click += btn_aviso_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(484, 161);
            Controls.Add(btn_aviso);
            Name = "Form1";
            Text = "Aula 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_aviso;
    }
}
