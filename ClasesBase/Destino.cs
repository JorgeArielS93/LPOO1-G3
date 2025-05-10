using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Destino
    {
        private int DES_Codigo;             // @ Clave Primaria
        private string DES_Descripcion;

        public int des_Codigo
        {
            get { return DES_Codigo; }
            set { DES_Codigo = value; }
        }
        public string des_Descripcion
        {
            get { return DES_Descripcion; }
            set { DES_Descripcion = value; }
        }
    }
}
