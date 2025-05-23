using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pago
    {
        private int PAG_Codigo;             // @ Clave Primaria
        private DateTime PAG_Fecha;
        private decimal PAG_Importe;
        // Clave Foránea
        private int CUO_Codigo_FK;          // # Clave Foránea a Cuota

        public int pag_Codigo
        {
            get { return PAG_Codigo; }
            set { PAG_Codigo = value; }
        }
        public DateTime pag_Fecha
        {
            get { return PAG_Fecha; }
            set { PAG_Fecha = value; }
        }
        public decimal pag_Importe
        {
            get { return PAG_Importe; }
            set { PAG_Importe = value; }
        }

        public int cuo_Codigo
        {
            get { return CUO_Codigo_FK; }
            set { CUO_Codigo_FK = value; }
        }
    }
}
