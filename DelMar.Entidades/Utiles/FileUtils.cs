using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelMar.Entidades.Utiles
{
    /// <summary>
    /// Clase de Utilidad para el manejo de Archivos. Provee funcionalidades para:
    /// - Grabación y lectura de archivos de texto.
    /// - Generar un archivo de texto separado por un caracter a partir de un DataTable.
    /// - Comprimir/descomprimir archivos en formato ZIP.
    /// - Borrar uno o muchos archivos de acuerdo a un patrón.
    /// <author>Ramiro Guasti</author>
    /// </summary>
    public static class FileUtils
    {

        #region ARCHIVOS de TEXTO

        /// <summary>
        /// Lee un archivo y retorna cada linea en un enumerable.
        /// </summary>
        /// <param name="file">FileInfo entity</param>
        /// <param name="archivoConHeader">True Se descarta el header. False No se descarta el header</param>
        public static IEnumerable<string> EnumerateLines(this FileInfo file, bool archivoConHeader = true)
        {

            using (var stream = File.Open(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(stream))
            {
                var line = string.Empty;
                if (archivoConHeader)
                {
                    line = reader.ReadLine();
                }
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        /// <summary>
        /// Lee archivo de texto. Devuelve su contenido en un string respetando salto de líneas.
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <returns>string con el contenido del archivo, string vacio si no se pudo leer o no existe el archivo.</returns>
        public static string GetStringFromFile(string archivo)
        {
            string cadena = string.Empty;
            if (File.Exists(archivo))
            {
                using (var stream = new FileStream(archivo, FileMode.Open, FileAccess.Read))
                using (var reader = new StreamReader(stream))
                {
                    while (reader.Peek() > -1)
                    {
                        cadena = cadena + reader.ReadLine() + "\r\n";
                    }
                }
            }

            return cadena;
        }

        /// <summary>
        /// Agrega una cadena a una archivo de Texto (realiza un append).
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <param name="cadena">Cadena a grabar.</param>
        /// <param name="saltoLinea">Indica si se debe grabar un salto de línea luego de la cadena.</param>
        /// <returns>[true] si la operación se completo, [false] en otro caso.</returns>
        public static bool SaveStringToFile(string archivo, string cadena, bool saltoLinea)
        {

            if (File.Exists(archivo))
            {
                using (var stream = new FileStream(archivo, FileMode.Append, FileAccess.Write))
                using (var writer = new StreamWriter(stream))
                {
                    if (saltoLinea)
                    {
                        writer.WriteLine(cadena); // graba línea y salto
                    }
                    else
                    {
                        writer.Write(cadena); // graba línea a continuación
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Agrega una lista de cadenas a una archivo de Texto (realiza un append).
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <param name="listaCadenas">Lista de cadenas a grabar.</param>
        /// <param name="saltoLinea">Indica si se debe grabar un salto de línea luego de la cadena.</param>
        /// <returns>[true] si la operación se completo, [false] en otro caso.</returns>
        public static bool SaveStringToFile(string archivo, List<string> listaCadenas, bool saltoLinea)
        {

            if (File.Exists(archivo))
            {
                using (var stream = new FileStream(archivo, FileMode.Append, FileAccess.Write))
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var cadena in listaCadenas)
                    {
                        if (saltoLinea)
                        {
                            writer.WriteLine(cadena); // graba línea y salto
                        }
                        else
                        {
                            writer.Write(cadena); // graba línea a continuación
                        }
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Agrega una cadena a una archivo de Texto (realiza un append). Permite indicar si se crea el archivo de NO existir.
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <param name="cadena">Cadena a grabar.</param>
        /// <param name="saltoLinea">Indica si se debe grabar un salto de línea luego de la cadena.</param>
        /// <param name="creaArchivo">[true] si el archivo NO existe lo crea, [false] el archivo debe existir.</param>
        /// <returns>[true] si la operación se completo, [false] en otro caso.</returns>
        public static bool SaveStringToFile(string archivo, string cadena, bool saltoLinea, bool creaArchivo)
        {
            if (creaArchivo && !File.Exists(archivo))
            {
                CreateFile(archivo);
            }
            return SaveStringToFile(archivo, cadena, saltoLinea);
        }

        /// <summary>
        /// Crea un archivo para escritura en base al nombre pasado (path completo).
        /// ¡Si el archivo ya existe lo sobreescribe!
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <returns>[true] si la operación se completo, [false] en otro caso.</returns>
        public static bool CreateFile(string archivo)
        {

            using (var stream = new FileStream(archivo, FileMode.Create, FileAccess.Write))
            {
                // nothing to do :)
            }
            return true;
        }

        /// <summary>
        /// Abre o crea un archivo y lo vacia (truncate).
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <returns>[true] si la operación se completo, [false] en otro caso.</returns>
        public static bool TruncateFile(string archivo)
        {

            using (var stream = new FileStream(archivo, FileMode.Truncate, FileAccess.Write))
            {
                // nothing to do :)
            }
            return true;
        }

        /// <summary>
        /// Lee un archivo de texto y devuelve su contenido en un ArrayList.
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <param name="encoding"> opcional Codificación de caracteres que utilizará</param>
        /// <returns>Cada línea del archivo en un ArrayList.</returns>
        public static ArrayList GetArrayListFromFile(string archivo, Encoding encoding = null)
        {
            var aList = new ArrayList();
            if (File.Exists(archivo))
            {
                using (var streamReader = encoding == null ? new StreamReader(archivo) : new StreamReader(archivo, encoding))
                {
                    var sLine = string.Empty;
                    while ((sLine = streamReader.ReadLine()) != null)
                    {
                        aList.Add(sLine);
                    }
                }
            }
            return aList;
        }

        #endregion


        #region ARCHIVOS en GENERAL

        /// <summary>
        /// Borra todos los archivos que coincidan con el patrón indicado. Método recursivo.
        /// </summary>
        /// <param name="directoryPath">Directorio a partir del cual se buscan los archivos a borrar. (ej: C:\Temp\)</param>
        /// <param name="pattern">Patron a utilizar para borrar. (ej: *.zip). 
        /// Si es vacío o NULL se borran TODOS los archivos del directorio.</param>
        /// <param name="includeSubdirectories">Si es true, se borraran tambien los archivos en subdirectorios.</param>
        public static void DeleteFilesFromDirectory(string directoryPath, string pattern, bool includeSubdirectories)
        {
            // conjunto de archivos a borrar
            string[] files = string.IsNullOrEmpty(pattern) ?
                Directory.GetFiles(directoryPath) :
                Directory.GetFiles(directoryPath, pattern);

            foreach (string file in files)
            {
                File.Delete(file);
            }

            if (includeSubdirectories)
            {
                string[] directories = Directory.GetDirectories(directoryPath);
                foreach (string dir in directories)
                { // llamada recursiva
                    DeleteFilesFromDirectory(dir, pattern, includeSubdirectories);
                }
            }
        }

        /// <summary>
        /// Renombra archivo
        /// </summary>
        /// <param name="archivoOrigen">Path completo del archivo.</param>
        /// <param name="archivoDestino">Path completo del archivo.</param>
        /// <param name="sobreEscribe">En true sobre escribe en caso de existir archivoDestino</param>
        public static void RenameFile(string archivoOrigen, string archivoDestino, bool sobreEscribe)
        {
            // Si existe el archivo destino y sobreEscribe true elimina el archivoDestino previamente
            if (sobreEscribe && File.Exists(archivoDestino))
            {
                File.Delete(archivoDestino);
            }

            File.Move(archivoOrigen, archivoDestino);
        }

        #endregion


        #region ARCHIVOS TO/FROM DATATABLEs

        /// <summary>
        /// Genera un archivo de texto a partir de DataTable. Utiliza el separador de campos especificado.
        /// </summary>
        /// <param name="archivo">Path completo del archivo.</param>
        /// <param name="dt">DataTable a ser grabado en el archivo.</param>
        /// <param name="separador">Separador a utilizar entre cada campo.</param>
        public static void GeneraArchivoTxT(string archivo, DataTable dt, char separador)
        {

            using (var stream = new FileStream(archivo, FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(stream))
            {
                string cadena = string.Empty;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        cadena += dt.Rows[i][j].ToString().Trim() + separador;
                    }
                    writer.WriteLine(cadena); // graba línea y salto
                    cadena = string.Empty;
                }
            }
        }


        #endregion

    }
}
