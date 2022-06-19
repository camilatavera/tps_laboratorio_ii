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
using ManejoDB;

namespace AdministracionClub
{
    public partial class FrmEmpleadoDetalle<T> : FrmPersonaDetalle where T : Persona

    {
        EmpleadoDeportivo deportivo;
        static List<Equipo> equiposAux;
        EmpleadoOperativo operativo;
        EFormEmpleado form;

        public FrmEmpleadoDetalle(T persona, EFormEmpleado form):base(persona)
        {
            InitializeComponent();
            this.form = form;

            if(persona is null)
            {
                this.Text = "Nuevo empleado";
                if (form == EFormEmpleado.deportivo)
                {
                    equiposAux = new List<Equipo>();
                    
                }
                return;
            }
            
            else if (form==EFormEmpleado.deportivo)
            {
                
                this.deportivo = Club.BuscarDeportivo(persona);
                equiposAux = new List<Equipo>(this.deportivo.Equipos);
              
            }
            else if (form== EFormEmpleado.operativo)
            {
                this.operativo = Club.BuscarOperativo(persona);  
            }

            this.Text = $"Detalle del empleado {persona.Apellido}";
        }

        public static List<Equipo> EquiposAux
        {
            get { return equiposAux; }
        }

        void cargarListDeportes()
        {
            lst_deportes.Items.Clear();
            foreach(Equipo item in EquiposAux)
            {
                lst_deportes.Items.Add(item);
            }
        }

        private void FrmEmpleadoDetalle_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.lst_deportes.Font = new Font("Georgia", 7);
            if (form == EFormEmpleado.operativo)
            {
                this.cmb_area.DataSource = Enum.GetValues(typeof(EArea));
                chbox_deportes.Visible = false;
            }
            else
            {
                cmb_area.Visible = false;
                lbl_area.Visible = false;
                chbox_deportes.Visible = true;

            }


            if (operativo is not null)
            {
               
                txt_sueldo.Text = operativo.Sueldo.ToString();
                this.cmb_area.SelectedItem = operativo.Area;
            }
            else if(deportivo is not null)
            {
                cargarListDeportes();        
                txt_sueldo.Text = deportivo.Sueldo.ToString();
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FrmAgregarDeporte frmAgregar = new FrmAgregarDeporte();
            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                //if(deportivo is not null)
                //{
                //    this.deportivo.validarEquipos(EquiposAux);
                //}              
                cargarListDeportes();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Equipo equipo;
            int index = lst_deportes.SelectedIndex;
            if(index!=-1)
            {
                equipo = (Equipo)lst_deportes.SelectedItem;

                if(MessageBox.Show("Seguro quieres borrar el equipo?", "Estas por borrar un equipo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==
                    DialogResult.OK)
                {
                    lst_deportes.Items.Remove(equipo);
                    EquiposAux.Remove(equipo);
                   // deportivo.borrarEquipo(equipo);
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
            EArea area;
            

            if (form == EFormEmpleado.deportivo)
            {
                if(deportivo is null)
                {
                    if (validarCamposLlenos())
                    {
                       
                        try
                        {
                           DB.AgregarDeportivo(nombre, apellido, sexo, nacimiento, EquiposAux);
                            MessageBox.Show($"Empleado {apellido} se creo con exito", "Creacion exitosa", MessageBoxButtons.OK);

                        }
                        catch(PersonaRepetidaException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        AbrirFormularioAnterior();
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
                        if (DB.UpdateDeportivo(deportivo, nombre, apellido, sexo, nacimiento, EquiposAux))
                        {
                            MessageBox.Show($"Empleado {apellido} actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK);
                            AbrirFormularioAnterior();
                        }
                        else
                        {

                        }
                    }
                }
                
            }
            else
            {
                area = (EArea)cmb_area.SelectedItem;
                if (operativo is null)
                {
                    if (validarCamposLlenos())
                    {

                        try
                        {
                           DB.AgregarOperativo(nombre, apellido, sexo, nacimiento, area);
                            MessageBox.Show($"Empleado {apellido} se creo con exito", "Creacion exitosa", MessageBoxButtons.OK);

                        }
                        catch (PersonaRepetidaException ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        AbrirFormularioAnterior();
                    }
                }
                else if (DB.UpdateOperativo(operativo, nombre, apellido, sexo, nacimiento, area))
                {
                    MessageBox.Show($"Empleado {apellido} actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK);
                    AbrirFormularioAnterior();
                }
            }
        }

        private void AbrirFormularioAnterior()
        {
            try
            {
                DB.TraerEmpleadosDeportivos();
                DB.TraerOperativos();
            }
            catch
            {
                MessageBox.Show("No se cargaron los empleados correctamente. Vuelva a abrir la aplicacion");
            }

            FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo> frm = new FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo>(Club.Operativos, Club.Deportivos, EForm.empleado);
            frm.Show();
            this.Close();
        }

        

        protected override bool validarCamposLlenos()
        {
            if (base.validarCamposLlenos())
            {
                if (EFormEmpleado.operativo==form)
                {
                    if (cmb_area.SelectedItem != null)
                    {
                        return true;

                    }
                }
                else
                {
                    if (lst_deportes.Items.Count != 0 && EquiposAux.Count!=0)
                    {
                        
                        return true;
                    }
                }

            }
            return false;
        }


    }
}
