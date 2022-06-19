using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bibloteca;


namespace ManejoDB
{
    //DELEGADO
    public delegate void mensajeEvento(string mensaje);
    public class InicioDB
    {

        //EVENTOS
        public event mensajeEvento eventoInicio;
        public event mensajeEvento eventoFinal;

        public InicioDB() { }





         //   <summary>
        //Invoca los eventos y trae los empleados de la base de datos.
        // </summary>
        public void TraerEmpleados()
        {


            if (eventoFinal is not null && eventoInicio is not null)
            {
                eventoInicio.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Iniciando base de datos");
                try
                {
                    DB.TraerOperativos();
                    DB.TraerEmpleadosDeportivos();

                }
                catch (Exception ex)
                {
                    Thread.Sleep(2000);
                    eventoFinal.Invoke(($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Error al traer la base de datos: {ex.Message}"));
                    return;
                }
                Thread.Sleep(6000);
                eventoFinal.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Base de datos descargada con exito");

            }


        }

        //   <summary>
        //Invoca los eventos y trae los socios y federados de la base de datos.
        // </summary>
        public void TraerSociosFederados()
        {


            if (eventoFinal is not null && eventoInicio is not null)
            {
                eventoInicio.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Iniciando base de datos");
                try
                {
                    DB.TraerSocios();
                    DB.TraerFederados();

                }
                catch (Exception ex)
                {
                    Thread.Sleep(2000);
                    eventoFinal.Invoke(($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Error al traer la base de datos: {ex.Message}"));
                    return;
                }
                Thread.Sleep(6000);
                eventoFinal.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Base de datos descargada con exito");

            }


        }


        /// <summary>
        /// Corre las tareas segun corresponda
        /// </summary>
        /// <param name="form"></param>
        /// <returns>Task</returns>
        public Task InicioTask(EForm form)
        {
            Task tarea;
            if (form == EForm.empleado)
            {
                tarea = Task.Run(TraerEmpleados);
            }
            else
                tarea = Task.Run(TraerSociosFederados);

            return tarea;


        }



    }
}
