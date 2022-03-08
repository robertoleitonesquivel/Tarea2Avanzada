using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Entidades
{
    public class AfiliciacionSedeModel
    {
        public int IdAfiliacion { get; set; }
        public DateTime Fecha { get; set; }
        public ClientesModel clientesModel { get; set; }
        public SedesModel[] sedesModel { get; set; }
    }
}
