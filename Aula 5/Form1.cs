namespace Aula_5
{
    public partial class frm_baralho : Form
    {
        bool troca = true;
        public frm_baralho()
        {
            InitializeComponent();
        }

        private void pic_baralho_Click(object sender, EventArgs e)
        {

            Random sorteio = new Random();
            int numeroCarta = sorteio.Next(1, 14);  // numeros de 1 a 13
            string naipe = "espada_";

            string carta = naipe + numeroCarta.ToString();
            // alternativa
            string novacarta = $"{naipe}{numeroCarta}";

            if ( troca )
            {
                //pic_baralho.Image = Properties.Resources.espada_2;
                pic_baralho.Image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(carta);

                troca = false;
            }
            else
            {
                pic_baralho.Image = Properties.Resources.capa;
                troca = true;
            }
        }
    }
}
