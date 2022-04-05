using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class frmClientes : Form
    {
        Logica logica = new Logica();

        /*VARIABLES DE VALIDACION*/
        Regex regex = new Regex("^[0-9]{9}$");

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateFields())
                {
                    this.logica.VerifyExistClient(this.txtIdentificacion.Text);

                    Clientes clientes = new Clientes();

                    clientes.Identificacion = this.txtIdentificacion.Text;
                    clientes.Nombre = this.txtNombre.Text;
                    clientes.PrimerApellido = this.txtPrimerApellido.Text;
                    clientes.SegundoApellido = this.txtSegundoApellido.Text;
                    clientes.FechaNacimiento = this.txtFechaNacimiento.Value;
                    clientes.Genero = this.rbMasculino.Checked ? 'M' : 'F';
                    clientes.FechaIngreso = this.txtFechaIngreso.Value;

                    string res = this.logica.Save(clientes);

                    MessageBox.Show(res);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateFields()
        {
            try
            {
                if (this.txtIdentificacion.Text.Equals("") || this.txtNombre.Text.Equals("") || this.txtPrimerApellido.Text.Equals("")
                    || this.txtSegundoApellido.Text.Equals("") || (!this.rbFemenino.Checked && !this.rbMasculino.Checked))
                {
                    MessageBox.Show("Todos los campos son requeridos...!!!");

                    return false;
                }else if (!this.regex.IsMatch(this.txtIdentificacion.Text))
                {
                    MessageBox.Show("La identificación solo acepta números, y debe contener 9 caracteres...!!!");

                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
