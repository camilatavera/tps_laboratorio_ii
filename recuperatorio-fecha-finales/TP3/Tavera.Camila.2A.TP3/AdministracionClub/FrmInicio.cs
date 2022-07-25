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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btn_socios_Click(object sender, EventArgs e)
        {
            FrmPersonas<Socio, Federado> frm = new FrmPersonas<Socio, Federado>(Club.Socios, Club.Federados, EForm.socio);
            frm.Show();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo> frm = new FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo>(Club.Operativos, Club.Deportivos, EForm.empleado);
            frm.Show();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

            string arch = AppDomain.CurrentDomain.BaseDirectory + "OperativosIniciales.xml";

            List<Persona> personas = new List<Persona>();
            Serializador<List<EmpleadoOperativo>> ser = new Serializador<List<EmpleadoOperativo>>(EtipoArchivoS.XML);

            List<EmpleadoOperativo> operativos = new List<EmpleadoOperativo>();


            try
            {
                operativos = ser.Leer(arch);
                Club.Operativos.AddRange(operativos);
            }
            catch 
            {
                MessageBox.Show("Error");

            }



        }
    }
}
