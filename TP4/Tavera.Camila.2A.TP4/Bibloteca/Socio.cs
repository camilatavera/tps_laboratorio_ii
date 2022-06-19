using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class Socio:Persona
    {
        ECategoria categoria;
        int aPagar;

       

        public Socio(int id, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int aPagar) :
            base(id, nombre, apellido, sexo, fechaNacimiento)
        {
            this.Categoria = categoria;
            this.APagar = aPagar;
        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo categoria
        /// </summary>
        public ECategoria Categoria
        {
            get { return categoria;  }
            set { categoria = value; }
        }

        /// <summary>
        /// propiedad de lectura de la cuota social
        /// </summary>
        public int CuotaSocial
        {
            get {return this.CalcularCuota(); }
            
        }

        /// <summary>
        /// propiedad de lectura y escritura del atributo APagar
        /// </summary>
        public int APagar
        {
            get { return aPagar; }
            set { aPagar = value; }
        }


        /// <summary>
        /// calcula la cuota social segun el atributo categoria
        /// </summary>
        /// <returns>int:cuota soical</returns>
        protected virtual int CalcularCuota()
        {
            if (Categoria == ECategoria.menores)
            {
                return 2000;
            }
            else if (Categoria == ECategoria.juveniles)
            {
                return 2500;
            }
            else 
            {
                return 3000;
            }
           
        }

  
       
        public override string ToString()
        {
            return $"{base.ToString()} | Categoria: {Categoria} | Cuota mensual {CuotaSocial} | A pagar: {aPagar}";

        }

        
        /// <summary>
        /// Escribe la un string segun lo abonado por el socio
        /// </summary>
        /// <param name="montoIngresado"></param>
        /// <returns> resuelto </returns>
        public string EscribirFactura(int montoIngresado)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"PAGO REALIZADO POR {Nombre} {Apellido}");
            sb.AppendLine($"Fecha {DateTime.Now.ToLongTimeString()} \n");
            sb.AppendLine($"Datos del socio:");
            sb.AppendFormat($"Nombre: {Nombre}\n" +
                $"Apellido {Apellido} \n" +
                $"Sexo: {Sexo} \n" +
                $"Categoria: {Categoria} \n " +
                $"Cuota Mensual: {CuotaSocial} \n \n" +
                $"Deuda Previa: {APagar} \n" +
                $"Monto ingresado: {montoIngresado} \n" +
                $"Deuda Actual: {APagar - montoIngresado} \n \n \n" +
                $"" +
                $"TOTAL A PAGAR {montoIngresado}"
                );


            return sb.ToString();

        } 

        /// <summary>
        /// Actualiza los valores de los atributos del objeto si corresponde
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <returns>bool</returns>
        public  bool ActualizarDatos(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        {
            bool ret=ActualizarDatos(nombre, apellido, sexo, fechaNacimiento);
            if (this.Categoria != categoria)
            {
                this.categoria = categoria;
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// valida que el monto coincida con lo que debe el socio y con lo que abona de cuota
        /// </summary>
        /// <param name="montoIngresado"></param>
        /// <param name="ingresoInt"></param>
        /// <returns>bool</returns>
        public bool ValidarMonto(string montoIngresado, out int ingresoInt)
        {
            int ingreso=0;
            if(!int.TryParse(montoIngresado, out ingreso))
            {
                throw new MontoIngresadoException("Debe ingresar un numero sin puntos ni comas");
            }

            if (ingreso <= APagar)
            {
                ingresoInt = ingreso;
                return true;
            }
            else
            {
                throw new MontoIngresadoException("El ingreso es mayor a la deuda");
            }

        }


        /// <summary>
        /// le resta al atributo APagar lo que abono el socio
        /// </summary>
        /// <param name="monto"></param>
        public void SaldarDeuda(int monto)
        {
            this.aPagar -= monto;
        }




    }
}
