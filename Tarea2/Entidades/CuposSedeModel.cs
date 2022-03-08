using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Entidades
{
    public class CuposSedeModel
    {
       public SedesModel sedesModel { get; set; }
        public DateTime Fecha { get; set; }
        public int Cupos { get; set; }
    }
}
