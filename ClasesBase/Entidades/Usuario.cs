using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int USU_ID;                 // @ Clave Primaria
        private string USU_NombreUsuario;
        private string USU_Contrasenia;
        private string USU_Nombre;
        private string USU_Apellido;
        private string ROL_Codigo;       // # Clave Foránea a Rol

        public int usu_ID
        {
            get { return USU_ID; }
            set { USU_ID = value; }
        }
        public string usu_NombreUsuario
        {
            get { return USU_NombreUsuario; }
            set { USU_NombreUsuario = value; }
        }
        public string usu_Contrasenia
        {
            get { return USU_Contrasenia; }
            set { USU_Contrasenia = value; }
        }
        public string usu_Nombre
        {
            get { return USU_Nombre; }
            set { USU_Nombre = value; }
        }

        public string usu_Apellido
        {
            get { return USU_Apellido; }
            set { USU_Apellido = value; }
        }

        public string rol_Codigo
        {
            get { return ROL_Codigo; }
            set { ROL_Codigo = value; }
        }

        public Usuario(){}

        public Usuario(int id, string nombreUsuario, string contrasenia, string nombre, string apellido, string rolCodigo)
        {
            USU_ID = id;
            USU_NombreUsuario = nombreUsuario;
            USU_Contrasenia = contrasenia;
            USU_Nombre = nombre;
            USU_Apellido = apellido;
            ROL_Codigo = rolCodigo;
        }


    }
}
