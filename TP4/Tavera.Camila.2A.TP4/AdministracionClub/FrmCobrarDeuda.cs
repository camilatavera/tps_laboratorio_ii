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
using ManejoDB;

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
                        socioAux.saldarDeuda(ingreso);

                        if (socioAux.GetType() == typeof(Federado))
                        {
                            DB.UpdateDeudaFederado((Federado)socioAux);       
                        }
                        else
                        {
                            DB.UpdateDeudaSocio(socioAux);
                        }
                        archivoTxt.Escribir(archivo, factura, false);
                        FrmSocioDetalle.SocioAux = socioAux;
                        MessageBox.Show("Se genero la factura con exito", "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.Close();
                    }
                    catch(Exception)
                    {
                        if(MessageBox.Show("Error al generar factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)==
                            DialogResult.OK)
                        {

                        }

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
            catch(MontoIngresadoException ex)
            {
                if(MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.txt_ingreso.Text = "";
                }
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
