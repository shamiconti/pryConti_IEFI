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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsUsuario objUsuario = new clsUsuario();

        // Variables para pasar al frmMain
        public string usuario;
        public int idCategoria;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var fila = objUsuario.BuscarUsuario(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());

            if (fila != null)
            {
                usuario = fila["Usuario"].ToString();
                idCategoria = Convert.ToInt32(fila["IdCategoria"]);

                MessageBox.Show("Bienvenido/a, " + usuario + ".", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain nuevoForm = new frmMain();
                nuevoForm.usuario = usuario;
                nuevoForm.idCategoria = idCategoria;
                nuevoForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
