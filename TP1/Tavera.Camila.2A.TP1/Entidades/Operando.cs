using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {

        private double numero;

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
            get
            {
                return this.numero.ToString();
            }
        }

        /// <summary>
        /// Valida si el numero binario de tipo de dato string ingresado es binario, y en
        /// caso de serlo lo convierte a decimal.
        /// </summary>
        /// <param name="binario">string binario</param>
        /// <returns>Numero decimal en tipo de dato string o "Valor Invalido"</returns>

        public string BinarioDecimal(string binario)
        {

            Stack<char> pilaNumeros = new Stack<char>();
            int decimalAux = 0;
            int multiplicarAux = 1;
            char numeroOut;

            if (EsBinario(binario))
            {

                foreach (char letra in binario)
                {
                    pilaNumeros.Push(letra);

                }
                for (int i = 0; i <= binario.Length - 1; i++)
                {
                    numeroOut = pilaNumeros.Pop();
                    if (numeroOut == '1')
                    {
                        decimalAux += multiplicarAux;
                    }
                    multiplicarAux = multiplicarAux * 2;
                }

                return decimalAux.ToString();

            }


            return "Valor Invalido";
        }

        /// <summary>
        ///  Convierte un numero decimal de tipo de dato double en un numero binario
        /// </summary>
        /// <param name="numero">double numero</param>
        /// <returns>numero decimal en tipo de dato string</returns>
        public string DecimalBinario(double numero)  
        {
            int numeroEntero = (int)numero;
            string numeroBinario;

            numeroBinario = Convert.ToString(numeroEntero, 2);
            if (numeroBinario != null)
                return numeroBinario;

            return "Valor invalido";

        }


        /// <summary>
        ///  Convierte un numero decimal de tipo de dato string en un numero binario
        /// </summary>
        /// <param name="numero">string numero</param>
        /// <returns>numero decimal en tipo de dato string</returns>
        public string DecimalBinario(string numero)
        {
            double numDouble;
            string numeroBinario;
            if (double.TryParse(numero, out numDouble))
            {
                numeroBinario = DecimalBinario(numDouble);
                return numeroBinario;
            }
            return "Valor invalido";
        }


        /// <summary>
        ///  Convierte un numero decimal de tipo de dato double en un numero binario
        /// </summary>
        /// <param name="numero">string binario</param>
        /// <returns>numero decimal en tipo de dato string</returns>
        private bool EsBinario(string binario)
        {
            bool ret = true;
            if (binario.Length >= 4)
            {
                foreach (char letra in binario)
                {
                    if (letra != '1' && letra != '0')
                    {
                        ret = false;
                        break;
                    }
                }

            }

            return ret;
        }


        public Operando() : this(0)
        {

        }

        public Operando(double numero) : this(numero.ToString())
        {
        }



        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="n1"> Operando n1</param>
        /// <param name="n2">Operando n2</param>
        /// <returns>Resultado de tipo double de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double res = n1.numero - n2.numero;
            return res;
        }


        /// <summary>
        /// Sobrecarga del operador *
        /// </summary>
        /// <param name="n1"> Operando n1</param>
        /// <param name="n2">Operando n2</param>
        /// <returns>Resultado de tipo double de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double res = n1.numero * n2.numero;
            return res;
        }


        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1"> Operando n1</param>
        /// <param name="n2">Operando n2</param>
        /// <returns>Resultado de tipo double de la division</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double res = n1.numero / n2.numero;
            return res;

        }



        /// <summary>
        /// Sobrecarga del operador + 
        /// </summary>
        /// <param name="n1"> Operando n1</param>
        /// <param name="n2">Operando n2</param>
        /// <returns>Resultado de tipo double de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double res = n1.numero + n2.numero;
            return res;
        }


        /// <summary>
        /// Valida que la cadena ingresada se pueda a castear a double
        /// </summary>
        /// <param name="strNumero">string strNumero: numero a castear</param>
        /// <returns>Numero casteado o 0 si [ERROR] </returns>
        private double ValidarOperando(string strNumero)
        {
            double ret;
            if (!double.TryParse(strNumero, out ret))
            {
                ret = 0;
            }
            return ret;
        }
    }
}
