using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.Repository
{
    public class ClientesRepository
    {
        private static ClientesModel[] clientes = new ClientesModel[20];
        private static int Cantidad = 0;

        public ClientesRepository(){}

        /// <summary>
        /// Metodo para guardar clientes
        /// </summary>
        /// <param name="clientesModel"></param>
        /// <returns></returns>
        public string Insert(ClientesModel clientesModel)
        {
            try
            {
                if (Cantidad < 20)
                {
                    clientes[Cantidad] = clientesModel;
                    Cantidad++;

                    return "Guardado con éxito...!!!";
                }
                else
                {
                    return "No se permite el registro de más clientes...!!!";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lista todos los clientes
        /// </summary>
        /// <returns></returns>
        public ClientesModel[] GetAll() => clientes;
       
    }
}
