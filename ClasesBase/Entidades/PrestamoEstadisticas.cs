using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Entidades
{
    public class PrestamoEstadisticas
    {
        public int CantidadOtorgados { get; set; }
        public int CantidadPendientes { get; set; }
        public int CantidadCancelados { get; set; }
        public int CantidadAnulados { get; set; }
        public int CantidadTotalPrestamos { get; set; }
    }
}
