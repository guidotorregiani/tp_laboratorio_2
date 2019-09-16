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
        /// <summary>
        /// Constructor de la clase FormCalculadora, inicializa todos los componentes por default
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
        /// <summary>
        /// Evento del boton cerrar, cierra la aplicacion de windows forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// convierte un numero binario en uno decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }
        /// <summary>
        /// convierte un numero decimal en uno binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// metodo que limpia las cajas de texto, combobox y label del forms
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }
        /// <summary>
        /// Evento del boton limpiar que llama al metodo limpiar al hacer click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Evento del boton Operar que llama al metodo operar al hacer click, devuelve el resultado de la operacion mediante el lblResultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Valida al salir del textbox1,en caso de ingresar un dato invalido muestra un mensaje de error y cambia el contenido del campo por un "0"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNumero1_Leave(object sender, EventArgs e)
        {
            double auxiliar;
            if ((double.TryParse(this.txtNumero1.Text, out auxiliar) == false || this.txtNumero1.Text == ""))
            {
                MessageBox.Show("Dato invalido", "Error", MessageBoxButtons.OK);
                this.txtNumero1.Text = "0";
            }
        }
        /// <summary>
        /// Valida al salir del textbox2,en caso de ingresar un dato invalido muestra un mensaje de error y cambia el contenido del campo por un "0"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNumero2_Leave(object sender, EventArgs e)
        {
            double auxiliar;
            if ((double.TryParse(this.txtNumero2.Text, out auxiliar) == false || this.txtNumero2.Text == ""))
            {
                MessageBox.Show("Dato invalido", "Error", MessageBoxButtons.OK);
                this.txtNumero2.Text = "0";

            }
        }
    }
}