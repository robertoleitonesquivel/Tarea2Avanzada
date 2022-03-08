using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.Repository
{
    public class AfiliacionSedeRepository
    {
        private static AfiliciacionSedeModel[] afiliaciones = new AfiliciacionSedeModel[20];
        private static int Cantidad = 0;

        /// <summary>
        /// Insertar afiliaciones
        /// </summary>
        /// <param name="afiliacionesModel"></param>
        /// <returns></returns>
        public string Insert(AfiliciacionSedeModel afiliacionesModel)
        {
            try
            {
                if (Cantidad < 20)
                {
                    afiliaciones[Cantidad] = afiliacionesModel;
                    Cantidad++;

                    return "Guardado con éxito...!!!";
                }
                else
                {
                    return "No se permite registrar más afiliaciones...!!!";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para obtener las afiliaciones de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public AfiliciacionSedeModel GetAfiliacionByCliente(ClientesModel cliente)
        {
            try
            {
                for (int i = 0; i < Cantidad; i++)
                {
                    if (afiliaciones[i].clientesModel.Identificacion == cliente.Identificacion)
                    {
                        return afiliaciones[i];
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
