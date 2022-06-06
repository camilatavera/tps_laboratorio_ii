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
    public partial class FrmSocioDetalle :FrmPersonaDetalle
    {
        
        static Socio socio;
        Federado federado;
        public FrmSocioDetalle(Socio socio):base(socio)
        {
            InitializeComponent();
            SocioAux = socio;
        }

        public static Socio SocioAux
        {
            set { socio = value; }
        }

        private void cargarDeportes()
        {
            
            foreach(EDeporte item in federado.Deportes)
            {
                switch (item)
                {
                    case EDeporte.basket:
                        chbox_basket.Checked = true;
                        break;
                    case EDeporte.handball:
                        chbox_handball.Checked = true;
                        break;
                    case EDeporte.voley:
                        chbox_voley.Checked = true;
                        break;
                    case EDeporte.futbol:
                        chbox_futbol.Checked = true;
                        break;
                }
            }
        }

        private List<EDeporte> levantarDeportes()
        {
            List<EDeporte> nuevosDeportes = new List<EDeporte>();

            if (chbox_basket.Checked)
            {
                nuevosDeportes.Add(EDeporte.basket);
            }
            if (chbox_futbol.Checked)
            {
                nuevosDeportes.Add(EDeporte.futbol);
            }
            if (chbox_handball.Checked)
            {
                nuevosDeportes.Add(EDeporte.handball);
            }
            if (chbox_voley.Checked)
            {
                nuevosDeportes.Add(EDeporte.voley);
            }

            return nuevosDeportes;

        }

        private void FrmSocioDetalle_Load(object sender, EventArgs e)
        {
            gbox_deportes.Visible = false;
            chb_federado.Visible = false;
            this.cmb_categoria.DataSource = Enum.GetValues(typeof(ECategoria));

            if (socio is null)
            {
                chb_federado.Visible = true;
                chb_federado.Checked = false;
                btn_cobrar.Visible = false;
                btn_baja.Visible = false;
            }
            else
            {
                
                cmb_categoria.SelectedItem = socio.Categoria;
                txt_cuota.Text = socio.CuotaSocial.ToString();
                txt_apagar.Text = socio.APagar.ToString();


                if (socio.GetType() == typeof(Federado))
                {
                    this.federado = (Federado)socio;
                    gbox_deportes.Visible = true;
                    cargarDeportes();

                }
            }


        }

        

        

        private void chb_federado_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_federado.Checked)
            {
                gbox_deportes.Visible = true;
            }
            else
            {
                gbox_deportes.Visible = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            string nombre=txt_nombre.Text;
            string apellido = txt_apellido.Text;
            Esexo sexo=(Esexo)cmb_sexo.SelectedItem;
            DateTime nacimiento = new DateTime();
            nacimiento = dtp_fecha.Value;
            ECategoria categoria= (ECategoria)cmb_categoria.SelectedItem;
            List<EDeporte> deportesNuevos = new List<EDeporte>();

            if (validarCamposLlenos())
            {

                if (socio is null)
                {

                    try
                    {

                        if (chb_federado.Checked)
                        {
                            if (!chbox_basket.Checked && !chbox_futbol.Checked && !chbox_voley.Checked && !chbox_handball.Checked)
                            {
                                MessageBox.Show("No se seleccionaron deportes para el federado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                            }
                            else
                            {
                                List<EDeporte> deportes = new List<EDeporte>();
                                deportes = levantarDeportes();

                                Club.agregarFederado(nombre, apellido, sexo, nacimiento, categoria, deportes);
                            }
                            
                        }
                        else
                        {
                            Club.agregarSocio(nombre, apellido, sexo, nacimiento, categoria);

                        }
                        FrmPersonas<Socio, Federado> frm = new FrmPersonas<Socio, Federado>(Club.Socios, Club.Federados, EForm.socio);
                        frm.Show();
                        this.Close();
                        

                    }
                    catch (ExPersonaRepetida ex)
                    {

                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(federado is not null)
                {
                    try
                    {
                        if (Club.UpdateFederado(federado, nombre, apellido, sexo, nacimiento, categoria, levantarDeportes()))
                        {
                            actualizacionExitosaSocios(apellido);
                        }
                    }
                    catch(ExNoHayDeportes ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if(socio is not null)
                {

                    if (Club.UpdateSocio(socio, nombre, apellido, sexo, nacimiento, categoria))
                    {
                        actualizacionExitosaSocios(apellido);
                    }                  
                }              
            }
        }

        protected override bool validarCamposLlenos()
        {
            return base.validarCamposLlenos() && (cmb_categoria.SelectedItem != null);
            
        }

        void actualizacionExitosaSocios(string apellido)
        {
            MessageBox.Show($"Se actualizo a {apellido} exitosamente");
            FrmPersonas<Socio, Federado> frm = new FrmPersonas<Socio, Federado>(Club.Socios, Club.Federados, EForm.socio);
            frm.Show();
            this.Close();
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            FrmCobrarDeuda frmCobrar = new FrmCobrarDeuda(socio);
            if (frmCobrar.ShowDialog() == DialogResult.OK)
            {
               
                txt_apagar.Text = socio.APagar.ToString();
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            string arch = AppDomain.CurrentDomain.BaseDirectory + "SociosDeBaja.json";

            if (MessageBox.Show("Seguro que quieres dar de baja al socio?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
            {
                Serializador<Socio> ser = new Serializador<Socio>(EtipoArchivoS.JSON);
                try
                {
                    if(federado is not null && Club.borrarFederado(federado))
                    {
                        ser.Escribir(arch, federado, true);
                        

                    }
                    else if (Club.borrarSocio(socio))
                    {
                        ser.Escribir(arch, socio, true);
                    }
                    MessageBox.Show("baja y backup realizado con exito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Algo salio mal : {ex.Message}");
                }

                FrmPersonas<Socio, Federado> frm = new FrmPersonas<Socio, Federado>(Club.Socios, Club.Federados, EForm.socio);
                frm.Show();
                this.Close();

            }
        }
    }
}
