namespace Aula_4
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
            pic_imagem = new PictureBox();
            btn_carro = new Button();
            btn_modelo = new Button();
            btn_carro2 = new Button();
            txt_numero = new TextBox();
            btn_troca = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_imagem).BeginInit();
            SuspendLayout();
            // 
            // pic_imagem
            // 
            pic_imagem.Image = Properties.Resources.Mustang_GT2024;
            pic_imagem.Location = new Point(86, 12);
            pic_imagem.Name = "pic_imagem";
            pic_imagem.Size = new Size(407, 268);
            pic_imagem.SizeMode = PictureBoxSizeMode.Zoom;
            pic_imagem.TabIndex = 0;
            pic_imagem.TabStop = false;
            // 
            // btn_carro
            // 
            btn_carro.Location = new Point(86, 309);
            btn_carro.Name = "btn_carro";
            btn_carro.Size = new Size(75, 23);
            btn_carro.TabIndex = 1;
            btn_carro.Text = "FERRARI";
            btn_carro.UseVisualStyleBackColor = true;
            btn_carro.Click += btn_carro_Click;
            // 
            // btn_modelo
            // 
            btn_modelo.Location = new Point(86, 367);
            btn_modelo.Name = "btn_modelo";
            btn_modelo.Size = new Size(75, 23);
            btn_modelo.TabIndex = 2;
            btn_modelo.Text = "MODELO";
            btn_modelo.UseVisualStyleBackColor = true;
            btn_modelo.Click += btn_modelo_Click;
            // 
            // btn_carro2
            // 
            btn_carro2.Location = new Point(86, 338);
            btn_carro2.Name = "btn_carro2";
            btn_carro2.Size = new Size(75, 23);
            btn_carro2.TabIndex = 3;
            btn_carro2.Text = "MUSTANG";
            btn_carro2.UseVisualStyleBackColor = true;
            btn_carro2.Click += btn_carro2_Click;
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(393, 310);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(100, 23);
            txt_numero.TabIndex = 4;
            // 
            // btn_troca
            // 
            btn_troca.Location = new Point(393, 339);
            btn_troca.Name = "btn_troca";
            btn_troca.Size = new Size(100, 23);
            btn_troca.TabIndex = 5;
            btn_troca.Text = "TROCAR IMG";
            btn_troca.UseVisualStyleBackColor = true;
            btn_troca.Click += btn_troca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 422);
            Controls.Add(btn_troca);
            Controls.Add(txt_numero);
            Controls.Add(btn_carro2);
            Controls.Add(btn_modelo);
            Controls.Add(btn_carro);
            Controls.Add(pic_imagem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_imagem;
        private Button btn_carro;
        private Button btn_modelo;
        private Button btn_carro2;
        private TextBox txt_numero;
        private Button btn_troca;
    }
}
