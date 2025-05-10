using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private string ROL_Codigo;          // @ Clave Primaria
        private string ROL_Descripcion;

        public string rol_Codigo
        {
            get { return ROL_Codigo; }
            set { ROL_Codigo = value; }
        }
        public string rol_Descripcion
        {
            get { return ROL_Descripcion; }
            set { ROL_Descripcion = value; }
        }
    }
}
