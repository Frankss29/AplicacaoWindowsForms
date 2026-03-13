namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Repositorio p = new Repositorio();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Entrada e Processamento
            //Informa mensagem caso campos estejam vazios
            if (string.IsNullOrWhiteSpace(txtNome.Text) && 
                string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Preencha os Campos Nome e Idade para realizar o cadastro");
            }
            else
            {
                //Cadastrar pessoa na classe Pessoa
                Pessoa novoCadastro = new Pessoa();
                novoCadastro.Nome = txtNome.Text;
                novoCadastro.Idade = txtIdade.Text;


                //Salvar o novo cadastro no repositorio/"banco de dados"
                Repositorio.pessoasCadastro.Add(novoCadastro);



                //SAIDA
                //Adicionar no listbox

                //Inserir na listbox
                lstPessoas.Items.Add($"Nome:{novoCadastro.Nome} | Idade :{novoCadastro.Idade}");
                txtNome.Clear();
                txtIdade.Clear();
                txtNome.Focus();
            }

        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
