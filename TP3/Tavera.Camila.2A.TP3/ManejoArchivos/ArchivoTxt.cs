using System;
using System.IO;

namespace ManejoArchivos
{
    public class ArchivoTxt: IArchivos<string>
    {

        /// <summary>
        /// Escribe el archivo txt en la ruta pasada por parametro
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        /// <param name="append"></param>
        public void Escribir(string path, string dato, bool append)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, append))
                {
                    sw.WriteLine(dato);
                } 
            }
            catch
            {
                throw; 
            }
        }


        /// <summary>
        /// Lee el archivo txt en la ruta pasada por parametro
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string Leer(string path)
        {
            if (!File.Exists(path))
            {
                throw new ExceptionNoExisteRuta("La ruta del archivo no existe");
            }

            string ret = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    ret = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ret;
        }

    }
}
