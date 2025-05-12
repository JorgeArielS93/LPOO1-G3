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
        private string USU_Contraseña;
        private string USU_ApellidoNombre;
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
        public string usu_Contraseña
        {
            get { return USU_Contraseña; }
            set { USU_Contraseña = value; }
        }
        public string usu_ApellidoNombre
        {
            get { return USU_ApellidoNombre; }
            set { USU_ApellidoNombre = value; }
        }

        public string rol_Codigo
        {
            get { return ROL_Codigo; }
            set { ROL_Codigo = value; }
        }

        public Usuario(int id, string nombreUsuario, string contraseña, string apellidoNombre, string rolCodigo)
        {
            USU_ID = id;
            USU_NombreUsuario = nombreUsuario;
            USU_Contraseña = contraseña;
            USU_ApellidoNombre = apellidoNombre;
            ROL_Codigo = rolCodigo;
        }


    }
}
