using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteca;
using ManejoArchivos; 

namespace AdministracionClub
{
    public partial class FrmCobrarDeuda : Form
    {
        Socio socioAux;
        SaveFileDialog saveFileDialog;
        ArchivoTxt archivoTxt;
        int ingreso;
        

        public FrmCobrarDeuda(Socio socio)
        {
            InitializeComponent();
            this.socioAux = socio;
            archivoTxt = new ArchivoTxt();
            saveFileDialog = new SaveFileDialog();
            btn_cobrar.DialogResult = DialogResult.OK;
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            string archivo;
            string factura; 
            

            if (validarMontoIngresado()) 
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFileDialog.FileName;
                    factura = Club.generarFactura(socioAux, this.ingreso);

                    try
                    {
                        archivoTxt.Escribir(archivo, factura, false);
                        socioAux.saldarDeuda(ingreso);
                        FrmSocioDetalle.SocioAux = socioAux;
                        MessageBox.Show("Se genero la factura con exito", "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.Close();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Error al generar factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
        }

        private bool validarMontoIngresado()
        {
            
            try
            {
                socioAux.validarMonto(this.txt_ingreso.Text, out this.ingreso);
                return true;
            }
            catch(ExMontoIngresado ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Error en el monto ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void FrmCobrarDeuda_Load(object sender, EventArgs e)
        {
            this.txt_deuda.Text = socioAux.APagar.ToString();
        }
    }
}
