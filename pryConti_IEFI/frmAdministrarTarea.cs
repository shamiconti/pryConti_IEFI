using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryConti_IEFI
{
    public partial class frmAdministrarTarea : Form
    {
        public frmAdministrarTarea()
        {
            InitializeComponent();
        }

        clsTareas objTarea = new clsTareas();

        private void frmAdministrarTarea_Load(object sender, EventArgs e)
        {
            objTarea.CargarComboTareas(cmbTarea);
            cmbTarea.SelectedIndex = -1;

            objTarea.CargarComboLugares(cmbLugar);
            cmbLugar.SelectedIndex = -1;
        }

        #region TareaCRUD

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbTarea.SelectedValue);
            string nuevoNombre = txtTarea.Text.Trim();

            if (cmbTarea.SelectedValue != null && nuevoNombre != "")
            {
                DialogResult rta = MessageBox.Show("¿Estás seguro de que querés modificar esta tarea?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {
                    objTarea.ModificarTarea(id, nuevoNombre);
                    MessageBox.Show("Tarea modificada.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objTarea.CargarComboTareas(cmbTarea);

                    txtTarea.Clear();
                    cmbTarea.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea e ingrese un nuevo nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string nombre = txtTarea.Text.Trim();

            if (nombre != "")
            {
                objTarea.AgregarTareaCRUD(nombre);
                MessageBox.Show("Tarea agregada con éxito.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objTarea.CargarComboTareas(cmbTarea);
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de una tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtTarea.Clear();
            cmbTarea.SelectedIndex = -1;
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbTarea.SelectedValue);
                DialogResult rta = MessageBox.Show("¿Estás seguro de que querés eliminar esta tarea?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rta == DialogResult.Yes)
                {
                    objTarea.EliminarTarea(id);
                    MessageBox.Show("Tarea eliminada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objTarea.CargarComboTareas(cmbTarea);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cmbTarea.SelectedIndex = -1;
        }

        private void btnListarTarea_Click(object sender, EventArgs e)
        {
            DataTable dt = objTarea.MostrarTarea();
            if (dt != null)
            {
                dgvListarTarea.DataSource = dt;
            }
        }

        #endregion

        #region LugarCRUD
        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            string nombre = txtLugar.Text.Trim();

            if (nombre != "")
            {
                objTarea.AgregarLugarCRUD(nombre);
                MessageBox.Show("Lugar agregado con éxito.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objTarea.CargarComboLugares(cmbLugar);
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de un lugar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtLugar.Clear();
            cmbLugar.SelectedIndex = -1;
        }

        private void btnModificarLugar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbLugar.SelectedValue);
            string nuevoNombre = txtLugar.Text.Trim();

            if (cmbLugar.SelectedValue != null && nuevoNombre != "")
            {
                DialogResult rta = MessageBox.Show("¿Estás seguro de que querés modificar este lugar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (rta == DialogResult.Yes)
                {
                    objTarea.ModificarLugar(id, nuevoNombre);
                    MessageBox.Show("Lugar modificado.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objTarea.CargarComboLugares(cmbLugar);

                    txtLugar.Clear();
                    cmbLugar.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un lugar e ingrese un nuevo nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            if (cmbLugar.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbLugar.SelectedValue);
                DialogResult rta = MessageBox.Show("¿Estás seguro de que querés eliminar este lugar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rta == DialogResult.Yes)
                {
                    objTarea.EliminarLugar(id);
                    MessageBox.Show("Lugar eliminado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objTarea.CargarComboLugares(cmbLugar);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un lugar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmbLugar.SelectedIndex = -1;
        }

        private void btnListarLugar_Click(object sender, EventArgs e)
        {
            DataTable dt = objTarea.MostrarLugar();
            if (dt != null)
            {
                dgvListarLugar.DataSource = dt;
            }
        }

        #endregion
    }
}
