namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            //Declaração de Variaveis
            double C, Q, Calc;

            //Entrada
            C=Convert.ToDouble(txtCotacao.Text);
            Q=Convert.ToDouble(txtDolares.Text);

            //Processamento
            Calc = Q * C;

            //Saida
            lbResultado.Text= Calc.ToString()+"US$";
        }
    }
}
