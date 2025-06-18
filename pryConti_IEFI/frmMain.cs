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
        public frmMain()
        {
            InitializeComponent();
        }

        //Estas dos variables se completan desde frmLogin
        public string usuario;
        public int idCategoria;

        int contadorTiempo = 0;

        clsUsuario objUsuario = new clsUsuario();

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
                usuariosToolStripMenuItem.Visible = false; //Desactiva el botón de Usuarios
                administrarTareasYLugaresToolStripMenuItem.Visible = false;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.Stop();

            TimeSpan tiempo = TimeSpan.FromSeconds(contadorTiempo);
            string tiempoTexto = tiempo.ToString(@"hh\:mm\:ss");

            objUsuario.RegistrarLog(usuario, idCategoria, tiempoTexto);
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

        private void administrarTareasYLugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarTarea frmAdministrarTarea = new frmAdministrarTarea();
            frmAdministrarTarea.ShowDialog();
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
    }
}
