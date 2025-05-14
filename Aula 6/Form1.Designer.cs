namespace Aula_6
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
            lbl_numero = new Label();
            btn_sorteio = new Button();
            lst_megas = new ListBox();
            pic_globo = new PictureBox();
            num_ganhadores = new NumericUpDown();
            btn_ganhadores = new Button();
            label1 = new Label();
            lbl_ganhadores = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_globo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_ganhadores).BeginInit();
            SuspendLayout();
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Font = new Font("Segoe UI", 12F);
            lbl_numero.Location = new Point(193, 50);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(19, 21);
            lbl_numero.TabIndex = 0;
            lbl_numero.Text = "...";
            // 
            // btn_sorteio
            // 
            btn_sorteio.Location = new Point(216, 12);
            btn_sorteio.Name = "btn_sorteio";
            btn_sorteio.Size = new Size(81, 23);
            btn_sorteio.TabIndex = 1;
            btn_sorteio.Text = "Sorteio";
            btn_sorteio.UseVisualStyleBackColor = true;
            btn_sorteio.Click += btn_sorteio_Click;
            // 
            // lst_megas
            // 
            lst_megas.FormattingEnabled = true;
            lst_megas.Location = new Point(12, 204);
            lst_megas.Name = "lst_megas";
            lst_megas.Size = new Size(328, 184);
            lst_megas.TabIndex = 2;
            // 
            // pic_globo
            // 
            pic_globo.Image = Properties.Resources.Globo_Girando;
            pic_globo.Location = new Point(12, 12);
            pic_globo.Name = "pic_globo";
            pic_globo.Size = new Size(146, 143);
            pic_globo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_globo.TabIndex = 3;
            pic_globo.TabStop = false;
            // 
            // num_ganhadores
            // 
            num_ganhadores.Font = new Font("Segoe UI", 12F);
            num_ganhadores.Location = new Point(216, 97);
            num_ganhadores.Name = "num_ganhadores";
            num_ganhadores.Size = new Size(81, 29);
            num_ganhadores.TabIndex = 4;
            num_ganhadores.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_ganhadores
            // 
            btn_ganhadores.Location = new Point(216, 132);
            btn_ganhadores.Name = "btn_ganhadores";
            btn_ganhadores.Size = new Size(81, 23);
            btn_ganhadores.TabIndex = 5;
            btn_ganhadores.Text = "Ganhadores";
            btn_ganhadores.UseVisualStyleBackColor = true;
            btn_ganhadores.Click += btn_ganhadores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 185);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "RESULTADOS";
            // 
            // lbl_ganhadores
            // 
            lbl_ganhadores.AutoSize = true;
            lbl_ganhadores.Location = new Point(216, 158);
            lbl_ganhadores.Name = "lbl_ganhadores";
            lbl_ganhadores.Size = new Size(82, 15);
            lbl_ganhadores.TabIndex = 7;
            lbl_ganhadores.Text = "Ganhadores: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 403);
            Controls.Add(lbl_ganhadores);
            Controls.Add(label1);
            Controls.Add(btn_ganhadores);
            Controls.Add(num_ganhadores);
            Controls.Add(pic_globo);
            Controls.Add(lst_megas);
            Controls.Add(btn_sorteio);
            Controls.Add(lbl_numero);
            Name = "Form1";
            Text = "MEGASENA";
            ((System.ComponentModel.ISupportInitialize)pic_globo).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_ganhadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_numero;
        private Button btn_sorteio;
        private ListBox lst_megas;
        private PictureBox pic_globo;
        private NumericUpDown num_ganhadores;
        private Button btn_ganhadores;
        private Label label1;
        private Label lbl_ganhadores;
    }
}
