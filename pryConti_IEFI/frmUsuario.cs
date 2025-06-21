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

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            objUsuario.CargarComboCategorias(cmbCategoria);
            cmbCategoria.SelectedIndex = -1;

            objUsuario.CargarComboUsuarios(cmbEliminarUsuario);
            cmbEliminarUsuario.SelectedIndex = -1;

            objUsuario.CargarComboCategorias(cmbModificarCategoria);

            objUsuario.CargarComboUsuarios(cmbUsuarioModificar);
            cmbUsuarioModificar.SelectedIndex = -1;

            ValidarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            objUsuario.AgregarUsuario(usuario, contraseña, idCategoria);

            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            objUsuario.CargarComboUsuarios(cmbUsuarioModificar);
            objUsuario.CargarComboUsuarios(cmbEliminarUsuario);

            cmbEliminarUsuario.SelectedIndex = -1;
            cmbUsuarioModificar.SelectedIndex = -1;

            txtUsuario.Clear();
            txtContraseña.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(cmbUsuarioModificar.SelectedValue);
            string usuario = txtModificarUsuario.Text.Trim();
            string contraseña = txtModificarContraseña.Text.Trim();
            int idCategoria = Convert.ToInt32(cmbModificarCategoria.SelectedValue); ;

            DialogResult rta = MessageBox.Show("¿Estás seguro de que querés modificar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                objUsuario.ModificarUsuario(idUsuario, usuario, contraseña, idCategoria);

                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Recargar combo
                objUsuario.CargarComboUsuarios(cmbUsuarioModificar);
                objUsuario.CargarComboUsuarios(cmbEliminarUsuario);
                cmbEliminarUsuario.SelectedIndex = -1;

                txtModificarUsuario.Clear();
                txtModificarContraseña.Clear();
                cmbUsuarioModificar.SelectedIndex = -1;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {            
            int idUsuario = Convert.ToInt32(cmbEliminarUsuario.SelectedValue);

            DialogResult rta = MessageBox.Show("¿Estás seguro de que querés eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                objUsuario.EliminarUsuario(idUsuario);

                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Recargar el combo para actualizar la lista sin el eliminado
                objUsuario.CargarComboUsuarios(cmbEliminarUsuario);
                objUsuario.CargarComboUsuarios(cmbUsuarioModificar);

                cmbUsuarioModificar.SelectedIndex = -1;
                cmbEliminarUsuario.SelectedIndex = -1;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = objUsuario.ObtenerUsuarios();
            if (dt != null)
            {
                dgvListar.DataSource = dt;
            }
        }

        private void ValidarDatos()
        {
            btnAgregar.Enabled =
                txtUsuario.Text != "" &&
                txtContraseña.Text != "" &&
                cmbCategoria.SelectedIndex != -1;

            btnModifcar.Enabled =
                cmbUsuarioModificar.SelectedIndex != -1 &&
                txtModificarUsuario.Text != "" ||
                txtModificarContraseña.Text != "";

            btnEliminar.Enabled = cmbEliminarUsuario.SelectedIndex != -1;
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtModificarUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtModificarContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbEliminarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbUsuarioModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
