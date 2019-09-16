using System;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : System.Windows.Forms.Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            string operador;
            double resultado;

            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);

            operador = cmbOperador.Text;
            resultado = Calculadora.Operar(num1, num2, operador);

            lblResultado.Text = resultado.ToString();

        }

        private void TxtNumero1_Leave(object sender, EventArgs e)
        {
            double auxiliar;
            if ((double.TryParse(this.txtNumero1.Text, out auxiliar) == false || this.txtNumero1.Text == ""))
            {
                MessageBox.Show("Dato invalido", "Error", MessageBoxButtons.OK);
                this.txtNumero2.Text = "";
            }
        }

        private void TxtNumero2_Leave(object sender, EventArgs e)
        {
            double auxiliar;
            if ((double.TryParse(this.txtNumero2.Text, out auxiliar) == false || this.txtNumero2.Text == ""))
            {
                MessageBox.Show("Dato invalido", "Error", MessageBoxButtons.OK);
                this.txtNumero2.Text = "";

            }
        }
    }
}