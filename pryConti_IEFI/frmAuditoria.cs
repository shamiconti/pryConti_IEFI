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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();
            DataTable tabla = objUsuario.ObtenerLogs();

            if (tabla != null)
            {
                dgvAuditoria.DataSource = tabla;
            }
        }
    }
}
