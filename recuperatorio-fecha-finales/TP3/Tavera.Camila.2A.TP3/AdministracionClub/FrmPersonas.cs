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
    public partial class FrmPersonas<T,U> : Form where T:Persona
                                                 where U: Persona
    {
      
        List<T> list1;
        List<U> list2;
        EForm form; 
        public FrmPersonas(List<T> list1, List<U> list2, EForm form)
        {
            InitializeComponent();
            this.list1 = new List<T>();
            this.list1 = list1;
            this.list2 = new List<U>();
            this.list2 = list2;
            this.form = form;
            
            ActualizarLista();

        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            if (form == EForm.empleado)
            {
                this.Text = "Lista de empleados";
            }
            else
            {
                this.Text = "Lista de socios y federados";
            }

            if (lst_personas.Items.Count != 0)
               lst_personas.SelectedIndex = 0;

        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            if (lst_personas.SelectedItem != null)
            {
                if (this.form == EForm.socio)
                {

                    try
                    {
                        Federado federado = (Federado)lst_personas.SelectedItem;
                        FrmSocioDetalle frm = new FrmSocioDetalle(federado);

                        frm.Show();


                    }
                    catch (Exception)
                    {
                        Socio socio = (Socio)lst_personas.SelectedItem;
                        FrmSocioDetalle frm = new FrmSocioDetalle(socio);
                        frm.Show();

                    }
                    this.Close();

                }
                else
                {


                    try
                    {
                        EmpleadoDeportivo deportivo = (EmpleadoDeportivo)lst_personas.SelectedItem;
                        FrmEmpleadoDetalle<EmpleadoDeportivo> frm = new FrmEmpleadoDetalle<EmpleadoDeportivo>(deportivo, EFormEmpleado.deportivo);
                        frm.Show();
                    }
                    catch (InvalidCastException)
                    {
                        EmpleadoOperativo operativo = (EmpleadoOperativo)lst_personas.SelectedItem;
                        FrmEmpleadoDetalle<EmpleadoOperativo> frm = new FrmEmpleadoDetalle<EmpleadoOperativo>(operativo, EFormEmpleado.operativo);
                        frm.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Algo salio mal. Intente nuevamente");
                    }
                    this.Close();
                }
            }
            
           




        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (form == EForm.socio)
            {
                FrmSocioDetalle frm = new FrmSocioDetalle(null);
                frm.ShowDialog();
                
            }
            else
            {
                FrmOpcionesEmpleados frmOpcionesEmpleados = new FrmOpcionesEmpleados();
                frmOpcionesEmpleados.ShowDialog();
            }
            this.Close();


        }

        void ActualizarLista()
        {
            lst_personas.Items.Clear();
            foreach (T item in list1)
            {
                lst_personas.Items.Add(item);
            }
            foreach (U item in list2)
            {
                lst_personas.Items.Add(item);
            }
        }

    
    }
}
