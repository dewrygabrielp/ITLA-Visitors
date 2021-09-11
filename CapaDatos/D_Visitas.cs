using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class D_Visitas
    {
        private string _Textobuscar;
        private int _IdVisites;
        private int _IdEdifice;
        private int _IdClassroom;
        private string _Edificio;
        private string _Aula;

        private string _Name;
        private string _LastName;
        private int _IdCarrera;
        private string _Carrera;
        private string _Reason;
        private string _Mail;
        private DateTime _EntryTime;
        private DateTime _DepartureTime;
        private byte[] _Photo;

        public int IdVisites { get => _IdVisites; set => _IdVisites = value; }
        public int IdEdifice { get => _IdEdifice; set => _IdEdifice = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Reason { get => _Reason; set => _Reason = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public DateTime EntryTime { get => _EntryTime; set => _EntryTime = value; }
        public DateTime DepartureTime { get => _DepartureTime; set => _DepartureTime = value; }
        public byte[] Photo { get => _Photo; set => _Photo = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }
        public int IdClassroom { get => _IdClassroom; set => _IdClassroom = value; }
        public string Edificio { get => _Edificio; set => _Edificio = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
        public int IdCarrera { get => _IdCarrera; set => _IdCarrera = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }

        //Constructor vacio
        public D_Visitas()
         {
            // vacio
         }
        //instancia conexion
        Conexion SqlCon = new Conexion();

        //  Constructor con parametros

        public D_Visitas(string textobuscar, int idvisites, int idedifices, int idclassroom,string edificio, string aula, string name, string lastname, int idcarrera, string carrera,string career, string reason, string mail,
            DateTime entrytime, DateTime departuretime, byte[] photo)
        {
            this.Textobuscar = textobuscar;
            this.IdVisites = idvisites;
            this.IdEdifice = idedifices;
            this.IdClassroom = idclassroom;
            this.Edificio = edificio;
            this.Aula = aula;
            this.Name = name;
            this.LastName = lastname;
            this.IdCarrera = idcarrera;
            this.Carrera = carrera;
            this.Reason = reason;
            this.Mail = mail;
            this.EntryTime = entrytime;
            this.DepartureTime = departuretime;
            this.Photo = photo;
        }
        //metodos
        public DataTable BuscarNombre(D_Visitas User)
        {
            DataTable dt = new DataTable("Visitas");
            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                //Codigo  
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_buscar_visitas_edificio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@textobuscar";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = User.Textobuscar;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

            }
            catch (Exception) { dt = null; }
            finally { SqlCon.Cerrarconexion(); }
            return dt;
        }
        public DataTable BuscarEdificio(D_Visitas visitas)
        {
            DataTable dt = new DataTable("Visitas");
            SqlCommand SqlCmd = new SqlCommand();
            try
            {
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_buscar_visitas_edificio2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idedificio";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);
            }
            catch(Exception) { dt = null; }
            finally { SqlCon.Cerrarconexion(); }
            return dt;
            
        }
        public DataTable MostrarEdificio()
        {
            DataTable dt = new DataTable("Edificio");
            SqlCommand SqlCmd = new SqlCommand();
            try
            {
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_edificio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);
            }
            catch (Exception) { dt = null; }
            finally { SqlCon.Cerrarconexion(); }
            return dt;

        }
        public string InsertarEdificio(D_Visitas visitas)
        {
            string respuesta = "";
           try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_insertar_edificio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idedificio";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Output;
                ParIdEdificio.Value = visitas.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@edificio";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 10;
                ParEdificio.Value = visitas.Edificio;
                SqlCmd.Parameters.Add(ParEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK": "The building was not added";
            }
            catch(Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string EditarEdificio(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_editar_edificio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idedificio";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@edificio";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 10;
                ParEdificio.Value = visitas.Edificio;
                SqlCmd.Parameters.Add(ParEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The building was not edited";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string EliminarEdificio(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_eliminar_edificio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idedificio";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The building was not removed";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public DataTable MostrarAula()
        {
            DataTable dt = new DataTable("Aula");
            SqlCommand SqlCmd = new SqlCommand();
            try
            {
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);
            }
            catch (Exception) { dt = null; }
            finally { SqlCon.Cerrarconexion(); }
            return dt;

        }
        public string InsertarAula(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_insertar_aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idaula";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Output;
                ParIdEdificio.Value = visitas.IdClassroom;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@aula";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 50;
                ParEdificio.Value = visitas.Aula;
                SqlCmd.Parameters.Add(ParEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The classroom was not added";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string EditarAula(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_editar_aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idaula";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@aula";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 50;
                ParEdificio.Value = visitas.Aula;
                SqlCmd.Parameters.Add(ParEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The classroom was not edited";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string EliminarAula(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_eliminar_aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idaula";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdClassroom;
                SqlCmd.Parameters.Add(ParIdEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The classroom was not removed";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public DataTable MostrarVisitas()
        {
            DataTable dt = new DataTable("Visitas");
            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                //Codigo  
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_visitas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

            }
            catch (Exception) { dt = null; }
            finally { SqlCon.Cerrarconexion(); }
            return dt;
        }
        public string Insertar(D_Visitas user)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_insertar_visitas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@idvisitas";
                ParID.DbType = DbType.Int32;
                ParID.Direction = ParameterDirection.Output;
                ParID.Value = user.IdVisites;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParIdEdifice = new SqlParameter();
                ParIdEdifice.ParameterName = "@idedificio";
                ParIdEdifice.DbType = DbType.Int32;
                ParIdEdifice.Direction = ParameterDirection.Input;
                ParIdEdifice.Value = user.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdifice);

                SqlParameter ParIdAula = new SqlParameter();
                ParIdAula.ParameterName = "@idaula";
                ParIdAula.DbType = DbType.Int32;
                ParIdAula.Direction = ParameterDirection.Input;
                ParIdAula.Value = user.IdClassroom;
                SqlCmd.Parameters.Add(ParIdAula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@name";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = user.Name;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@lastname";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = user.LastName;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParReason = new SqlParameter();
                ParReason.ParameterName = "@reason";
                ParReason.SqlDbType = SqlDbType.VarChar;
                ParReason.Size = 30;
                ParReason.Value = user.Reason;
                SqlCmd.Parameters.Add(ParReason);

                SqlParameter ParIdCarrera = new SqlParameter();
                ParIdCarrera.ParameterName = "@idcarrera";
                ParIdCarrera.DbType = DbType.Int32;
                ParIdCarrera.Direction = ParameterDirection.Input;
                ParIdCarrera.Value = user.IdCarrera;
                SqlCmd.Parameters.Add(ParIdCarrera);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 30;
                ParMail.Value = user.Mail;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@entrytime";
                ParFechaNac.DbType = DbType.Time;
                ParFechaNac.Value = user.EntryTime;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParHoraSalida = new SqlParameter();
                ParHoraSalida.ParameterName = "@departuretime";
                ParHoraSalida.DbType = DbType.Time;
                ParHoraSalida.Value = user.DepartureTime;
                SqlCmd.Parameters.Add(ParHoraSalida);

                SqlParameter ParPhoto = new SqlParameter();
                ParPhoto.ParameterName = "@photo";
                ParPhoto.SqlDbType = SqlDbType.Image;

                ParPhoto.Value = user.Photo;
                SqlCmd.Parameters.Add(ParPhoto);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "the visitor was not added";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string Editar(D_Visitas user)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_editar_visitas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@idvisitas";
                ParID.DbType = DbType.Int32;
                ParID.Direction = ParameterDirection.Input;
                ParID.Value = user.IdVisites;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParIdEdifice = new SqlParameter();
                ParIdEdifice.ParameterName = "@idedificio";
                ParIdEdifice.DbType = DbType.Int32;
                ParIdEdifice.Direction = ParameterDirection.Input;
                ParIdEdifice.Value = user.IdEdifice;
                SqlCmd.Parameters.Add(ParIdEdifice);

                SqlParameter ParIdAula = new SqlParameter();
                ParIdAula.ParameterName = "@idaula";
                ParIdAula.DbType = DbType.Int32;
                ParIdAula.Direction = ParameterDirection.Input;
                ParIdAula.Value = user.IdClassroom;
                SqlCmd.Parameters.Add(ParIdAula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@name";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = user.Name;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@lastname";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = user.LastName;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParReason = new SqlParameter();
                ParReason.ParameterName = "@reason";
                ParReason.SqlDbType = SqlDbType.VarChar;
                ParReason.Size = 30;
                ParReason.Value = user.Reason;
                SqlCmd.Parameters.Add(ParReason);

                SqlParameter ParCareer = new SqlParameter();
                ParCareer.ParameterName = "@idcarrera";
                ParCareer.SqlDbType = SqlDbType.VarChar;
                ParCareer.Value = user.IdCarrera;
                SqlCmd.Parameters.Add(ParCareer);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 30;
                ParMail.Value = user.Mail;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@entrytime";
                ParFechaNac.DbType = DbType.Time;
                ParFechaNac.Value = user.EntryTime;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParHoraSalida = new SqlParameter();
                ParHoraSalida.ParameterName = "@departuretime";
                ParHoraSalida.DbType = DbType.Time;
                ParHoraSalida.Value = user.DepartureTime;
                SqlCmd.Parameters.Add(ParHoraSalida);

                SqlParameter ParPhoto = new SqlParameter();
                ParPhoto.ParameterName = "@photo";
                ParPhoto.SqlDbType = SqlDbType.Image;

                ParPhoto.Value = user.Photo;
                SqlCmd.Parameters.Add(ParPhoto);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "the visitor was not edited";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string Eliminar(D_Visitas user)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_eliminar_visitas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@idvisitas";
                ParID.DbType = DbType.Int32;
                ParID.Direction = ParameterDirection.Input;
                ParID.Value = user.IdVisites;
                SqlCmd.Parameters.Add(ParID);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "the visitor was not eliminated";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public DataTable MostrarCarreras()
        {
            DataTable dt = new DataTable("Carreras");
            SqlCommand SqlCmd = new SqlCommand();
            try
            {
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_carrera";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);
            }
            catch (Exception) { dt = null; }
            finally { SqlCon.Cerrarconexion(); }
            return dt;

        }
        public string InsertarCarreras(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_insertar_carrera";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idcarrera";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Output;
                ParIdEdificio.Value = visitas.IdCarrera;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@carrera";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 10;
                ParEdificio.Value = visitas.Carrera;
                SqlCmd.Parameters.Add(ParEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The career was not added";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string EditarCarreras(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_editar_carrera";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idcarrera";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdCarrera;
                SqlCmd.Parameters.Add(ParIdEdificio);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@carrera";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 10;
                ParEdificio.Value = visitas.Carrera;
                SqlCmd.Parameters.Add(ParEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The career was not edited";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
        public string EliminarCarreras(D_Visitas visitas)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_eliminar_carrera";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEdificio = new SqlParameter();
                ParIdEdificio.ParameterName = "@idcarrera";
                ParIdEdificio.SqlDbType = SqlDbType.Int;
                ParIdEdificio.Direction = ParameterDirection.Input;
                ParIdEdificio.Value = visitas.IdCarrera;
                SqlCmd.Parameters.Add(ParIdEdificio);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The career was not removed";
            }
            catch (Exception ex) { respuesta = ex.Message + ex.StackTrace; }
            finally { SqlCon.Cerrarconexion(); }
            return respuesta;
        }
       
    }
}
