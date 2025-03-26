namespace Aula3
{
    public partial class frm_Calculadora : Form
    {
        double valor = 0;
        bool resolverOperacao = false;
        public frm_Calculadora()
        {
            InitializeComponent();
        }

        public void operacao(String valor_operacao)
        {
            if (valor_operacao == "+") {
                // Soma
                if ( resolverOperacao == true ) { 
                    txt_Visor.Clear();
                    resolverOperacao = false;
                }
                else
                {
                    valor = valor + Double.Parse(txt_Visor.Text);
                    resolverOperacao = true;
                }
            }
        }

        public void funcao_Inicial_Botao(String valor_botao)
        {
            if (txt_Visor.Text == "0" || resolverOperacao==true )
            {
                txt_Visor.Clear();
                resolverOperacao = false;
            }

            txt_Visor.Text = txt_Visor.Text + valor_botao;
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("3");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("0");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao("9");
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            funcao_Inicial_Botao(".");
        }

        private void btn_sinal_Click(object sender, EventArgs e)
        {
            txt_Visor.Text = "- " + txt_Visor.Text;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            operacao("+");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_Visor.Text = "0";
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            txt_Visor.Text = "0";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            operacao("-");
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            operacao("*");
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            operacao("/");
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            operacao("=");
        }
    }
}
