using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Visitas
    {
        //Metodos
        public static string Insertar(int idedifices, int idclassroom, string name, string lastname, int idcarrera, string reason, string mail,
           DateTime entrytime, DateTime departuretime, byte[] photo)
        {
            D_Visitas visitas = new D_Visitas();

            visitas.IdEdifice = idedifices;
            visitas.IdClassroom = idclassroom;
            visitas.Name = name;
            visitas.LastName = lastname;
            visitas.IdCarrera = idcarrera;
            visitas.Reason = reason;
            visitas.Mail = mail;
            visitas.EntryTime = entrytime;
            visitas.DepartureTime = departuretime;
            visitas.Photo = photo;

            return visitas.Insertar(visitas);
        }
        
        public static string Editar(int idvisitas, int idedifices, int idclassroom, string name, string lastname, int idcarrera, string reason, string mail,
           DateTime entrytime, DateTime departuretime, byte[] photo)
        {
            D_Visitas visitas = new D_Visitas();

            visitas.IdVisites = idvisitas;
            visitas.IdEdifice = idedifices;
            visitas.IdClassroom = idclassroom;
            visitas.Name = name;
            visitas.LastName = lastname;
            visitas.Reason = reason;
            visitas.Mail = mail;
            visitas.EntryTime = entrytime;
            visitas.DepartureTime = departuretime;
            visitas.Photo = photo;

            return visitas.Editar(visitas);
        }
        public static string Eliminar(int idvisites)
        {
            D_Visitas visitas = new D_Visitas();

            visitas.IdVisites = idvisites;
    

            return visitas.Eliminar(visitas);
        }
        public static DataTable MostrarVisitas()
        {
            return new D_Visitas().MostrarVisitas();
        }
        public  DataTable BuscarNombre(string textobuscar)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.Textobuscar = textobuscar;

            return visitas.BuscarNombre(visitas);
        }
        public DataTable BuscarEdificio(int idedificio)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdEdifice = idedificio;
            return visitas.BuscarEdificio(visitas);
        }
        public static DataTable MostrarEdificio()
        {
            return new D_Visitas().MostrarEdificio();
        }
        public static string InsertarEdificio(string edificio)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.Edificio = edificio;
            return visitas.InsertarEdificio(visitas);
        }
        public static string EditarEdificio(int idedificio, string edificio)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdEdifice = idedificio;
            visitas.Edificio = edificio;
            return visitas.EditarEdificio(visitas);
        }
        public static string EliminarEdificio(int idedificio)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdEdifice = idedificio;
            return visitas.EliminarEdificio(visitas);
        }

        public static DataTable MostrarAula()
        {
            return new D_Visitas().MostrarAula();
        }
        public static string InsertarAula(string aula)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.Aula = aula;
            return visitas.InsertarAula(visitas);
        }
        public static string EditarAula(int idaula, string aula)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdClassroom = idaula;
            visitas.Aula = aula;
            return visitas.EditarAula(visitas);
        }
        public static string EliminarAula(int idaula)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdClassroom = idaula;
            return visitas.EliminarAula(visitas);
        }
        public static DataTable MostrarCarreras()
        {
            return new D_Visitas().MostrarCarreras();
        }
        public string InsertarCarreras(string carrera)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.Carrera = carrera;
            return visitas.InsertarCarreras(visitas);
        }
        public static string EditarCarreras(int idcarrera, string carrera)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdCarrera = idcarrera;
            visitas.Carrera = carrera;
            return visitas.EditarCarreras(visitas);
        }
        public static string EliminarCarreras(int idcarrera)
        {
            D_Visitas visitas = new D_Visitas();
            visitas.IdCarrera = idcarrera;
            return visitas.EliminarCarreras(visitas);
        }
    }
}