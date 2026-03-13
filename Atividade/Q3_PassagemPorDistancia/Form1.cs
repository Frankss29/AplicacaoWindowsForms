namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //Declaração de Variaveis
            double D, Calc;


            //Entrada
            D = Convert.ToDouble(txtDistancia.Text);


            //Processamento
            if (D <= 200)
            {
                Calc = D * 0.50;

            }
            else
            {
                Calc = D * 0.45;

            }

            //Saida
            lbResultado.Text = "R$"+Calc.ToString();

        }
    }
    
}
