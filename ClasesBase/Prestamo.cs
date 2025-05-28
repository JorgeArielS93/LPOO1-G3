using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        private int @PRE_Numero;

        public int pre_Numero
        {
            get { return PRE_Numero; }
            set { PRE_Numero = value; }
        }
        private string CLI_DNI;

        public string cli_DNI
        {
            get { return CLI_DNI; }
            set { CLI_DNI = value; }
        }
        private int DES_Codigo;

        public int des_Codigo
        {
            get { return DES_Codigo; }
            set { DES_Codigo = value; }
        }
        private int PER_Codigo;

        public int per_Codigo
        {
            get { return PER_Codigo; }
            set { PER_Codigo = value; }
        }
        private DateTime PRE_Fecha;

        public DateTime pre_Fecha
        {
            get { return PRE_Fecha; }
            set { PRE_Fecha = value; }
        }
        private decimal PRE_Importe;

        public decimal pre_Importe
        {
            get { return PRE_Importe; }
            set { PRE_Importe = value; }
        }
        private double PRE_TasaInteres;

        public double pre_TasaInteres
        {
            get { return PRE_TasaInteres; }
            set { PRE_TasaInteres = value; }
        }
        private int PRE_CantidadCuotas;

        public int pre_CantidadCuotas
        {
            get { return PRE_CantidadCuotas; }
            set { PRE_CantidadCuotas = value; }
        }
        private string PRE_Estado;

        public string pre_Estado
        {
            get { return PRE_Estado; }
            set { PRE_Estado = value; }
        }
    }
}
