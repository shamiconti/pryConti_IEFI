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
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }
        
        clsTareas objTarea = new clsTareas();

        int idUltimoRegistro = -1;

        private void frmTareas_Load(object sender, EventArgs e)
        {
            objTarea.CargarComboTareas(cmbTarea);
            objTarea.CargarComboLugares(cmbLugar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date; // solo fecha, sin hora
            int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);
            int idLugar = Convert.ToInt32(cmbLugar.SelectedValue);

            try
            {
                idUltimoRegistro = objTarea.AgregarTarea(fecha, idTarea, idLugar);

                if (idUltimoRegistro > 0)
                {
                    MessageBox.Show("La tarea fue agregada correctamente.", "Tarea agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTareas.DataSource = objTarea.ObtenerListadoTareas();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del registro insertado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar la tarea:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (idUltimoRegistro == -1)
            {
                MessageBox.Show("Primero debés agregar una tarea antes de grabar los detalles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool insumo = chkInsumo.Checked;
            bool estudio = chkEstudio.Checked;
            bool vacaciones = chkVacaciones.Checked;
            bool salario = chkSalario.Checked;
            bool recibo = chkRecibo.Checked;
            string comentario = rtbComentario.Text;

            try
            {
                objTarea.GrabarDetalle(idUltimoRegistro, insumo, estudio, vacaciones, salario, recibo, comentario);

                MessageBox.Show("Detalle grabado correctamente.", "Detalle guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                chkInsumo.Checked = false;
                chkEstudio.Checked = false;
                chkVacaciones.Checked = false;
                chkSalario.Checked = false;
                chkRecibo.Checked = false;
                rtbComentario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            chkInsumo.Checked = false;
            chkEstudio.Checked = false;
            chkVacaciones.Checked = false;
            chkSalario.Checked = false;
            chkRecibo.Checked = false;

            rtbComentario.Clear();
        }
    }
}
