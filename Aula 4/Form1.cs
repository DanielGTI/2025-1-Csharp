namespace Aula_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carro_Click(object sender, EventArgs e)
        {
            pic_imagem.Image = Properties.Resources.Ferrari;
        }

        private void btn_carro2_Click(object sender, EventArgs e)
        {
            pic_imagem.Image = Properties.Resources.Mustang_GT2024;
        }

        private void btn_modelo_Click(object sender, EventArgs e)
        {
            pic_imagem.Image = Properties.Resources.modelo;
        }

        private void btn_troca_Click(object sender, EventArgs e)
        {
            int numero;
            
            // numero aleatorio
            Random sorteio = new Random();
            numero = sorteio.Next(1, 4);

            txt_numero.Text = numero.ToString();
            // FERRARI
            if (numero == 1)
            {
                pic_imagem.Image = Properties.Resources.Ferrari;
            }

            // MUSTANG
            if (numero == 2)
            {
                pic_imagem.Image = Properties.Resources.Mustang_GT2024;
            }

            // MODELO
            if (numero == 3)
            {
                pic_imagem.Image = Properties.Resources.modelo;
            }
        }
    }
}
