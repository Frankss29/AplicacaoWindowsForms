namespace Q1_ConversorCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //Declaração de Variaveis
            double F,C;

            //Entrada
            C = Convert.ToDouble(txtCelsius.Text);

            //Processamento
            F = (C * 9 / 5) + 32;

            //Saida
            lbResultado.Text= F.ToString()+"°";


        }
    }
}
