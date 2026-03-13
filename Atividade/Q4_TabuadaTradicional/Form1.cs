using System.Windows.Forms;

namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Declaração Variaveis
            int numero;

            //Entrada
            numero=Convert.ToInt32(txtNumero.Text);

            //Processamento
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;

                //Saida
                lstTabuada.Items.Add(numero + " x " + i + " = " + resultado);
                txtNumero.Clear();
                txtNumero.Focus();                          
            }

        }
    }
}
