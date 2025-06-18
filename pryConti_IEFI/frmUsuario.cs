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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        clsUsuario objUsuario = new clsUsuario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            // Validar
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                objUsuario.AgregarUsuario(usuario, contraseña, idCategoria);

                MessageBox.Show("Usuario agregado correctamente.");

                // Limpiar controles
                txtUsuario.Clear();
                txtContraseña.Clear();
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }

        private void tpAgregarEliminar_Click(object sender, EventArgs e)
        {
            objUsuario.CargarComboCategorias(cmbCategoria);
            cmbCategoria.SelectedIndex = -1;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            objUsuario.CargarComboCategorias(cmbCategoria);
            cmbCategoria.SelectedIndex = -1;

            objUsuario.CargarComboUsuarios(cmbEliminarUsuario);
            cmbEliminarUsuario.SelectedIndex = -1;

            objUsuario.CargarComboCategorias(cmbModificarCategoria);
            cmbEliminarUsuario.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbEliminarUsuario.SelectedIndex != -1)
            {
                int idUsuario = Convert.ToInt32(cmbEliminarUsuario.SelectedValue);

                // Llamar al método para eliminar
                objUsuario.EliminarUsuario(idUsuario);

                MessageBox.Show("Usuario eliminado correctamente.");

                // Recargar el combo para actualizar la lista sin el eliminado
                objUsuario.CargarComboUsuarios(cmbEliminarUsuario);
                cmbEliminarUsuario.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            string usuario = txtModificarUsuario.Text.Trim();
            string contraseña = txtModificarContraseña.Text.Trim();
            int idCategoria;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || cmbModificarCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                idCategoria = Convert.ToInt32(cmbModificarCategoria.SelectedValue);

                objUsuario.ModificarUsuario(usuario, contraseña, idCategoria);

                txtModificarUsuario.Clear();
                txtModificarContraseña.Clear();
                cmbModificarCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = objUsuario.ObtenerUsuarios();
            if (dt != null)
            {
                dgvMostrar.DataSource = dt;
            }
        }
    }
}
