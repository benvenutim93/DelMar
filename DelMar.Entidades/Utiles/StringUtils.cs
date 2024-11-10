using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DelMar.Entidades.Utiles
{

    /// <summary>
    /// Provee métodos útiles para manipular cadenas
    /// <remarks>Clase Estática</remarks>
    /// <author>Ramiro</author>
    /// </summary>
    static public class StringUtils
    {

        static readonly char[] simbolos = { 'ª', 'º', ',', ';', '.', ':', '\\', '|', '"', (char)39, '°', '´', 'ç', '~', '£', '/', '�', '§', '!', '¡', '¤', 'µ', 'ÿ', '¢', 'ø' }; // char 39 = '


        /// <summary>
        /// Trunca la cadena según el valor pasado en tope. Si es NULL devuelve string.Empty
        /// </summary>
        /// <param name="cadena">Cadena a truncar.</param>
        /// <param name="tope">Valor tope del string.</param>
        /// <returns>string con la cadena truncada</returns>
        public static string TruncaCadena(string cadena, byte tope)
        {
            return string.IsNullOrEmpty(cadena) ? string.Empty : cadena.Length <= tope || tope < 1 ? cadena : cadena.Substring(0, tope);
        }

        /// <summary>
        /// Divide (split) una cadena en tantas cadenas como sea necesario según el separador indicado.
        /// Ej: SplitCadena("ramiroguasti@hotmail.com", '@') = {"ramiroguasti", "hotmail.com"}
        /// </summary>
        /// <param name="cadena">Cadena.</param>
        /// <param name="separador">El caracter separador.</param>
        /// <returns>string[] arreglo con cada subcadena resultante</returns>
        public static string[] SplitCadena(string cadena, char separador)
        {
            return cadena.Split(separador);
        }

        /// <summary>
        /// Elimina los ceros a la izquierda de una cadena que puede representar un número.
        /// </summary>
        /// <param name="cadena">la cadena a truncar.</param>
        /// <returns>string</returns>
        public static string EliminaCerosIzquierda(string cadena)
        {
            return cadena.TrimStart('0');
        }

        /// <summary>
        /// Completa una cadena con ceros a la izquierda según la longitud indicada.
        /// Solo si la longitud pasada es mayor al largo de la cadena.
        /// </summary>
        /// <param name="cadena">la cadena original.</param>
        /// <param name="longitud">la longitud final de la cadena (solo si es mayor al largo actual.</param>
        /// <returns>string</returns>
        public static string AgregaCerosIzquierda(string cadena, int longitud)
        {
            return cadena.PadLeft(longitud, '0');
        }


        /// <summary>
        /// Determina si un char representa un número.
        /// </summary>
        /// <param name="caracter">el caracter.</param>
        /// <returns>bool true si es un dígito, false en otro caso</returns>
        public static bool EsNumeroEntero(char caracter)
        {
            return char.IsDigit(caracter);
        }

        /// <summary>
        /// Determina si un string representa un número Entero y Sin Signo.
        /// </summary>
        /// <param name="cadena">la cadena</param>
        /// <returns>bool true si es un número, false en otro caso</returns>
        public static bool EsNumeroEntero(string cadena)
        {
            return cadena != null && Regex.IsMatch(cadena, "^[0-9]+$");
        }

        /// <summary>
        /// Determina si un string representa un número Decimal Con Signo.
        /// </summary>
        /// <param name="cadena">la cadena</param>
        /// <returns>bool true si es un número, false en otro caso</returns>
        public static bool EsNumeroDecimal(string cadena)
        {
            return cadena != null && Regex.IsMatch(cadena, @"^-?\s*\d*(\.\d{1,4})?\s*$");
        }

        /// <summary>
        /// Determina si un string representa un número. Es la validación más general
        /// pero menos eficiente (ver  EsNumeroEntero() y EsNumeroDecimal())
        /// </summary>
        /// <param name="cadena">la cadena</param>
        /// <returns>bool true si es un número, false en otro caso</returns>
        public static bool IsNumeric(string cadena)
        {
            try
            {
                double.Parse(cadena);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Filtra la palabra especificada. Quita los siguientes caracteres:
        /// 'ª' 'º' '|' ',' ';' '.' ':' '"' '\' "'"
        /// </summary>
        /// <param name="palabra">string con la palabra a filtrar. Si es NULL devuelve ""</param>
        /// <returns>string con el resultado filtrado. Ej. "pe\pe" --> "pepe"</returns>
        public static string Filtrar(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return string.Empty;
            }

            for (int i = 0; palabra.Length > 0 && i < simbolos.Length; i++)
            {
                palabra = palabra.Replace(simbolos[i], ' ');
            }
            return palabra;
        }

        /// <summary>
        /// Filtra la palabra dada quitando los caracteres indicados.
        /// </summary>
        /// <param name="palabra">string con la palabra a filtrar. Si es NULL devuelve ""</param>
        /// <param name="caracteres">arreglo con los caracteres a quitar</param>
        /// <returns>string con el resultado filtrado. Ej. "pe\pe" --> "pepe"</returns>
        public static string Filtrar(string palabra, char[] caracteres)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return string.Empty;
            }

            for (int i = 0; palabra.Length > 0 && i < caracteres.Length; i++)
            {
                palabra = palabra.Replace(caracteres[i], ' ');
            }
            return palabra;
        }

        /// <summary>
        /// Reemplaza cualquier vocal con acento por su igual sin acento, 
        /// tanto minuscula como mayuscula. Ej: 'RAÚL' --> 'RAUL'
        /// </summary>
        /// <param name="palabra">Palabra al cual se le quieren eliminar los acentos.</param>
        public static string QuitarAcentos(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return string.Empty;
            }

            palabra = palabra.Replace('á', 'a');
            palabra = palabra.Replace('Á', 'A');
            palabra = palabra.Replace('é', 'e');
            palabra = palabra.Replace('É', 'E');
            palabra = palabra.Replace('í', 'i');
            palabra = palabra.Replace('Í', 'I');
            palabra = palabra.Replace('ó', 'o');
            palabra = palabra.Replace('Ó', 'O');
            palabra = palabra.Replace('ú', 'u');
            palabra = palabra.Replace('Ú', 'U');
            return palabra;
        }

        /// <summary>
        /// Reemplaza cualquier vocal con diéresis por su igual sin diéresis, 
        /// tanto minuscula como mayuscula. Ej: 'Ü' --> 'U'
        /// </summary>
        /// <param name="palabra">Palabra al cual se le quieren eliminar las diéresis.</param>
        public static string QuitarDieresis(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return string.Empty;
            }

            palabra = palabra.Replace('ä', 'a');
            palabra = palabra.Replace('ë', 'e');
            palabra = palabra.Replace('ï', 'i');
            palabra = palabra.Replace('ö', 'o');
            palabra = palabra.Replace('ü', 'u');
            palabra = palabra.Replace('Ä', 'A');
            palabra = palabra.Replace('Ë', 'E');
            palabra = palabra.Replace('Ï', 'I');
            palabra = palabra.Replace('Ö', 'O');
            palabra = palabra.Replace('Ü', 'U');
            return palabra;
        }

        /// <summary>
        /// Reemplaza cualquier aparición de 'Ñ' o 'ñ' por la letra 'N' o 'n'        
        /// </summary>
        /// <param name="palabra">Palabra al cual se le quieren eliminar las Ñs.</param>
        public static string QuitarEnies(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return string.Empty;
            }

            palabra = palabra.Replace('Ñ', 'N');
            palabra = palabra.Replace('ñ', 'n');
            return palabra;
        }

        /// <summary>
        /// Busca caracteres en una cadena segun el parametro caracteres.
        /// </summary>
        /// <param name="palabra">string con la palabra a filtrar.</param>
        /// <param name="caracteres">arreglo con los caracteres a quitar</param>
        /// <returns>True en el caso de encontrar algun caracter segun el parametro enviado</returns>
        public static bool Contiene(string palabra, char[] caracteres)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return false;
            }

            for (int i = 0; palabra.Length > 0 && i < caracteres.Length; i++)
            {
                if (palabra.Contains(caracteres[i].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Valida que un string tenga la estructura de una dirección de e-mail, ó
        /// Valida que en un string con direcciones de Mail separadas por punto y coma (;) exista al menos una válida.
        /// Debe empezar con una letra, tener @, permite separaciones por puntos, etc.
        /// </summary>
        /// <param name="email">Cadena con la dirección de email ó con direcciones de email separadas por punto y coma (;).</param>
        /// <returns>[true] si la cadena cotiene al menos un email válido, [false] en otro caso.</returns>
        public static bool EsMailCorrecto(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            foreach (var mail in email.Split(';'))
            {
                if (Regex.IsMatch(mail.Trim(), expresion))
                {
                    if (Regex.Replace(mail.Trim(), expresion, string.Empty).Length != 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }


        /// <summary>
        /// Calcula el dígito verificador dado un CUIT completo o sin él.
        /// </summary>
        /// <param name="cuit">El CUIT como String sin guiones</param>
        /// <returns>El valor del dígito verificador calculado.</returns>
        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;

            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        /// <summary>
        /// Valida el CUIT ingresado.
        /// </summary>
        /// <param name="cuit">Número de CUIT como string con o sin guiones.</param>
        /// <returns>True si el CUIT es válido y False si no.</returns>
        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null || cuit == string.Empty)
            {
                return false;
            }

            // quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }

        /// <summary>
        /// Compara dos valores (valorA, valorB) segun un operador de comparación
        /// </summary>
        /// <param name="operador">Operadores válidos: ">", "&lt;" , "=", "&lt;=", ">=", "&lt;>"</param>
        /// <param name="valorA"></param>
        /// <param name="valorB"></param>
        /// <returns>[true] o [false] según la evaluación de los parámetros.</returns>
        public static bool CompararNumeros(string operador, decimal valorA, decimal valorB)
        {
            switch (operador)
            {
                case ">":
                    return valorA > valorB;

                case "<":
                    return valorA < valorB;

                case "=":
                    return valorA == valorB;

                case ">=":
                    return valorA >= valorB;

                case "<=":
                    return valorA <= valorB;

                case "<>":
                    return valorA != valorB;

                default:
                    throw new ArgumentException("Operador de comparación inválido");
            }
        }



        /// <summary>
        /// Valida que la cadena pasada corresponda a una Patente. Sólo permite los formatos vigentes XXX111 y XX111XX.
        /// X --> letras, 1 --> números.
        /// </summary>
        /// <param name="patente">Cadena correspondiente a una Patente.</param>
        /// <returns>True si la patente es válida y False si no.</returns>
        public static bool ValidaPatente(string patente)
        {

            #region VALIDACIONES PREVIAS

            if (patente == null || patente == string.Empty)
            {
                return false;
            }

            // Sacamos los guiones/barras/etc y evaluamos la longitud de la patente resultante.
            patente = Filtrar(patente).PadRight(patente.Length);

            // Eliminamos todos los espacios de la cadena
            patente = patente.Replace(" ", "");

            // Aceptamos como válidas solo los formatos de patentes vigentes (XXX111 y XX111XX)
            // de 6 o 7 caracteres según el formato seleccionado
            if (patente.Length != 6 && patente.Length != 7)
            {
                return false;
            }

            #endregion

            #region VALIDACION del FORMATO de la PATENTE

            // Variables para los segmentos que componen la patente
            string patenteNumerica;
            string patenteAlfanumerica;

            // Dependiendo del formato ingresado; subdividimos la patente en (XXX123) o (XX111XX);
            // y validamos cada segmento de la patente   
            if (patente.Length == 6)
            {
                patenteAlfanumerica = patente.Substring(0, 3);
                patenteNumerica = patente.Substring(3, 3);

                return EsNumeroEntero(patenteNumerica) && !EsNumeroEntero(patenteAlfanumerica);
            }
            else
            {
                patenteAlfanumerica = patente.Substring(0, 2);
                patenteNumerica = patente.Substring(2, 3);
                string patenteAlfanumerica2 = patente.Substring(5, 2);

                return EsNumeroEntero(patenteNumerica) &&
                      !EsNumeroEntero(patenteAlfanumerica) &&
                      !EsNumeroEntero(patenteAlfanumerica2);
            }

            #endregion
        }

        /// <summary>
        /// Genera un código Alfa-Numérico aleatorio de la longitud solicitada.
        /// </summary>
        /// <param name="length">Longitud del código a devolver.</param>
        public static string GenerarCodigo(int length)
        {
            var rand = new Random();
            string cadenaFuente = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            string codigo = string.Empty;
            for (int i = 0; i < length; i++)
            {
                codigo += cadenaFuente[rand.Next(cadenaFuente.Length)].ToString();
            }
            return codigo;
        }


        /// <summary>
        /// Toma una cadena y coloca en Mayúscula el comienzo de cada palabra de la misma.
        /// Además quita cualquier espacio de más al comienzo, final o entre palabras.
        /// Ej: ESTO  es una   chachara! --> Esto Es Una Chachara!
        /// </summary>
        /// <param name="cadena">Palabra a capitabilizar.</param>
        public static string Capitalize(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return string.Empty;
            }

            // creamos un TextInfo basado en cultura "es-AR" para utilizar el metodo ToTitleCase
            var titleCase = new CultureInfo("es-AR", false).TextInfo.ToTitleCase(cadena.ToLower());

            // usamos un string Join para eliminar cualquier espacio de más entre palabras, al inicio o al final...
            return string.Join(" ", titleCase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        /// <summary>
        /// Toma una cadena y coloca en Mayúscula el comienzo de cada palabra de la misma que tenga más de N caracteres.
        /// Además quita cualquier espacio de más al comienzo, final o entre palabras.
        /// Ej: ESTO  es una   chachara! --> Esto es una Chachara!
        /// </summary>
        /// <param name="cadena">Palabra a capitabilizar.</param>
        /// <param name="largoMinimo">Indica la cantidad minima de caracteres a contemplar para Capitalizar cada palabra.</param>
        public static string CapitalizeLong(string cadena, short largoMinimo)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return string.Empty;
            }

            // usamos un string Join para eliminar cualquier espacio de más entre palabras, al inicio o al final...
            cadena = string.Join(" ", cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)).ToLower();

            var textInfo = new CultureInfo("es-AR", false).TextInfo;
            var cadenaFinal = string.Empty;

            foreach (var palabra in cadena.Split(' '))
            {
                if (cadenaFinal.Length == 0)
                { // primer palabra!
                    cadenaFinal += textInfo.ToTitleCase(palabra) + " ";
                }
                else
                {
                    cadenaFinal += (palabra.Length > largoMinimo ? textInfo.ToTitleCase(palabra) : palabra) + " ";
                }
            }

            return cadenaFinal.Trim();
        }

        /// <summary>
        /// Toma una palabra y devuelve un Path para búsquedas HASH de tantos niveles como se indique (y la palabra lo soporte).
        /// Ej: HashPath("fernet.jpg", 2) --> "/f/e/"
        /// </summary>
        /// <param name="palabra">Palabra a utilizar para definir el HashPath.</param>
        /// <param name="nivel">Cantidad de niveles del Path.</param>
        public static string HashPath(string palabra, short nivel)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                return "/";
            }

            var palabraHash = palabra.Trim();
            var cadenaFinal = string.Empty;
            int i = 1;
            while (i <= nivel)
            {
                if (palabraHash.Length > 0)
                {
                    cadenaFinal += "/" + palabraHash.First();
                    palabraHash = palabraHash.Remove(0, 1);
                }
                i++;
            }

            return cadenaFinal + "/";
        }

        /// <summary>
        /// Crea una string a partir de una lista de numeros enteros. Cada número se separa por el caracter indicado. 
        /// Se usa ',' por Default. No se incluye el caracter de sepración al final.
        /// Ejemplo: List { 1, 2, 3} => "1,2,3"
        /// </summary>
        /// <param name="listaEnteros">Lista de numeros enteros.</param>
        /// <param name="separador">Caracter a utilizar para separar los números.</param>
        /// <returns>Cadena con los numeros concatenados con el caracter indicado.</returns>
        public static string GetStringFromListInt(List<int> listaEnteros, char separador = ',')
        {
            var sbNumeros = new StringBuilder();

            foreach (var numero in listaEnteros)
            {
                sbNumeros.Append(numero.ToString());
                sbNumeros.Append(separador);
            }

            return sbNumeros.Length > 0 ? sbNumeros.ToString(0, sbNumeros.Length - 1) : string.Empty;
        }

    }
}
