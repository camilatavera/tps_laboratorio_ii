using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteca;
using ManejoArchivos;
using ManejoDB;

namespace AdministracionClub
{
    public partial class FrmInicio : Form
    {
        Task taskxml;
        Task taskdb;
        InicioDB db;
        public FrmInicio()
        {
            InitializeComponent();
            db = new InicioDB();
        }

        private async void btn_socios_Click(object sender, EventArgs e)
        {
            IniciarProcesoSocios();
            while(taskdb is null || taskdb.IsCompleted==false)
            {
                if(taskdb is not null)
                {
                    await taskdb;
                    break;
                }
            }

            FrmPersonas<Socio, Federado> frm = new FrmPersonas<Socio, Federado>(Club.Socios, Club.Federados, EForm.socio);
            frm.Show();

        }

        private async void btn_empleado_Click(object sender, EventArgs e)
        {
            await IniciarProcesoEmpleado();
            FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo> frm = new FrmPersonas<EmpleadoOperativo, EmpleadoDeportivo>(Club.Operativos, Club.Deportivos, EForm.empleado);
            frm.Show();

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

           

        }


        private void msj_XML(string mensaje)
        {
            if (lbl_xml.InvokeRequired)
            {
                Action<string> delegadoIniciar = msj_XML;
                object[] parametros = new object[] { mensaje };
                lbl_xml.Invoke(delegadoIniciar, parametros);
            }
            else
            {
                lbl_xml.Text = mensaje;
            }

        }

        private async Task IniciarProcesoEmpleado()
        {
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "Equipos.xml";
            Club.eventoAviso += msj_XML;
            db.eventoInicio += msj_DB;
            db.eventoFinal += msj_DB;
            await Club.inicioTask(archivo);
            await db.InicioTask(EForm.empleado);
            
        }

        private void IniciarProcesoSocios()
        {
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "Equipos.xml";
            Club.eventoAviso += msj_XML;
            db.eventoInicio += msj_DB;
            db.eventoFinal += msj_DB;
            taskxml=Club.inicioTask(archivo);
            taskdb=db.InicioTask(EForm.socio);
            

        }




        private void msj_DB(string mensaje)
        {
            if (lbl_db.InvokeRequired)
            {
                Action<string> delegadoIniciar = msj_DB;
                object[] parametros = new object[] { mensaje };
                lbl_db.Invoke(delegadoIniciar, parametros);
            }
            else
            {
                lbl_db.Text = mensaje;
            }

        }

        
    }
}
