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
                MessageBox.Show(" Preencha ambos os campos de nome do usuario e senha \n Exemplo: \n Nome do Usuario: SteveMagal \n Senha do usuario: AbacateFazBem12345", "Erro ao prosseguir com a ação", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Eu que fiz, não uso chat!
            }
            else //Se tiver tudo deboa ele segue em frente
            {
                nomeusuario = usuariobox.Text;
                senhausuario = senhabox.Text;
            }







        }

      
    }
}
