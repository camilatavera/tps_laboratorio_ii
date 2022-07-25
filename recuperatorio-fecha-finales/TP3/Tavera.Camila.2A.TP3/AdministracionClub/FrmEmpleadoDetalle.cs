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
    public partial class FrmEmpleadoDetalle<T> : Form where T:Persona
                                        
    {
        EmpleadoDeportivo deportivo;
        static List<Equipo> equiposAux;
        EmpleadoOperativo operativo;
        EFormEmpleado form;

        public FrmEmpleadoDetalle(T persona, EFormEmpleado form)
        {
            InitializeComponent();

            this.form = form;

            if (persona is null)
            {
                if (form == EFormEmpleado.deportivo)
                {
                    equiposAux = new List<Equipo>();

                }
                return;
            }
            else
            {
                txt_nombre.Text = persona.Nombre;
                txt_apellido.Text = persona.Apellido;
                cmb_sexo.SelectedItem = persona.Sexo;
                dtp_fecha.Value = persona.FechaNacimiento.Date;

                if (form == EFormEmpleado.deportivo)
                {

                    this.deportivo = Club.BuscarDeportivo(persona);
                    equiposAux = new List<Equipo>(this.deportivo.Equipos);

                }
                else
                    this.operativo = Club.BuscarOperativo(persona);
            }

                        
        }

        private void FrmEmpleadoDetalle_Load(object sender, EventArgs e)
        {

            this.cmb_sexo.DataSource = Enum.GetValues(typeof(Esexo));


            if (form == EFormEmpleado.operativo)
            {
                this.cmb_area.DataSource = Enum.GetValues(typeof(EArea));
                gbox_deportes.Visible = false;

                if (operativo is not null)
                {

                    txt_sueldo.Text = operativo.Sueldo.ToString();
                    this.cmb_area.SelectedItem = operativo.Area;
                }
            }
            else
            {
                cmb_area.Visible = false;
                lbl_area.Visible = false;
                gbox_deportes.Visible = true;

                 if (deportivo is not null)
                 {
                    cargarListDeportes();
                    txt_sueldo.Text = deportivo.Sueldo.ToString();
                 }

            }


           
        }

        public static List<Equipo> EquiposAux
        {
            get { return equiposAux; }
        }

        void cargarListDeportes()
        {
            lst_deportes.Items.Clear();
            foreach (Equipo item in EquiposAux)
            {
                lst_deportes.Items.Add(item);
            }
        }

      

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FrmAgregarDeporte frmAgregar = new FrmAgregarDeporte();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                if (deportivo is not null)
                {
                    this.deportivo.ValidarEquipos(EquiposAux);
                }
                cargarListDeportes();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Equipo equipo;
            int index = lst_deportes.SelectedIndex;
            if (index != -1)
            {
                equipo = (Equipo)lst_deportes.SelectedItem;

                if (MessageBox.Show("Seguro quieres borrar el equipo?", "Estas por borrar un equipo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                    DialogResult.OK)
                {
                    lst_deportes.Items.Remove(equipo);
                    EquiposAux.Remove(equipo);
                    deportivo.BorrarEquipo(equipo);
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            Esexo sexo ;
            DateTime nacimiento ;
            EArea area = default ;

            try
            {
                 nombre = txt_nombre.Text;
                 apellido = txt_apellido.Text;
                 sexo = (Esexo)cmb_sexo.SelectedItem;
                 nacimiento = new DateTime();
                 nacimiento = dtp_fecha.Value;

                if (form == EFormEmpleado.operativo) 
                    area = (EArea)cmb_area.SelectedItem;

            }
            catch (Exception)
            {
                MessageBox.Show("Error en los campos..");
                return;
            }
           


            if (form == EFormEmpleado.deportivo)
            {
                if (deportivo is null)
                {
                    if (validarCamposLlenos())
                    {

                        try
                        {
                            Club.AgregarDeportivo(nombre, apellido, sexo, nacimiento, EquiposAux);
                            MessageBox.Show($"Empleado {apellido} se creo con exito", "Creacion exitosa", MessageBoxButtons.OK);

                        }
                        catch (PersonaRepetidaException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        AbrirListado();
                    }
                }
                else
                {
                    if (lst_deportes.Items.Count == 0)
                    {
                        MessageBox.Show("Falta seleccionar deportes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Club.UpdateDeportivo(deportivo, nombre, apellido, sexo, nacimiento, EquiposAux))
                        {
                            MessageBox.Show($"Empleado {apellido} actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK);
                            AbrirListado();
                        }
                    }
                }

            }
            else
            {
                if (operativo is null)
                {
                    if (validarCamposLlenos())
                    {

                        try
                        {
                            Club.AgregarOperativo(nombre, apellido, sexo, nacimiento, area);
                            MessageBox.Show($"Empleado {apellido} se creo con exito", "Creacion exitosa", MessageBoxButtons.OK);

                        }
                        catch (PersonaRepetidaException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        AbrirListado();
                    }
                }
                else if (Club.UpdateOperativo(operativo, nombre, apellido, sexo, nacimiento, area))
                {
                    MessageBox.Show($"Empleado {apellido} actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK);
                    AbrirListado();
                }
         
            
            }
        }


        void AbrirListado()
        {
            FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo> frm = new FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo>(Club.Operativos, Club.Deportivos, EForm.empleado);
            frm.Show();
            //this.Close();
        }


        protected bool validarCamposLlenos()
        {
            if (!string.IsNullOrEmpty(txt_apellido.Text) && !string.IsNullOrEmpty(txt_nombre.Text) &&
               cmb_sexo.SelectedItem != null)
            {
                if (form == EFormEmpleado.operativo && cmb_area.SelectedItem != null)
                {
                    return true;
                }
                else if(form==EFormEmpleado.deportivo && lst_deportes.Items.Count != 0 && EquiposAux.Count != 0)
                {
                    return true;
                }
            }

            return false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if(deportivo is not null && lst_deportes.Items.Count == 0)
            {
                MessageBox.Show("Recuerde que modifico la lista de equipos y no puede estar vacia", "Error en la lista de equipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void FrmEmpleadoDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbrirListado();
        }
    }
}
