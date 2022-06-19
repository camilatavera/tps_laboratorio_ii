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

namespace AdministracionClub
{
    public partial class FrmPersonaDetalle : Form
    {
        Persona persona;
        public FrmPersonaDetalle(Persona persona)
        {
            this.persona = persona;
            InitializeComponent();
        }

        protected virtual bool validarCamposLlenos()
        {
            
            if (!string.IsNullOrEmpty(txt_apellido.Text)  && !string.IsNullOrEmpty(txt_nombre.Text) &&
                cmb_sexo.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void FrmPersonaDetalle_Load(object sender, EventArgs e)
        {
            this.cmb_sexo.DataSource = Enum.GetValues(typeof(Esexo));

            if(persona is not null)
            {
                txt_nombre.Text = persona.Nombre;
                txt_apellido.Text = persona.Apellido;
                cmb_sexo.SelectedItem = persona.Sexo;
                dtp_fecha.Value = persona.FechaNacimiento.Date;
            }

        }


      
    }
}
