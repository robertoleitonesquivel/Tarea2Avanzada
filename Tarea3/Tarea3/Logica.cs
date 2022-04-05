using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    public class Logica
    {
        public static Clientes[] clientesList = new Clientes[20];
        public static Clientes[] femenino = new Clientes[20];
        public static Clientes[] masculino = new Clientes[20];
        public static int cantidadClientes = 0;
        public static int cantidadFemeninos = 0;
        public static int cantidadMasculinos = 0;

        /// <summary>
        /// METODO PARA INSERTAR CLIENTES
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public string Save(Clientes clientes)
        {
            try
            {
                if (cantidadClientes < 20)
                {
                    clientesList[cantidadClientes] = clientes;
                    cantidadClientes++;

                    return "Cliente insertado con éxito...!!!";
                }
                else
                {
                    return "No se puede insertar más clientes...!!!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// METODO PARA VERIFICAR SI UNA IDENTIFICACION YA EXISTE
        /// </summary>
        /// <param name="identificacion"></param>
        public void VerifyExistClient(string identificacion)
        {
            for (int i = 0; i < cantidadClientes; i++)
            {
                if (clientesList[i].Identificacion.Equals(identificacion))
                {
                    throw new Exception($"El cliente con la identificación {identificacion}, ya se encuentra registrado en el sistema...!!!");
                }
            }
        }

        /// <summary>
        /// METODO PARA SELECCIONAR MASCULINO
        /// </summary>
        /// <returns></returns>
        public async Task SelectedMasculino()
        {
            try
            {
                var task = new Task(() =>
                {
                    for (int i = 0; i < cantidadClientes; i++)
                    {

                        if (clientesList[i].Genero == 'M')
                        {
                            masculino[cantidadMasculinos] = clientesList[i];
                            cantidadMasculinos++;
                        }
                    }
                });

                task.Start();
                await task;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// METODO PARA SELECCIONAR FEMENINO
        /// </summary>
        /// <returns></returns>
        public async Task SelectedFemenino()
        {
            try
            {
                var task = new Task(() =>
                {
                    for (int i = 0; i < cantidadClientes; i++)
                    {

                        if (clientesList[i].Genero == 'F')
                        {
                            femenino[cantidadFemeninos] = clientesList[i];
                            cantidadFemeninos++;
                        }
                    }
                });

                task.Start();
                //await Task.Delay(5000); descomentar esta linea para probar que en realidad se estan ejecutando los metodos en pararlelo
                await task;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
