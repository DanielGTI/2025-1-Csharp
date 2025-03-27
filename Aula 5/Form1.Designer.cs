namespace Aula_5
{
    partial class frm_baralho
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
            pic_baralho = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_baralho).BeginInit();
            SuspendLayout();
            // 
            // pic_baralho
            // 
            pic_baralho.Image = Properties.Resources.capa;
            pic_baralho.Location = new Point(146, 12);
            pic_baralho.Name = "pic_baralho";
            pic_baralho.Size = new Size(230, 352);
            pic_baralho.SizeMode = PictureBoxSizeMode.Zoom;
            pic_baralho.TabIndex = 0;
            pic_baralho.TabStop = false;
            pic_baralho.Click += pic_baralho_Click;
            // 
            // frm_baralho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 426);
            Controls.Add(pic_baralho);
            Name = "frm_baralho";
            Text = "Baralho";
            ((System.ComponentModel.ISupportInitialize)pic_baralho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_baralho;
    }
}
