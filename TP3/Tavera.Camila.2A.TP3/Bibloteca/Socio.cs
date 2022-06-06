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

        public Socio()
        {

        }

       

        public Socio(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria) :
            base(nombre, apellido, sexo, fechaNacimiento)
        {
            this.categoria = categoria;
            generarDeuda();
        }


        public Socio(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int aPagar) :
            base(nombre, apellido, sexo, fechaNacimiento)
        {
            this.Categoria = categoria;
            this.APagar = aPagar;
        }

        public ECategoria Categoria
        {
            get { return categoria;  }
            set { categoria = value; }
        }

        public  int CuotaSocial
        {
            get {return this.calcularCuota(); }
            
        }

        public int APagar
        {
            get { return aPagar; }
            set { aPagar = value; }
        }

        protected virtual int calcularCuota()
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

        protected void generarDeuda()
        {
            Random aux = new Random();
            int meses = aux.Next(0, 6);
            this.aPagar = CuotaSocial * meses;
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Categoria: {Categoria} | Cuota mensual {CuotaSocial} | A pagar: {aPagar}";

        }

        public override string DatosGenerales
        {
            get { return $"{ToString()} | Federado: No";  }
        }

        public string escribirFactura(int montoIngresado)
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

        public  bool actualizarDatos(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        {
            bool ret=actualizarDatos(nombre, apellido, sexo, fechaNacimiento);
            if (this.Categoria != categoria)
            {
                this.categoria = categoria;
                ret = true;
            }

            return ret;
        }

        public bool validarMonto(string montoIngresado, out int ingresoInt)
        {
            int ingreso=0;
            if(!int.TryParse(montoIngresado, out ingreso))
            {
                throw new ExMontoIngresado("Debe ingresar un numero sin puntos ni comas");
            }

            if (ingreso <= APagar && ingreso>=this.CuotaSocial)
            {
                ingresoInt = ingreso;
                return true;
            }
            else
            {
                throw new ExMontoIngresado("Se debe cobrar una cuota social como minimo");
            }

        }

        public void saldarDeuda(int monto)
        {
            this.aPagar -= monto;
        }




    }
}
