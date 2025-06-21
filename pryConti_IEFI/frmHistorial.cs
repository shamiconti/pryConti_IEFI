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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            clsTareas objTareas = new clsTareas();
            DataTable tabla = objTareas.ObtenerTareas();

            if (tabla != null)
            {
                dgvHistorial.DataSource = tabla;
            }
        }
    }
}
