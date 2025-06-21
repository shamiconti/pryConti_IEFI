using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryConti_IEFI
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        clsUsuario objUsuario = new clsUsuario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Complete el " + lblNombre.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Complete el " + lblApellido.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            else if (txtDNI.Text == "")
            {
                MessageBox.Show("Complete el " + lblDNI.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
            }
            else if (!int.TryParse(txtDNI.Text.Trim(), out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Complete el " + lblTelefono.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Complete el " + lblEmail.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Complete el " + lblDireccion.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
            }
            else
            {
                MessageBox.Show("Datos registrados correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string email = txtEmail.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                objUsuario.AgregarPersona(nombre, apellido, dni, telefono, email, direccion);

                txtNombre.Clear();
                txtApellido.Clear();
                txtDNI.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtDireccion.Clear();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataTable tabla = objUsuario.ListarPersonas();

            if (tabla != null)
            {
                dgvPersona.DataSource = tabla;
            }
        }
    }
}
