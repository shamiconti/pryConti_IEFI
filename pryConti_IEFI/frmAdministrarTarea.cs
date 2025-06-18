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
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbTarea.SelectedValue);
                string nuevoNombre = txtTarea.Text.Trim();

                if (nuevoNombre != "")
                {
                    objTarea.ModificarTarea(id, nuevoNombre);
                    MessageBox.Show("Tarea modificada.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objTarea.CargarComboTareas(cmbTarea);
                }
                else
                {
                    MessageBox.Show("Ingrese un nuevo nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                MessageBox.Show("Ingrese un nombre de tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbTarea.SelectedValue);
                DialogResult rta = MessageBox.Show("¿Seguro que desea eliminar esta tarea?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rta == DialogResult.Yes)
                {
                    objTarea.EliminarTarea(id);
                    MessageBox.Show("Tarea eliminada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objTarea.CargarComboTareas(cmbTarea);
                }
            }
        }
    }
}
