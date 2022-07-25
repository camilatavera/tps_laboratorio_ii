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
    public partial class FrmAgregarDeporte : Form
    {
       
        Equipo equipo;
        bool salir;
        
        public FrmAgregarDeporte()
        {
           
            InitializeComponent();
            salir = true;
        }

        private void FrmAgregarDeporte_Load(object sender, EventArgs e)
        {
            btn_agregar.DialogResult = DialogResult.OK;
            this.cmb_deportes.DataSource = Enum.GetValues(typeof(EDeporte));
            this.cmb_sexo.DataSource = Enum.GetValues(typeof(Esexo));
            this.cmb_categoria.DataSource = Enum.GetValues(typeof(ECategoria));

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                EDeporte deporte = (EDeporte)cmb_deportes.SelectedItem;
                Esexo sexo = (Esexo)cmb_sexo.SelectedItem;
                ECategoria categoria = (ECategoria)cmb_categoria.SelectedItem;
                this.equipo = new Equipo(categoria, deporte, sexo);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar los campos. No se pudo agregar el equipo", "Error");
                salir = false;
            }

            
            if(!(FrmEmpleadoDetalle<EmpleadoDeportivo>.EquiposAux + equipo))
            {
                MessageBox.Show("El empleado ya pertenece al equipo");
                
                salir = false;
            }
            

        }

        private void FrmAgregarDeporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir == false)
            {
                e.Cancel = true;
                salir = true;
            }
        }
    }
}
