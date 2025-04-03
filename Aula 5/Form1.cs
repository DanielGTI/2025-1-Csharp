namespace Aula_5
{
    public partial class frm_baralho : Form
    {
        bool troca = true;
        int[] cartas = new int[13];
        int indiceCarta = 0;
        List<int> numerosSorteados = new List<int>();

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

            if (troca) { 
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
                carta = naipe + cartas[indiceCarta-1].ToString();
                pic_baralho.Image = Properties.Resources.capa;
                pic_cartas.Image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(carta);

                troca = true;
            }
        }
    }
}
