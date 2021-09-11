using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Login
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _Apellido;
        private DateTime _Fecha;
        private string _Usuario;
        private string _Password;
        private string _Acceso;



        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Fecha { get => _Fecha; set =>_Fecha = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Acceso { get => _Acceso; set => _Acceso = value; }

        //Instancia para realizar conexion

        private Conexion SqlCon = new Conexion();

        //Variable que devuelve resultados




        //Constructor vacio

        public D_Login()
        {
            //Cuerpo vacio
        }
        //Constructor con parametros
        public D_Login(int idUsuario, string nombre, string apellido, DateTime fecha, string usuario, string password, string acceso)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha = fecha;
            this.Usuario = usuario;
            this.Password = password;
            this.Acceso = acceso;
        }

        //Metodos 
        #region MostrarUsuarios
        public DataTable MostrarUsuario(D_Login User)
        {
            DataTable dt = new DataTable("Login");
            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                //Codigo  
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 15;
                ParUsuario.Value = User.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 15;
                ParPassword.Value = User.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {

                SqlCon.Cerrarconexion();
            }
            return dt;
        }
        public DataTable VerLogin()
        {
            DataTable dt = new DataTable("Login");
            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                //Codigo
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                SqlCon.Cerrarconexion();
            }
            return dt;
        }
        public DataTable MostrarAcceso()
        {
            DataTable dt = new DataTable("Access");
            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                //Codigo
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_mostrar_acceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                SqlCon.Cerrarconexion();
            }
            return dt;
        }
        #endregion
        #region CRUD
        public string Insertar(D_Login user)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_insertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@IdUsuario";
                ParID.DbType = DbType.Int32;
                ParID.Direction = ParameterDirection.Output;
                ParID.Value = user.IdUsuario;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 15;
                ParNombre.Value = user.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 15;
                ParApellido.Value = user.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@fechanac";
                ParFechaNac.DbType = DbType.DateTime;
                ParFechaNac.Value = user.Fecha;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 15;
                ParUsuario.Value = user.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 15;
                ParPassword.Value = user.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 15;
                ParAcceso.Value = user.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The user was not inserted into the database";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
            finally
            {
                SqlCon.Cerrarconexion();
            }

            return respuesta;
        }
        public string Editar(D_Login user)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_editar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@IdUsuario";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Direction = ParameterDirection.Input;
                ParID.Value = user.IdUsuario;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 15;
                ParNombre.Value = user.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 15;
                ParApellido.Value = user.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@fechanac";
                ParFechaNac.DbType = DbType.DateTime;
                ParFechaNac.Value = user.Fecha;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 15;
                ParUsuario.Value = user.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 15;
                ParPassword.Value = user.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 15;
                ParAcceso.Value = user.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The record was not edited";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
            finally
            {
                SqlCon.Cerrarconexion();
            }

            return respuesta;
        }
        public string Eliminar(D_Login user)
        {
            string respuesta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon.Abrirconexion();
                SqlCmd.CommandText = "sp_eliminar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@IdUsuario";
                ParID.DbType = DbType.Int32;
                ParID.Value = user.IdUsuario;
                SqlCmd.Parameters.Add(ParID);


                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "The record was not removed from the database";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;

            }

            finally
            {
                SqlCon.Cerrarconexion();
            }
            return respuesta;

        }
        #endregion
    }
}
