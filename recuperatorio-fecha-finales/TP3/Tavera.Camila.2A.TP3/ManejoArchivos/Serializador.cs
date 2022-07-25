using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ManejoArchivos
{

   

    public class Serializador<T>: IArchivos<T> where T:class
    {
        private EtipoArchivoS tipo;
       

        public Serializador(EtipoArchivoS tipo)
        {
            Tipo = tipo;
        }

        EtipoArchivoS Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        /// <summary>
        /// Serializa los datos en el archivo.xml o .json en la ruta que se paso por parametro
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        /// <param name="append"></param>
        public void Escribir(string path, T dato, bool append)
        {
            try
            {
                if (this.Tipo == EtipoArchivoS.JSON && Path.GetExtension(path) == ".json")
                {
                    JsonSerializerOptions jso = new JsonSerializerOptions();
                    jso.WriteIndented = true;
                    string datoJson = JsonSerializer.Serialize(dato, typeof(T), jso);

                    ArchivoTxt at = new ArchivoTxt();
                    at.Escribir(path, datoJson, append);
                }
                else if (this.Tipo== EtipoArchivoS.XML && Path.GetExtension(path) == ".xml")
                {
                    using (XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
                    {
                        writer.Formatting = Formatting.Indented;
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        ser.Serialize(writer, dato);
                    }
                }
                else
                {
                    throw new ExceptionExtension($"AError de extension del archivo (.{Tipo})");

                }

            }            
            catch (ExceptionExtension)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception($"Algo salio mal {e.Message}");

            }
        }


        /// <summary>
        /// Deserializa los objetos en un archivo.xml o .json ubicado en la ruta que se paso por parametro
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public T Leer(string path)
        {
            if (!File.Exists(path))
            {
                throw new ExceptionNoExisteRuta("La ruta del archivo no existe");
            }

            try
            {
                if (this.Tipo == EtipoArchivoS.JSON && Path.GetExtension(path) == ".json")
                {
                    
                    ArchivoTxt archivoTxt = new ArchivoTxt();
                    string ret=archivoTxt.Leer(path);
                    return JsonSerializer.Deserialize<T>(ret); 


                }
                else if (this.Tipo == EtipoArchivoS.XML && Path.GetExtension(path) == ".xml")
                {
                    
                    using (XmlTextReader reader = new XmlTextReader(path))
                    {
                        T ret = null;
                        try 
                        {
                            XmlSerializer ser = new XmlSerializer(typeof(T));
                            ret = ser.Deserialize(reader) as T;
                           
                        }
                        catch(Exception ex)
                        {
                            Console.Write(ex.Message);
                        }
                        return ret;




                    }

                }
                else
                {
                    throw new ExceptionExtension($"Error de extension del archivo (.{Tipo})");

                }


            }
            catch (ExceptionExtension)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception($"Algo salio mal {e.Message}");

            }


        }


        
    }
}
