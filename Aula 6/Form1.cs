namespace Aula_6
{
    public partial class Form1 : Form
    {
        int n_sorteio = 0;
        int[,] sorteio_megasenas = new int[100, 7];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sorteio_Click(object sender, EventArgs e)
        {
            //  int n_sorteio = 0;
            //  int[,] sorteio_megasenas = new int[100, 8];
            int i;

            Random numero = new Random();

            for (i = 0; i < 6; i++)
            {
                sorteio_megasenas[n_sorteio, i] = numero.Next(1, 61);
            }

            //Array.Sort(megasena);

            lbl_numero.Text = "";
            for (i = 0; i < 6; i++)
            {
                if (i < 5)
                    lbl_numero.Text += sorteio_megasenas[n_sorteio, i].ToString() + ", ";
                else
                    lbl_numero.Text += sorteio_megasenas[n_sorteio, i].ToString();
            }

            n_sorteio++;

            // Sorteio 1 - 1, 2, 3, 4, 5, 6
            // Sorteio 2 - 3, 12, 23, 44, 51, 55

            pic_globo.Enabled = false;

        }

        private void btn_ganhadores_Click(object sender, EventArgs e)
        {
            String texto;
            pic_globo.Enabled = true;
            lbl_ganhadores.Text = "Ganhadores: " + num_ganhadores.Value.ToString();
            sorteio_megasenas[n_sorteio - 1, 6] = Convert.ToInt32(num_ganhadores.Value);

            num_ganhadores.Value = 0;

            texto = "Sorteio " + n_sorteio + " : " + lbl_numero.Text +
                    " (Ganhadores = " + sorteio_megasenas[n_sorteio - 1, 6] + ")";
            lst_megas.Items.Add(texto);

            lbl_numero.Text = "";

        }
    }
}
