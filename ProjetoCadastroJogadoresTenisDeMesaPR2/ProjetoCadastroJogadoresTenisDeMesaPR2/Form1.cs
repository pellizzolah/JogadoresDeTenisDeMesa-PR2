namespace ProjetoCadastroJogadoresTenisDeMesaPR2
{
    public partial class Form1 : Form
    {

        public string nomeusuario;
        public string senhausuario;


        public Form1()
        {
            InitializeComponent();
        }

        private void botaologin_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(usuariobox.Text) || String.IsNullOrEmpty(senhabox.Text)) //Verifica se algum dos campos não estão vazios
            {
                MessageBox.Show("ERRO! Um dos campos ou ambos não estao preenchidos! Note que ambos tem que estar com informações para efetuar o login!");
            }
            else //Se tiver tudo deboa ele segue em frente
            {
                nomeusuario = usuariobox.Text;
                senhausuario = senhabox.Text;
            }







        }

      
    }
}
