using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {

        #region atributos y propiedades

        private double numeroo;

        public string Numeroo
        {
            set
            {
                if (ValidarNumero(value) != 0)
                {
                    this.numeroo = ValidarNumero(value);
                }

            }
        }



        #endregion

        #region metodos

        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>el numero en formato string</returns>
        public static string BinarioDecimal(string binario)
        {
            string stringNumero;
            int cantidadDeCifras;
            bool numeroValido;
            numeroValido = double.TryParse(binario, out double numeroDecimal);

            if (numeroValido)
            {
                cantidadDeCifras = binario.Length;
                numeroDecimal = 0;
                for (int i = 0; i < cantidadDeCifras; i++)
                {
                    if (binario.ElementAt(i) == '1')
                    {
                        numeroDecimal = numeroDecimal + Math.Pow(2, cantidadDeCifras - i - 1);
                    }
                    else if (binario.ElementAt(i) != '0')
                    {
                        return "Numero invalido";
                    }
                }

                stringNumero = numeroDecimal + "";
            }
            else
                stringNumero = "Numero invalido";

            return stringNumero;
        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna un string de número en binario</returns>
        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    numero = (int)numero / 2;
                }
            }
            else if (numero == 0)
            {
                numeroBinario = "0";
            }
            else
            {
                numeroBinario = "No se pudo convertir a binario";
            }

            return numeroBinario;
        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {

            double numeroDecimal;
            bool numeroValido;

            string numeroEnBinario = "Numero invalido";

            numeroValido = double.TryParse(numero, out numeroDecimal);

            if (numeroValido)
                numeroEnBinario = DecimalBinario(numeroDecimal);

            return numeroEnBinario;
        }

        /// <summary>
        /// Validacion que devuelve 0 si el dato es invalido y el dato ingresado en formato double en caso de ser valido
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarNumero(string strNumero)
        {
            bool isValidNum;
            isValidNum = double.TryParse(strNumero, out double numeroo);

            if (isValidNum == true)
            {
                return numeroo;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region operadores


        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numeroo - n2.numeroo;
            return resultado;
        }



        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numeroo + n2.numeroo;
            return resultado;
        }



        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;
            if (n2.numeroo == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numeroo / n2.numeroo;
            }
            return resultado;
        }



        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numeroo * n2.numeroo;
            return resultado;
        }
        #endregion

        #region constructores

        public Numero() : this(0)
        {

        }

        public Numero(double dblNum)
        {
            this.numeroo = dblNum;
        }

        public Numero(string strNum)
        {
            this.Numeroo = strNum;
        }

        #endregion
    }
}