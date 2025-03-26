namespace Aula_2
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
            btn_aula2 = new Button();
            lbl_Nome = new Label();
            txt_Nome = new TextBox();
            SuspendLayout();
            // 
            // btn_aula2
            // 
            btn_aula2.Location = new Point(200, 88);
            btn_aula2.Name = "btn_aula2";
            btn_aula2.Size = new Size(106, 40);
            btn_aula2.TabIndex = 0;
            btn_aula2.Text = "Exibir";
            btn_aula2.UseVisualStyleBackColor = true;
            btn_aula2.Click += btn_aula2_Click;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(200, 41);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(106, 15);
            lbl_Nome.TabIndex = 1;
            lbl_Nome.Text = "Digite o seu nome:";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(200, 59);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(106, 23);
            txt_Nome.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(484, 161);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Nome);
            Controls.Add(btn_aula2);
            Name = "Form1";
            Text = "Aula 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_aula2;
        private Label lbl_Nome;
        private TextBox txt_Nome;
    }
}
