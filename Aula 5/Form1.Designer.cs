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
            pic_cartas = new PictureBox();
            lbl_Contador = new Label();
            lbl_Contador2 = new Label();
            pic_cartas2 = new PictureBox();
            btn_Parar = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_baralho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_cartas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_cartas2).BeginInit();
            SuspendLayout();
            // 
            // pic_baralho
            // 
            pic_baralho.Image = Properties.Resources.capa;
            pic_baralho.Location = new Point(220, 12);
            pic_baralho.Name = "pic_baralho";
            pic_baralho.Size = new Size(108, 190);
            pic_baralho.SizeMode = PictureBoxSizeMode.Zoom;
            pic_baralho.TabIndex = 0;
            pic_baralho.TabStop = false;
            pic_baralho.Click += pic_baralho_Click;
            // 
            // pic_cartas
            // 
            pic_cartas.Image = Properties.Resources.capa;
            pic_cartas.Location = new Point(27, 189);
            pic_cartas.Name = "pic_cartas";
            pic_cartas.Size = new Size(143, 205);
            pic_cartas.SizeMode = PictureBoxSizeMode.Zoom;
            pic_cartas.TabIndex = 1;
            pic_cartas.TabStop = false;
            // 
            // lbl_Contador
            // 
            lbl_Contador.AutoSize = true;
            lbl_Contador.Font = new Font("Segoe UI", 16F);
            lbl_Contador.Location = new Point(90, 403);
            lbl_Contador.Name = "lbl_Contador";
            lbl_Contador.Size = new Size(25, 30);
            lbl_Contador.TabIndex = 2;
            lbl_Contador.Text = "0";
            // 
            // lbl_Contador2
            // 
            lbl_Contador2.AutoSize = true;
            lbl_Contador2.Font = new Font("Segoe UI", 16F);
            lbl_Contador2.Location = new Point(437, 403);
            lbl_Contador2.Name = "lbl_Contador2";
            lbl_Contador2.Size = new Size(25, 30);
            lbl_Contador2.TabIndex = 4;
            lbl_Contador2.Text = "0";
            // 
            // pic_cartas2
            // 
            pic_cartas2.Image = Properties.Resources.capa;
            pic_cartas2.Location = new Point(374, 189);
            pic_cartas2.Name = "pic_cartas2";
            pic_cartas2.Size = new Size(143, 205);
            pic_cartas2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_cartas2.TabIndex = 3;
            pic_cartas2.TabStop = false;
            // 
            // btn_Parar
            // 
            btn_Parar.Location = new Point(240, 250);
            btn_Parar.Name = "btn_Parar";
            btn_Parar.Size = new Size(75, 23);
            btn_Parar.TabIndex = 5;
            btn_Parar.Text = "Parar";
            btn_Parar.UseVisualStyleBackColor = true;
            btn_Parar.Click += btn_Parar_Click;
            // 
            // frm_baralho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 442);
            Controls.Add(btn_Parar);
            Controls.Add(lbl_Contador2);
            Controls.Add(pic_cartas2);
            Controls.Add(lbl_Contador);
            Controls.Add(pic_cartas);
            Controls.Add(pic_baralho);
            Name = "frm_baralho";
            Text = "Baralho";
            ((System.ComponentModel.ISupportInitialize)pic_baralho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_cartas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_cartas2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_baralho;
        private PictureBox pic_cartas;
        private Label lbl_Contador;
        private Label lbl_Contador2;
        private PictureBox pic_cartas2;
        private Button btn_Parar;
    }
}
