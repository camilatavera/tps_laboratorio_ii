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
    public partial class FrmOpcionesEmpleados : Form
    {
        public FrmOpcionesEmpleados()
        {
            InitializeComponent();
        }

        private void btn_operativo_Click(object sender, EventArgs e)
        {
            FrmEmpleadoDetalle<EmpleadoOperativo> frmOperativo = new FrmEmpleadoDetalle<EmpleadoOperativo>(null, EFormEmpleado.operativo);
            frmOperativo.Show();
            this.Close();
        }


        private void btn_deportivos_Click(object sender, EventArgs e)
        {
            FrmEmpleadoDetalle<EmpleadoDeportivo> frmDeportivo = new FrmEmpleadoDetalle<EmpleadoDeportivo>(null, EFormEmpleado.deportivo);
            frmDeportivo.Show();
            this.Close();
        }

       
    }
}
