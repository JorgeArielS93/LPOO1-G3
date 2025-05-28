using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Periodo
    {
        private int PER_Codigo;             // @ Clave Primaria
        private string PER_Descripcion;

        public int per_Codigo
        {
            get { return PER_Codigo; }
            set { PER_Codigo = value; }
        }
        public string per_Descripcion
        {
            get { return PER_Descripcion; }
            set { PER_Descripcion = value; }
        }
    }
}
