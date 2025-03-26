namespace Aula3
{
    partial class frm_Calculadora
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
            txt_Visor = new TextBox();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_virgula = new Button();
            btn_0 = new Button();
            btn_sinal = new Button();
            btn_calcular = new Button();
            btn_soma = new Button();
            btn_subtracao = new Button();
            btn_multiplicacao = new Button();
            btn_divisao = new Button();
            btn_voltar = new Button();
            btn_limpar = new Button();
            btn_zerar = new Button();
            SuspendLayout();
            // 
            // txt_Visor
            // 
            txt_Visor.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Visor.Location = new Point(12, 12);
            txt_Visor.Name = "txt_Visor";
            txt_Visor.Size = new Size(299, 46);
            txt_Visor.TabIndex = 1;
            txt_Visor.Text = "0";
            txt_Visor.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_1.Location = new Point(25, 296);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(60, 60);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_2.Location = new Point(91, 296);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(60, 60);
            btn_2.TabIndex = 2;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_3.Location = new Point(157, 296);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(60, 60);
            btn_3.TabIndex = 3;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_9.Location = new Point(157, 164);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(60, 60);
            btn_9.TabIndex = 6;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_8.Location = new Point(91, 164);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(60, 60);
            btn_8.TabIndex = 5;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_7.Location = new Point(25, 164);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(60, 60);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_6.Location = new Point(157, 230);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(60, 60);
            btn_6.TabIndex = 9;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_5.Location = new Point(91, 230);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(60, 60);
            btn_5.TabIndex = 8;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_4.Location = new Point(25, 230);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(60, 60);
            btn_4.TabIndex = 7;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_virgula.Location = new Point(157, 362);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(60, 60);
            btn_virgula.TabIndex = 12;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = true;
            btn_virgula.Click += btn_virgula_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_0.Location = new Point(91, 362);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(60, 60);
            btn_0.TabIndex = 11;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_sinal
            // 
            btn_sinal.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_sinal.Location = new Point(25, 362);
            btn_sinal.Name = "btn_sinal";
            btn_sinal.Size = new Size(60, 60);
            btn_sinal.TabIndex = 10;
            btn_sinal.Text = "+/-";
            btn_sinal.UseVisualStyleBackColor = true;
            btn_sinal.Click += btn_sinal_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.BackColor = Color.RoyalBlue;
            btn_calcular.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_calcular.ForeColor = SystemColors.ControlLightLight;
            btn_calcular.Location = new Point(237, 362);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(60, 60);
            btn_calcular.TabIndex = 14;
            btn_calcular.Text = "=";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_soma
            // 
            btn_soma.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_soma.Location = new Point(237, 296);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(60, 60);
            btn_soma.TabIndex = 13;
            btn_soma.Text = "+";
            btn_soma.UseVisualStyleBackColor = true;
            btn_soma.Click += btn_soma_Click;
            // 
            // btn_subtracao
            // 
            btn_subtracao.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_subtracao.Location = new Point(237, 230);
            btn_subtracao.Name = "btn_subtracao";
            btn_subtracao.Size = new Size(60, 60);
            btn_subtracao.TabIndex = 15;
            btn_subtracao.Text = "-";
            btn_subtracao.UseVisualStyleBackColor = true;
            btn_subtracao.Click += btn_subtracao_Click;
            // 
            // btn_multiplicacao
            // 
            btn_multiplicacao.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_multiplicacao.Location = new Point(237, 164);
            btn_multiplicacao.Name = "btn_multiplicacao";
            btn_multiplicacao.Size = new Size(60, 60);
            btn_multiplicacao.TabIndex = 16;
            btn_multiplicacao.Text = "x";
            btn_multiplicacao.UseVisualStyleBackColor = true;
            btn_multiplicacao.Click += btn_multiplicacao_Click;
            // 
            // btn_divisao
            // 
            btn_divisao.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_divisao.Location = new Point(237, 98);
            btn_divisao.Name = "btn_divisao";
            btn_divisao.Size = new Size(60, 60);
            btn_divisao.TabIndex = 17;
            btn_divisao.Text = "÷";
            btn_divisao.UseVisualStyleBackColor = true;
            btn_divisao.Click += btn_divisao_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_voltar.Location = new Point(157, 98);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(60, 60);
            btn_voltar.TabIndex = 18;
            btn_voltar.Text = "⌫";
            btn_voltar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            btn_limpar.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_limpar.Location = new Point(91, 98);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(60, 60);
            btn_limpar.TabIndex = 19;
            btn_limpar.Text = "CE";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_zerar
            // 
            btn_zerar.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_zerar.Location = new Point(25, 98);
            btn_zerar.Name = "btn_zerar";
            btn_zerar.Size = new Size(60, 60);
            btn_zerar.TabIndex = 20;
            btn_zerar.Text = "C";
            btn_zerar.UseVisualStyleBackColor = true;
            btn_zerar.Click += btn_zerar_Click;
            // 
            // frm_Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 443);
            Controls.Add(btn_zerar);
            Controls.Add(btn_limpar);
            Controls.Add(btn_voltar);
            Controls.Add(btn_divisao);
            Controls.Add(btn_multiplicacao);
            Controls.Add(btn_subtracao);
            Controls.Add(btn_calcular);
            Controls.Add(btn_soma);
            Controls.Add(btn_virgula);
            Controls.Add(btn_0);
            Controls.Add(btn_sinal);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(txt_Visor);
            Name = "frm_Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Visor;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_virgula;
        private Button btn_0;
        private Button btn_sinal;
        private Button btn_calcular;
        private Button btn_soma;
        private Button btn_subtracao;
        private Button btn_multiplicacao;
        private Button btn_divisao;
        private Button btn_voltar;
        private Button btn_limpar;
        private Button btn_zerar;
    }
}
