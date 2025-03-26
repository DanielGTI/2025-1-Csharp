namespace Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aula2_Click(object sender, EventArgs e)
        {
            String nome;    //  CARACTERES
            int idade, idade_futuro;      //  INTEIRO


            nome = txt_Nome.Text;
            idade = 20;

            MessageBox.Show("Boa noite, " + nome);
            MessageBox.Show(nome + ", seja bem vindo ao sistema. \r\nVocê tem " + idade + " anos.");

            idade_futuro = idade + 10;
            MessageBox.Show("Daqui a 10 anos você terá " + idade_futuro + " anos.");
        }

        private void btn_aula2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Entrei no componente!");
        }
    }
}
