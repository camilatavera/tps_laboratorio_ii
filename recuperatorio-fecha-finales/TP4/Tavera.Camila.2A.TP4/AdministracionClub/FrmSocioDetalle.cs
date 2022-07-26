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
    public partial class FrmSocioDetalle : Form
    {
        static Socio socio;
        Federado federado;
        public FrmSocioDetalle(Socio socio)
        {
            InitializeComponent();
            FrmSocioDetalle.socio = socio;
        }

        public static Socio SocioAux
        {
            set { socio = value; }
        }

        private void cargarDeportes()
        {

            foreach (EDeporte item in federado.Deportes)
            {
                switch (item)
                {
                    case EDeporte.basket:
                        chbox_basket.Checked = true;
                        break;
                    case EDeporte.handball:
                        chbox_handball.Checked = true;
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
            

            return nuevosDeportes;

        }

        private void FrmSocioDetalle_Load(object sender, EventArgs e)
        {
            gbox_deportes.Visible = false;
            chb_federado.Visible = false;
            this.cmb_categoria.DataSource = Enum.GetValues(typeof(ECategoria));


            this.cmb_sexo.DataSource = Enum.GetValues(typeof(Esexo));

            
            if (socio is null)
            {
                chb_federado.Visible = true;
                chb_federado.Checked = false;
                btn_cobrar.Visible = false;
                btn_baja.Visible = false;
            }
            else
            {
                txt_nombre.Text = socio.Nombre;
                txt_apellido.Text = socio.Apellido;
                cmb_sexo.SelectedItem = socio.Sexo;
                dtp_fecha.Value = socio.FechaNacimiento.Date;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            Esexo sexo = (Esexo)cmb_sexo.SelectedItem;
            DateTime nacimiento = new DateTime();
            nacimiento = dtp_fecha.Value;
            ECategoria categoria = (ECategoria)cmb_categoria.SelectedItem;
            List<EDeporte> deportesNuevos = new List<EDeporte>();

            if (validarCamposLlenos())
            {

                if (socio is null)
                {

                    try
                    {

                        if (chb_federado.Checked)
                        {
                            if (!chbox_basket.Checked && !chbox_futbol.Checked && !chbox_handball.Checked)
                            {
                                MessageBox.Show("No se seleccionaron deportes para el federado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                List<EDeporte> deportes = new List<EDeporte>();
                                deportes = levantarDeportes();
                                try
                                {
                                   
                                    if (DB.AgregarFederado(nombre, apellido, sexo, nacimiento, categoria, 0, deportes))
                                    {

                                        AltaExitosa(apellido);
                                    }
                                }
                                catch (EquipoSinCupoException ex)
                                {
                                    MessageBox.Show(ex.Message, "Deporte sin cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Algo salio mal. Vuelve a intentarlo");
                                }
                                
                            }

                        }
                        else
                        {
                            if (DB.AgregarSocio(nombre, apellido, sexo, nacimiento, categoria, 0))
                            {
                                AltaExitosa(apellido);
                            }
                        }
                    }
                    catch (PersonaRepetidaException ex)
                    {

                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (federado is not null)
                {
                    try
                    {

                        if (!chbox_basket.Checked && !chbox_futbol.Checked && !chbox_handball.Checked)
                        {
                            MessageBox.Show("No se seleccionaron deportes para el federado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        List<EDeporte> deportesAux = new List<EDeporte>(levantarDeportes());
                        foreach(EDeporte item in deportesAux)
                        {
                            if(!federado.Deportes.Contains(item))
                                DB.ValidarCupoEquipo(new Equipo(categoria, item, sexo));
                        }

                        if (DB.UpdateFederado(federado, nombre, apellido, sexo, nacimiento, categoria, deportesAux))
                        {
                            ActualizacionExitosaSocios(apellido);
                        }
                        else
                            this.Close();
                    }
                    catch (EquipoSinCupoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (NoHayDeportesException ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (socio is not null)
                {

                    if (DB.UpdateSocio(socio, nombre, apellido, sexo, nacimiento, categoria))
                    {
                        ActualizacionExitosaSocios(apellido);
                    }
                    else
                        this.Close();
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
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
                    if (federado is not null && DB.BorrarFederado(federado))
                    {
                        ser.Escribir(arch, federado, true);


                    }
                    else if (DB.BorrarSocio(socio))
                    {
                        ser.Escribir(arch, socio, true);
                    }
                    MessageBox.Show("Baja y backup realizado con exito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Algo salio mal : {ex.Message}");
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



        protected  bool validarCamposLlenos()
        {
            if (!string.IsNullOrEmpty(txt_apellido.Text) && !string.IsNullOrEmpty(txt_nombre.Text) &&
               cmb_sexo.SelectedItem != null && cmb_categoria.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void ActualizacionExitosaSocios(string apellido)
        {
            MessageBox.Show($"Se actualizo a {apellido} exitosamente", "Actualizacion exitosa", MessageBoxButtons.OK);
            this.Close();
                  
        }

        private void AltaExitosa(string apellido)
        {
            MessageBox.Show($"Alta de {apellido} exitosa", "Alta exitosa", MessageBoxButtons.OK);
            this.Close();
        }
        

       private void  AbrirListado()
       {
            FrmPersonas<Socio, Federado> frm = new FrmPersonas<Socio, Federado>(Club.Socios, Club.Federados, EForm.socio);
            frm.Show();
       }

        private void FrmSocioDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbrirListado();
        }
    }
}
