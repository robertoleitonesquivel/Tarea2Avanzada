using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.Repository
{
    public class CuposSedesRepository
    {
        private static CuposSedeModel[] cuposSedeModels = new CuposSedeModel[20];
        private static int Cantidad = 0;

        /// <summary>
        /// Metodo para registrar cupos por sede
        /// </summary>
        /// <param name="cuposSedeModel"></param>
        /// <returns></returns>
        public string Insert(CuposSedeModel cuposSedeModel)
        {
            try
            {
                if(Cantidad < 20)
                {
                    cuposSedeModels[Cantidad] = cuposSedeModel;
                    Cantidad++;

                    return "Guardado con éxito...!!!";
                }
                else
                {
                    return "No se permite registrar más cupos...!!!";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para consultar los cupos por la sede
        /// </summary>
        /// <param name="sede"></param>
        /// <returns></returns>
        public CuposSedeModel GetCuposBySede(SedesModel sede)
        {
            try
            {
                for (int i = 0; i < Cantidad; i++)
                {
                    if (cuposSedeModels[i].sedesModel.IdSede == sede.IdSede)
                    {
                        return cuposSedeModels[i];
                    }
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
