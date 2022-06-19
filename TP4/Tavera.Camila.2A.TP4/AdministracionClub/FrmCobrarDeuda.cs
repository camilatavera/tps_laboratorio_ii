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
        bool salir;

        public FrmCobrarDeuda(Socio socio)
        {
            InitializeComponent();
            this.socioAux = socio;
            archivoTxt = new ArchivoTxt();
            saveFileDialog = new SaveFileDialog();
            btn_cobrar.DialogResult = DialogResult.OK;
            salir = false;
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            string archivo;
            string factura;

            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.AddExtension = true;

            if (validarMontoIngresado()) 
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFileDialog.FileName;
                    factura = Club.GenerarFactura(socioAux, this.ingreso);

                    try
                    {
                        socioAux.SaldarDeuda(ingreso);

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
                        salir = true;
                        this.Close();
                    }
                    catch(Exception)
                    {
                        

                    }


                }
            }
        }
        
        private bool validarMontoIngresado()
        {
            
            try
            {
                socioAux.ValidarMonto(this.txt_ingreso.Text, out this.ingreso);
                return true;
            }
            catch(MontoIngresadoException ex)
            {
                if(MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            catch(Exception)
            {
                if(MessageBox.Show("Error en el monto ingresado", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)== DialogResult.Retry)
                {
                    this.Close();
                    this.txt_ingreso.Text = "";
                }
            }
            return false;
        }

        private void FrmCobrarDeuda_Load(object sender, EventArgs e)
        {
            this.txt_deuda.Text = socioAux.APagar.ToString();
           
        }

        private void FrmCobrarDeuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir != true)
            {
                e.Cancel = true;
                this.txt_ingreso.Text = "";
            }

        }
    }
}
