﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Valida los datos ingresados y si son correctos realiza la operacion
        /// correspondiente segun el operador ingresado
        /// </summary>
        /// <param name="num1">Operando num1</param>
        /// <param name="num2">Operando num2</param>
        /// <param name="operador">char operador</param>
        /// <returns> 0 si [ERROR] o resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double res = 0;
            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;

            }

            return res;
        }

        /// <summary>
        /// Valida el operador recibido sea + - *  / 
        /// </summary>
        /// <param name="operador">char operador</param>
        /// <returns>el operador validado u operador + por defecto</returns>
        private static char ValidarOperador(char operador)
        {

            if (operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            else
                return '+';
        }




    }
}
