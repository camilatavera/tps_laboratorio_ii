using Bibloteca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
//using ManejoArchivos;

namespace ManejoDB
{
    
    public static class DB
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static DB()
        {
            connectionString= @"Data Source=.\SQLEXPRESS;Initial Catalog=TP4_TAVERA_2A; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
        }


        
        static Esexo traerSexo(string pk)
        {
            if (pk == "f")
            {
                return Esexo.f;
            }
            else
                return Esexo.m;
        }

        public static List<Socio> TraerSocios()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM socios";
                SqlDataReader dataReader = command.ExecuteReader();
                Club.Socios.Clear();
                while (dataReader.Read())
                {
                    Club.Socios.Add(new Socio(int.Parse(dataReader["ID_SOCIO"].ToString()),dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), (DateTime)dataReader["NACIMIENTO"], ((ECategoria)((int)dataReader["categoria"])),
                        (int)dataReader["DEUDA"]));

                }
                return Club.Socios;

            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        public static List<EmpleadoOperativo> TraerOperativos()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM empleadosOperativos";
                SqlDataReader dataReader = command.ExecuteReader();
                Club.Operativos.Clear();
                while (dataReader.Read())
                {
                    Club.Operativos.Add(new EmpleadoOperativo(int.Parse(dataReader["ID_OPERATIVO"].ToString()), dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), (DateTime)dataReader["NACIMIENTO"], (EArea)(int)dataReader["AREA"]));

                }
                return Club.Operativos;

            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }




        public static List<Federado> TraerFederados()
        {
            List<Federado> listFederados = new List<Federado>();
            SqlDataReader dataReader;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM federados";
                dataReader = command.ExecuteReader();
                

                while (dataReader.Read())
                {


                    int id=int.Parse(dataReader["ID_FEDERADO"].ToString());
                    int deuda = int.Parse(dataReader["DEUDA"].ToString());
                    
                    DateTime fecha = DateTime.Parse(dataReader["NACIMIENTO"].ToString());

                    listFederados.Add(new Federado(id, dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), fecha, (ECategoria)((int)dataReader["categoria"]),
                         deuda));
                        
                }
               

                
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                Club.Federados.Clear();
                foreach(Federado aux in listFederados)
                {
                    Club.Federados.Add(TraerDeportesPorFederado(aux));
                }
            }
            catch (ExceptionDB)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
                
            }

            return Club.Federados;


        }


        public static List<EmpleadoDeportivo> TraerEmpleadosDeportivos()
        {
            List<EmpleadoDeportivo> listDeportivos = new List<EmpleadoDeportivo>();
            SqlDataReader dataReader;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM empleadosDeportivos";
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {


                    int id = int.Parse(dataReader["ID_DEPORTIVO"].ToString());
                    DateTime fecha = DateTime.Parse(dataReader["NACIMIENTO"].ToString());

                    listDeportivos.Add(new EmpleadoDeportivo(id, dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                        traerSexo(dataReader["SEXO"].ToString()), fecha));

                }



            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                Club.Deportivos.Clear();
                foreach (EmpleadoDeportivo aux in listDeportivos)
                {
                    Club.Deportivos.Add(TraerEquiposPorDeportivo(aux));
                }
            }
            catch (ExceptionDB)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();

            }

            return Club.Deportivos;


        }


        public static List<Equipo> TraerEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            SqlDataReader dataReader;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.CommandText = "SELECT * FROM equipos";
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID_EQUIPO"].ToString());

                    equipos.Add(new Equipo(id, (EDeporte)(int)dataReader["DEPORTE"], (ECategoria)(int)dataReader["CATEGORIA"],
                        traerSexo(dataReader["SEXO"].ToString())));
                }

                Club.Equipos.AddRange(equipos);

            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Club.Equipos;

        }


        public static EmpleadoDeportivo TraerEquiposPorDeportivo(EmpleadoDeportivo deportivo)
        {
            Equipo aux;


            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();



                command.CommandText = "SELECT * FROM deportivos_equipos WHERE ID_DEPORTIVO = @id";



                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", deportivo.Id);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int idEquipo = (int)dataReader["ID_EQUIPO"];
                    deportivo.AgregarEquipo((Equipo)idEquipo);
                }


                return deportivo;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }




        public static Federado TraerDeportesPorFederado(Federado federado)
        {
            List<EDeporte> deportesAux = new List<EDeporte>();


            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                

               
                command.CommandText = "SELECT ID_DEPORTE FROM federados_deportes WHERE ID_FEDERADO = @id";

                  

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", federado.Id);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    federado.AgregarDeporte((EDeporte)(int)dataReader["ID_DEPORTE"]);
                }


                return federado;             




            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }


        public static bool AgregarOperativo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {
            try
            {
                if (Club.ValidarExistenciaOperativo(nombre, apellido))
                {
                    CrearOperativoDB(nombre, apellido, sexo, fechaNacimiento, area);
                    return true;
                }
                return false;
            }
            catch (PersonaRepetidaException)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
        }



        public static bool AgregarSocio(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int deuda)
        {
            try
            {
                if(Club.ValidarExistenciaSocio(nombre, apellido))
                {
                    CrearSocioDB(nombre, apellido, sexo, fechaNacimiento, categoria, deuda);
                    return true;
                }
                return false;
            }
            catch (PersonaRepetidaException)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
        }


        private static bool CrearSocioDB(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int deuda)
        {
           
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"INSERT INTO socios(NOMBRE, APELLIDO, SEXO, NACIMIENTO, CATEGORIA, DEUDA) VALUES (@nombre, @apellido, @sexo, @nacimiento, @categoria, @deuda);";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@sexo", sexo.fkSexo());
                command.Parameters.AddWithValue("@nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@deuda", deuda);

                command.ExecuteNonQuery();

                return true;

            }
            catch (PersonaRepetidaException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }



        }


        private static bool CrearOperativoDB(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();


                command.CommandText = $"INSERT INTO empleadosOperativos(NOMBRE, APELLIDO, SEXO, NACIMIENTO, AREA) VALUES (@nombre, @apellido, @sexo, @nacimiento, @area);";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@sexo", sexo.fkSexo());
                command.Parameters.AddWithValue("@nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@area", area);

                command.ExecuteNonQuery();

                return true;

            }
            catch (PersonaRepetidaException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }



        }




        public static bool AgregarFederado(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int deuda, List<EDeporte> deportes)
        {
            try
            {
                if (Club.ValidarExistenciaFederado(nombre, apellido))
                {
                    DB.CrearFederadoDB(nombre, apellido, sexo, fechaNacimiento, categoria, deuda, deportes);
                    return true;
                }
                return false;
            }
            catch (PersonaRepetidaException)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
        }


        public static bool AgregarDeportivo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos)
        {
            try
            {
                if (Club.ValidarExistenciaDeportivo(nombre, apellido))
                {
                    DB.CrearDeportivoDB(nombre, apellido, sexo, fechaNacimiento, equipos);
                    return true;
                }
                return false;
            }
            catch (PersonaRepetidaException)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
        }


        private static bool CrearDeportivoDB(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = $"INSERT INTO empleadosDeportivos(NOMBRE, APELLIDO, SEXO, NACIMIENTO) " +
                    "VALUES (@nombre, @apellido, @sexo, @nacimiento)";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@sexo", sexo.fkSexo());
                command.Parameters.AddWithValue("@nacimiento", fechaNacimiento);


                command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            EmpleadoDeportivo aux = DB.BuscarDeportivo(nombre, apellido);
            aux.AgregarEquipos(equipos);
            DB.AgregarEquiposDB(aux);
            return true;
        }



        //error si tiene problema en la base de datos
        private static bool CrearFederadoDB(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int deuda, List<EDeporte> deportes)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = $"INSERT INTO federados(NOMBRE, APELLIDO, SEXO, NACIMIENTO, CATEGORIA, DEUDA) " +
                    "VALUES (@nombre, @apellido, @sexo, @nacimiento, @categoria, @deuda)";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@sexo", sexo.fkSexo());
                command.Parameters.AddWithValue("@nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@deuda", deuda);

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            Federado aux = DB.BuscarFederado(nombre, apellido);
            aux.AgregarDeportes(deportes);
            DB.AgregarDeportesDB(aux);
            return true;
        }




        public static Federado BuscarFederado(string nombre, string apellido)
        {
            Federado federado;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = "SELECT * FROM federados WHERE NOMBRE=@nombre AND APELLIDO=@apellido";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID_FEDERADO"].ToString());
                    int deuda = int.Parse(dataReader["DEUDA"].ToString());

                    DateTime fecha = DateTime.Parse(dataReader["NACIMIENTO"].ToString());

                    federado = new Federado(id, dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                            traerSexo(dataReader["SEXO"].ToString()), fecha, (ECategoria)((int)dataReader["categoria"]),
                             deuda);

                    return federado;
                }

                return null;

                
            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static EmpleadoDeportivo BuscarDeportivo(string nombre, string apellido)
        {
            EmpleadoDeportivo deportivo;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = "SELECT * FROM empleadosDeportivos WHERE NOMBRE=@nombre AND APELLIDO=@apellido";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID_DEPORTIVO"].ToString());

                    DateTime fecha = DateTime.Parse(dataReader["NACIMIENTO"].ToString());

                    deportivo = new EmpleadoDeportivo(id, dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(),
                            traerSexo(dataReader["SEXO"].ToString()), fecha);

                    return deportivo;
                }

                return null;


            }
            catch (Exception ex)
            {

                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }




        public static bool AgregarEquiposDB(EmpleadoDeportivo deportivo)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                foreach (Equipo equipo in deportivo.Equipos)
                {
                    command.CommandText = $"INSERT INTO deportivos_equipos(ID_DEPORTIVO, ID_EQUIPO) " +
                    "VALUES (@id_deportivo, @id_equipo)";

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id_deportivo", deportivo.Id);
                    command.Parameters.AddWithValue("@id_equipo", (int)equipo);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }










            public static bool AgregarDeportesDB(Federado federado)
            {         
                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    foreach(EDeporte deporte in federado.Deportes)
                    {
                        command.CommandText = $"INSERT INTO federados_deportes(ID_FEDERADO, ID_DEPORTE) " +
                        "VALUES (@id_federado, @id_deporte)";

                         command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id_federado", federado.Id);
                        command.Parameters.AddWithValue("@id_deporte", (int)deporte);

                            command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ExceptionDB(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


        public static bool AgregarDeporte(int federado, int deporte)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = $"INSERT INTO federados_deportes(ID_FEDERADO, ID_DEPORTE) " +
                   "VALUES (@id_federado, @id_deporte)";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_federado", federado);
                command.Parameters.AddWithValue("@id_deporte", (int)deporte);

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool UpdateFederado(Federado aux, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes)
        {
            bool ret = false;
           
            try
            {
                //aux = DB.BuscarFederado(nombre, apellido);
                if (aux is not null)
                {
                    if (aux.Nombre != nombre)
                    {
                        QueryActualizacion("federados", "NOMBRE", nombre, "ID_FEDERADO", aux.Id);
                        ret = true;
                    }
                    if (aux.Apellido != apellido)
                    {
                        QueryActualizacion("federados", "APELLIDO", apellido, "ID_FEDERADO", aux.Id);
                        ret = true;
                    }
                    if (aux.Sexo != sexo)
                    {
                        QueryActualizacion("federados", "SEXO", sexo.fkSexo(), "ID_FEDERADO", aux.Id);
                        ret = true;
                    }
                    
                    if (aux.Categoria != categoria)
                    {
                        QueryActualizacion("federados", "CATEGORIA", ((int)categoria).ToString(), "ID_FEDERADO", aux.Id);
                        ret = true;
                    }

                    ret= DB.ActualizarDeportes(aux, deportes);
                    return ret;
                }
                
            }
            catch (NoHayDeportesException)
            {
                throw;
            }


            return false;
        }


        public static bool UpdateDeportivo(EmpleadoDeportivo aux, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos)
        {
            bool ret = false;
            bool retEquipos;

            try
            {
                //aux = DB.BuscarFederado(nombre, apellido);
                if (aux is not null)
                {
                    if (aux.Nombre != nombre)
                    {
                        QueryActualizacion("empleadosDeportivos", "NOMBRE", nombre, "ID_DEPORTIVO", aux.Id);
                        ret = true;
                    }
                    if (aux.Apellido != apellido)
                    {
                        QueryActualizacion("empleadosDeportivos", "APELLIDO", apellido, "ID_DEPORTIVO", aux.Id);
                        ret = true;
                    }
                    if (aux.Sexo != sexo)
                    {
                        QueryActualizacion("empleadosDeportivos", "SEXO", sexo.fkSexo(), "ID_DEPORTIVO", aux.Id);
                        ret = true;
                    }

                    

                     retEquipos= DB.ActualizarEquipos(aux, equipos);
                    return ret || retEquipos;
                }

            }
            catch (NoHayDeportesException)
            {
                throw;
            }


            return false;
        }


        public static bool UpdateSocio(Socio aux, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        {
            bool ret = false;

            try
            {
                if (aux is not null)
                {
                    if (aux.Nombre != nombre)
                    {
                        QueryActualizacion("socios", "NOMBRE", nombre, "ID_SOCIO", aux.Id);
                        ret = true;
                    }
                    if (aux.Apellido != apellido)
                    {
                        QueryActualizacion("socios", "APELLIDO", apellido, "ID_SOCIO", aux.Id);
                        ret = true;
                    }
                    if (aux.Sexo != sexo)
                    {
                        QueryActualizacion("socios", "SEXO", sexo.fkSexo(), "ID_SOCIO", aux.Id);
                        ret = true;
                    }

                    if (aux.Categoria != categoria)
                    {
                        QueryActualizacion("socios", "CATEGORIA", ((int)categoria).ToString(), "ID_SOCIO", aux.Id);
                        ret = true;
                    }

                    
                }

                return ret;

            }
            catch (NoHayDeportesException)
            {
                throw;
            }

        }


        public static bool UpdateOperativo(EmpleadoOperativo aux, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {
            bool ret = false;

            try
            {
                if (aux is not null)
                {
                    if (aux.Nombre != nombre)
                    {
                        QueryActualizacion("empleadosOperativos", "NOMBRE", nombre, "ID_OPERATIVO", aux.Id);
                        ret = true;
                    }
                    if (aux.Apellido != apellido)
                    {
                        QueryActualizacion("empleadosOperativos", "APELLIDO", apellido, "ID_OPERATIVO", aux.Id);
                        ret = true;
                    }
                    if (aux.Sexo != sexo)
                    {
                        QueryActualizacion("empleadosOperativos", "SEXO", sexo.fkSexo(), "ID_OPERATIVO", aux.Id);
                        ret = true;
                    }

                    if (aux.Area != area)
                    {
                        QueryActualizacion("empleadosOperativos", "AREA", ((int)area).ToString(), "ID_OPERATIVO", aux.Id);
                        ret = true;
                    }
                    


                }

                return ret;

            }
            catch (Exception )
            {
                throw;
            }

        }


        public static void LimpiarTablaDeportes(Federado federado)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = $"DELETE FROM federados_deportes WHERE ID_FEDERADO=@id";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", federado.Id);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public static void LimpiarTablaEquipos(EmpleadoDeportivo deportivo)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = $"DELETE FROM deportivos_equipos WHERE ID_DEPORTIVO=@id";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", deportivo.Id);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public static bool ActualizarDeportes(Federado federado, List<EDeporte> deportes)
        {
            try
            {
                if (federado.ValidarDeportes(deportes))
                {
                    LimpiarTablaDeportes(federado);
                    AgregarDeportesDB(federado);
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
            
        }




        public static bool ActualizarEquipos(EmpleadoDeportivo deportivo, List<Equipo> equipos)
        {
            try
            {
                if (deportivo.validarEquipos(equipos))
                {
                    LimpiarTablaEquipos(deportivo);
                    AgregarEquiposDB(deportivo);
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool UpdateDeudaSocio(Socio socio)
        {
            try
            {
                QueryActualizacion("socios", "DEUDA", socio.APagar.ToString(), "ID_SOCIO", socio.Id);
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool UpdateDeudaFederado(Federado federado)
        {
            try
            {
                QueryActualizacion("federados", "DEUDA", federado.APagar.ToString(), "ID_FEDERADO", federado.Id);
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static void QueryActualizacion(string tabla, string campo, string valorCampo, string id, int valor_id)
        {
            string query = $"UPDATE {tabla} SET {campo}=@VALOR_CAMPO WHERE {id}=@VALOR_ID";
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@VALOR_CAMPO", valorCampo);
                command.Parameters.AddWithValue("@VALOR_ID", valor_id);

                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void QueryBorrar(string tabla, string id, int idValor)
        {
            string query = $"DELETE FROM {tabla} WHERE {id}=@VALOR_ID";
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@VALOR_ID", idValor);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new ExceptionDB(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool BorrarFederado(Federado federado)
        {
            try
            {
                DB.LimpiarTablaDeportes(federado);
                DB.QueryBorrar("federados", "ID_FEDERADO", federado.Id);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static bool BorrarSocio(Socio socio)
        {
            try
            {
                DB.QueryBorrar("socios", "ID_SOCIO", socio.Id);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


       











    }
}
