using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
       
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender">boton "Cerrar"</param>
        /// <param name="e">Evento Click</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte el numero ingresado en la calculadora a binario y si fue
        /// posible lo muestra
        /// </summary>
        /// <param name="sender">boton "Convertir a binario"</param>
        /// <param name="e">Evento Click</param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double num;
            string res;
            long aux;
            Operando operandoAux = new Operando(this.lblResultado.Text);
            if (double.TryParse(this.lblResultado.Text, out num))
            {
                res=operandoAux.DecimalBinario(num);
                this.lstOperaciones.Items.Add(res);
                if (long.TryParse(res, out aux))
                {
                    this.lblResultado.Text = res;
                }
                else
                {
                    this.lblResultado.Text = "";
                }
            }
        }

        /// <summary>
        /// Convierte el numero ingresado en la calculadora a decimal y si fue
        /// posible lo muestra
        /// </summary>
        /// <param name="sender"> boton "Convertir a decimal" </param>
        /// <param name="e"> Evento Click </param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            long aux;
            Operando operandoAux = new Operando();
            string res = operandoAux.BinarioDecimal(this.lblResultado.Text);
            this.lstOperaciones.Items.Add(res);
            if(long.TryParse(res, out aux))
            {
                this.lblResultado.Text = res;
            }
            else
            {
                this.lblResultado.Text = "";
            }

        }

        /// <summary>
        /// Limpia 
        /// </summary>
        /// <param name="sender"> boton "Limpiar" </param>
        /// <param name="e"> Evento Click </param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Realiza la operacion ingresada en la calculadora, y si fue posible
        /// muestra el resultado
        /// </summary>
        /// <param name="sender"> boton "Operar" </param>
        /// <param name="e"> Evento Click </param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string txtN1 = this.txtNumero1.Text;
            string txtN2 = this.txtNumero2.Text;
            double num1Aux, num2Aux, res;
            string operador="";


            if (double.TryParse(this.txtNumero1.Text, out num1Aux) && double.TryParse(this.txtNumero2.Text, out num2Aux) &&
                this.cmbOperador.SelectedIndex!=0)
            {
                if(this.cmbOperador.SelectedIndex.ToString()=="/" && txtN2 == "0")
                {
                    this.lblResultado.Text = double.MinValue.ToString();
                }
                operador = this.cmbOperador.SelectedItem.ToString();
                res = Operar(txtN1, txtN2, operador);
                this.lblResultado.Text = null;
                this.lblResultado.Text = res.ToString();
                this.lstOperaciones.Items.Add($"{txtN1} {operador} {txtN2} = {res}");

            }

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            this.btnOperar.Enabled = true;
            this.CenterToScreen();
        }


        /// <summary>
        /// Limpia los TextBox, comboBox y Label.
        /// </summary>
        private void Limpiar()
        {

            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "";
            

        }


        /// <summary>
        /// Llama a realizar la operacion ingresada por parametro
        /// </summary>
        /// <param name="numero1">string primer operador</param>
        /// <param name="numero2">string segundo operador</param>
        /// <param name="operador">string operador</param>
        /// <returns></returns>
        static double Operar(string numero1, string numero2, string operador)
        {
            char operadorC;

            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            char.TryParse(operador, out operadorC);
            double res = Calculadora.Operar(operando1, operando2, operadorC);
            
            
            return res;
        }


            
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel=true;
            }
        }
    }
}
