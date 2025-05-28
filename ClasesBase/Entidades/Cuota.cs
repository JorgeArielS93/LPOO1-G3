using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cuota
    {
        private int CUO_Codigo;

        public int cuo_Codigo
        {
            get { return CUO_Codigo; }
            set { CUO_Codigo = value; }
        }
        private int PRE_Numero;

        public int pre_Numero
        {
            get { return PRE_Numero; }
            set { PRE_Numero = value; }
        }
        private int CUO_Numero;

        public int cuo_Numero
        {
            get { return CUO_Numero; }
            set { CUO_Numero = value; }
        }
        private DateTime CUO_Vencimiento;

        public DateTime cuo_Vencimiento
        {
            get { return CUO_Vencimiento; }
            set { CUO_Vencimiento = value; }
        }
        private decimal CUO_Importe;

        public decimal cuo_Importe
        {
            get { return CUO_Importe; }
            set { CUO_Importe = value; }
        }
        private string CUO_Estado;

        public string cuo_Estado
        {
            get { return CUO_Estado; }
            set { CUO_Estado = value; }
        }
    }
}
