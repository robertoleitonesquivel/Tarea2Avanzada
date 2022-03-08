using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.Repository
{
    public class SedesRepository
    {
        private static SedesModel[] sedesModel = new SedesModel[20];
        private static int Cantidad = 0;

        public SedesRepository(){}

        /// <summary>
        /// Metodo para registrar las sedes
        /// </summary>
        /// <param name="sedes"></param>
        /// <returns></returns>
        public string Insert(SedesModel sedes)
        {
            try
            {
                if (Cantidad < 20)
                {
                    sedesModel[Cantidad] = sedes;
                    Cantidad++;

                    return "Guardado con éxito...!!!";
                }
                else
                {
                    return "No se permite agregar más sedes...!!!";
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para listar las sedes
        /// </summary>
        /// <returns></returns>
        public SedesModel[] GetAll() => sedesModel;
        
    }
}
