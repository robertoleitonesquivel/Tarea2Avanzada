using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class frmAnalizar : Form
    {
        Logica logica = new Logica();

        public frmAnalizar()
        {
            InitializeComponent();
            this.listar();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (Logica.cantidadClientes > 0)
            {
                Task task1 = femenino();
                Task task2 = masculino();
            }
            else MessageBox.Show("No hay clientes registrados...!!!");
        }

        private async Task femenino()
        {
            this.tblFemenino.Rows.Clear();

            await logica.SelectedFemenino();


            for (int i = 0; i < Logica.cantidadFemeninos; i++)
            {

                this.tblFemenino.Rows.Add(Logica.femenino[i].Identificacion, Logica.femenino[i].Nombre, Logica.femenino[i].PrimerApellido, Logica.femenino[i].SegundoApellido, Logica.femenino[i].FechaNacimiento, Logica.femenino[i].Genero, Logica.femenino[i].FechaIngreso);
            }

        }

        private async Task masculino()
        {
            this.tblMasculino.Rows.Clear();

            await logica.SelectedMasculino();

            for (int i = 0; i < Logica.cantidadMasculinos; i++)
            {

                this.tblMasculino.Rows.Add(Logica.masculino[i].Identificacion, Logica.masculino[i].Nombre, Logica.masculino[i].PrimerApellido, Logica.masculino[i].SegundoApellido, Logica.masculino[i].FechaNacimiento, Logica.masculino[i].Genero, Logica.masculino[i].FechaIngreso);
            }

        }

        private void listar()
        {
            try
            {
                for (int i = 0; i < Logica.cantidadClientes; i++)
                {

                    this.tblClientes.Rows.Add(Logica.clientesList[i].Identificacion, Logica.clientesList[i].Nombre, Logica.clientesList[i].PrimerApellido, Logica.clientesList[i].SegundoApellido, Logica.clientesList[i].FechaNacimiento, Logica.clientesList[i].Genero, Logica.clientesList[i].FechaIngreso);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
