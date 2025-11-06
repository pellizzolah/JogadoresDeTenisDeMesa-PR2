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
                MessageBox.Show("POR FAVOR PREENCHA AMBOS OS CAMPOS DE USUARIO E SENHA \n Exemplo: \n Nome de Usuario: aluno \n Senha do usuario: 123456", "ERRO AO COMPLETAR O LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Eu que fiz, não uso chat!
            }
            else //Se tiver tudo deboa ele segue em frente
            {
                nomeusuario = usuariobox.Text;
                senhausuario = senhabox.Text;
            }







        }

      
    }
}
