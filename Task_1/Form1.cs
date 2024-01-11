using System.Drawing;
using System.Text.RegularExpressions;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                string valor = txtValor.Text;
                bool isValid = Regex.IsMatch(valor, "[0-9]");
                if (isValid)
                {
                    int numero = Int32.Parse(valor);

                    bool result = numero % 2 == 0;
                    if (result)
                    {
                        MessageBox.Show("O número é par");
                    }
                    else
                    {
                        MessageBox.Show("O número é impar");
                    }
                }
                else
                {
                    MessageBox.Show("Texto inválido, por favor digite um valor numérico");
                }

                txtValor.Text = null;
            }
        }

        private bool validarCampo()
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favoir, digite um valor");
                txtValor.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
