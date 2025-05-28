using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string CLI_DNI; //llave primaria
        public string cli_DNI
        {
            get { return CLI_DNI; }
            set { CLI_DNI = value; }
        }
        private string CLI_Nombre;

        public string cli_Nombre
        {
            get { return CLI_Nombre; }
            set { CLI_Nombre = value; }
        }
        private string CLI_Apellido;

        public string cli_Apellido
        {
            get { return CLI_Apellido; }
            set { CLI_Apellido = value; }
        }
        private string CLI_Sexo;

        public string cli_Sexo
        {
            get { return CLI_Sexo; }
            set { CLI_Sexo = value; }
        }
        private DateTime CLI_FechaNacimiento;

        public DateTime cli_FechaNacimiento
        {
            get { return CLI_FechaNacimiento; }
            set { CLI_FechaNacimiento = value; }
        }
        private decimal CLI_Ingresos;

        public decimal cli_Ingresos
        {
            get { return CLI_Ingresos; }
            set { CLI_Ingresos = value; }
        }
        private string CLI_Direccion;

        public string cli_Direccion
        {
            get { return CLI_Direccion; }
            set { CLI_Direccion = value; }
        }
        private string CLI_Telefono;

        public string cli_Telefono
        {
            get { return CLI_Telefono; }
            set { CLI_Telefono = value; }
        }

    }
}
