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
    public partial class frmMain : Form
    {
        //Estas dos variables se completan desde frmLogin
        public string usuario;
        public int idCategoria;

        int contadorTiempo = 0;

        clsUsuario objUsuario = new clsUsuario();

        public frmMain()
        {
            InitializeComponent();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            contadorTiempo++;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            temporizador.Start();
            lblUsuario.Text = usuario;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (idCategoria == 2) //Operador
            {
                administradorToolStripMenuItem.Visible = false; //Desactiva el botón
                toolStripMenuItem1.Visible = false;

            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.Stop();

            TimeSpan tiempo = TimeSpan.FromSeconds(contadorTiempo);
            string tiempoTexto = tiempo.ToString(@"hh\:mm\:ss");

            try
            {
                objUsuario.RegistrarLog(usuario, idCategoria, tiempoTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el log:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estás seguro de que querés cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                frmLogin frmlogin = new frmLogin();
                frmlogin.Show();

                this.Close();
            }
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria frmAuditoria = new frmAuditoria();
            frmAuditoria.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTareas frmTareas = new frmTareas();
            frmTareas.ShowDialog();
        }

        private void tareasYLugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarTarea frmAdministrarTarea = new frmAdministrarTarea();
            frmAdministrarTarea.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frmHistorial = new frmHistorial();
            frmHistorial.ShowDialog();
        }
    }
}
