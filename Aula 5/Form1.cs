namespace Aula_5
{
    public partial class frm_baralho : Form
    {
        bool troca = true;
        int[] cartas = new int[13];
        int indiceCarta = 0;
        int pontos = 0;
        List<int> numerosSorteados = new List<int>();
        int jogador = 1;

        public frm_baralho()
        {
            InitializeComponent();
        }

        private void pic_baralho_Click(object sender, EventArgs e)
        {

            Random sorteio = new Random();
            int numeroCarta;
            string naipe = "espada_";
            string carta = "1";

            if (troca)
            {
                // Gera um número único que ainda não foi sorteado
                do
                {
                    numeroCarta = sorteio.Next(1, 14);  // números de 1 a 13
                } while (numerosSorteados.Contains(numeroCarta));
                numerosSorteados.Add(numeroCarta);

                carta = naipe + numeroCarta.ToString();

                // Adiciona o valor de numeroCarta no vetor cartas
                if (indiceCarta < cartas.Length)
                {
                    cartas[indiceCarta] = numeroCarta;
                    indiceCarta++;
                }
                //pic_baralho.Image = Properties.Resources.espada_2;
                pic_baralho.Image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(carta);

                troca = false;
            }
            else
            {
                carta = naipe + cartas[indiceCarta - 1].ToString();
                pic_baralho.Image = Properties.Resources.capa;

                if (cartas[indiceCarta - 1] <= 10)
                    pontos += cartas[indiceCarta - 1];
                else
                    pontos += 10;

                if (jogador == 1)
                {
                    pic_cartas.Image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(carta);
                    lbl_Contador.Text = pontos.ToString();
                }
                else
                {
                    pic_cartas2.Image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(carta);
                    lbl_Contador2.Text = pontos.ToString();
                }

               

                // Verifica se o jogador ganhou
                if (pontos == 21)
                {
                    MessageBox.Show("Você ganhou!");
                    pontos = 0;
                    lbl_Contador.Text = pontos.ToString();
                    indiceCarta = 0;
                    numerosSorteados.Clear();
                }
                else if (pontos > 21)
                {
                    MessageBox.Show("Você perdeu!");
                    pontos = 0;
                    lbl_Contador.Text = pontos.ToString();
                    indiceCarta = 0;
                    numerosSorteados.Clear();
                    //pic_cartas.Image = Properties.Resources.capa;
                    
                    //  zerar jogadas dos dois baralhos
                    if(jogador == 1)
                    {
                        jogador = 2;
                        pic_cartas.Image = Properties.Resources.capa;
                        pic_cartas2.Image = Properties.Resources.capa;
                        lbl_Contador.Text = pontos.ToString();
                    }
                    else
                    {
                        jogador = 1;
                        pic_cartas.Image = Properties.Resources.capa;
                        pic_cartas2.Image = Properties.Resources.capa;
                        lbl_Contador2.Text = pontos.ToString();
                    }
                }
                else
                {
                    //MessageBox.Show("Continue jogando!");
                }
                troca = true;
            }
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            jogador = 2;
            MessageBox.Show("Próximo Jogador");
            pontos = 0;
            lbl_Contador2.Text = pontos.ToString();
            indiceCarta = 0;
            numerosSorteados.Clear();
            //pic_cartas.Image = Properties.Resources.capa;
        }
    }
}
