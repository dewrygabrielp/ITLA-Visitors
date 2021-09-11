using CapaDatos;
using System.Data;
using System;
using System.Runtime.InteropServices;

namespace CapaNegocio
{
    public class N_Login
    {
        //Metodos que enlazan con capa Datos
        public static DataTable MostrarUsuarios(string usuario, string password)
        {
            D_Login Login = new D_Login();
            Login.Usuario = usuario;
            Login.Password = password;

            return Login.MostrarUsuario(Login);

        }
        public static DataTable verLogin()
        {
            return new D_Login().VerLogin();

        }
        #region CRUD
        public static string Insertar(string nombre, string apellido, DateTime fecha, string usuario, string password, string acceso)
        {
            D_Login Login = new D_Login();
            Login.Nombre = nombre;
            Login.Apellido = apellido;
            Login.Fecha = fecha;
            Login.Usuario = usuario;
            Login.Password = password;
            Login.Acceso = acceso;
            return Login.Insertar(Login);
        }
        public static string Editar(int idusuario, string nombre, string apellido, DateTime fecha, string usuario, string password, string acceso)
        {
            D_Login Login = new D_Login();
            Login.IdUsuario = idusuario;
            Login.Nombre = nombre;
            Login.Apellido = apellido;
            Login.Fecha = fecha;
            Login.Usuario = usuario;
            Login.Password = password;
            Login.Acceso = acceso;
            return Login.Editar(Login);
        }
        public static string Eliminar(int idusuario)
        {
            D_Login Login = new D_Login();
            Login.IdUsuario = idusuario;

            return Login.Eliminar(Login);
        }
        public static DataTable MostrarAcceso()
        {
            return new D_Login().MostrarAcceso();
        }
        #endregion
    }
}
