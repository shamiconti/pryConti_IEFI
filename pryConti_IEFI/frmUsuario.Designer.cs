namespace pryConti_IEFI
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUsuarios = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.grpIngresarDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tpModificar = new System.Windows.Forms.TabPage();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.txtModificarContraseña = new System.Windows.Forms.TextBox();
            this.txtModificarUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.cmbModificarCategoria = new System.Windows.Forms.ComboBox();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.lblModificarContraseña = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.cmbEliminarUsuario = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminarUsuario = new System.Windows.Forms.Label();
            this.tpListar = new System.Windows.Forms.TabPage();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblSeleccionarUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarioModificar = new System.Windows.Forms.ComboBox();
            this.tabUsuarios.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            this.grpIngresarDatos.SuspendLayout();
            this.tpModificar.SuspendLayout();
            this.grpModificar.SuspendLayout();
            this.tpEliminar.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            this.tpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tpAgregar);
            this.tabUsuarios.Controls.Add(this.tpModificar);
            this.tabUsuarios.Controls.Add(this.tpEliminar);
            this.tabUsuarios.Controls.Add(this.tpListar);
            this.tabUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.SelectedIndex = 0;
            this.tabUsuarios.Size = new System.Drawing.Size(620, 320);
            this.tabUsuarios.TabIndex = 7;
            // 
            // tpAgregar
            // 
            this.tpAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpAgregar.Controls.Add(this.grpIngresarDatos);
            this.tpAgregar.Location = new System.Drawing.Point(4, 25);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(612, 291);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            // 
            // grpIngresarDatos
            // 
            this.grpIngresarDatos.Controls.Add(this.btnAgregar);
            this.grpIngresarDatos.Controls.Add(this.cmbCategoria);
            this.grpIngresarDatos.Controls.Add(this.txtContraseña);
            this.grpIngresarDatos.Controls.Add(this.txtUsuario);
            this.grpIngresarDatos.Controls.Add(this.lblCategoria);
            this.grpIngresarDatos.Controls.Add(this.lblContraseña);
            this.grpIngresarDatos.Controls.Add(this.lblUsuario);
            this.grpIngresarDatos.Location = new System.Drawing.Point(150, 57);
            this.grpIngresarDatos.Name = "grpIngresarDatos";
            this.grpIngresarDatos.Size = new System.Drawing.Size(312, 205);
            this.grpIngresarDatos.TabIndex = 8;
            this.grpIngresarDatos.TabStop = false;
            this.grpIngresarDatos.Text = "Ingresar datos de usuario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(133, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 46);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(133, 99);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(160, 24);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(133, 63);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(160, 22);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 103);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(15, 66);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 16);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(15, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tpModificar
            // 
            this.tpModificar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpModificar.Controls.Add(this.grpModificar);
            this.tpModificar.Location = new System.Drawing.Point(4, 25);
            this.tpModificar.Name = "tpModificar";
            this.tpModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tpModificar.Size = new System.Drawing.Size(612, 291);
            this.tpModificar.TabIndex = 1;
            this.tpModificar.Text = "Modificar";
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.lblSeleccionarUsuario);
            this.grpModificar.Controls.Add(this.cmbUsuarioModificar);
            this.grpModificar.Controls.Add(this.lblModificarCategoria);
            this.grpModificar.Controls.Add(this.txtModificarContraseña);
            this.grpModificar.Controls.Add(this.txtModificarUsuario);
            this.grpModificar.Controls.Add(this.lblNuevoUsuario);
            this.grpModificar.Controls.Add(this.cmbModificarCategoria);
            this.grpModificar.Controls.Add(this.btnModifcar);
            this.grpModificar.Controls.Add(this.lblModificarContraseña);
            this.grpModificar.Location = new System.Drawing.Point(147, 35);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(330, 235);
            this.grpModificar.TabIndex = 13;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar";
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Location = new System.Drawing.Point(6, 156);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(113, 16);
            this.lblModificarCategoria.TabIndex = 19;
            this.lblModificarCategoria.Text = "Nueva Categoría:";
            // 
            // txtModificarContraseña
            // 
            this.txtModificarContraseña.Location = new System.Drawing.Point(147, 117);
            this.txtModificarContraseña.Name = "txtModificarContraseña";
            this.txtModificarContraseña.Size = new System.Drawing.Size(160, 22);
            this.txtModificarContraseña.TabIndex = 18;
            this.txtModificarContraseña.TextChanged += new System.EventHandler(this.txtModificarContraseña_TextChanged);
            // 
            // txtModificarUsuario
            // 
            this.txtModificarUsuario.Location = new System.Drawing.Point(147, 81);
            this.txtModificarUsuario.Name = "txtModificarUsuario";
            this.txtModificarUsuario.Size = new System.Drawing.Size(160, 22);
            this.txtModificarUsuario.TabIndex = 17;
            this.txtModificarUsuario.TextChanged += new System.EventHandler(this.txtModificarUsuario_TextChanged);
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(6, 84);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(104, 16);
            this.lblNuevoUsuario.TabIndex = 16;
            this.lblNuevoUsuario.Text = "Nuevo Usuario:";
            // 
            // cmbModificarCategoria
            // 
            this.cmbModificarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarCategoria.FormattingEnabled = true;
            this.cmbModificarCategoria.Location = new System.Drawing.Point(147, 153);
            this.cmbModificarCategoria.Name = "cmbModificarCategoria";
            this.cmbModificarCategoria.Size = new System.Drawing.Size(160, 24);
            this.cmbModificarCategoria.TabIndex = 15;
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModifcar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifcar.Location = new System.Drawing.Point(147, 183);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(160, 46);
            this.btnModifcar.TabIndex = 14;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // lblModificarContraseña
            // 
            this.lblModificarContraseña.AutoSize = true;
            this.lblModificarContraseña.Location = new System.Drawing.Point(6, 120);
            this.lblModificarContraseña.Name = "lblModificarContraseña";
            this.lblModificarContraseña.Size = new System.Drawing.Size(124, 16);
            this.lblModificarContraseña.TabIndex = 13;
            this.lblModificarContraseña.Text = "Nueva Contraseña:";
            // 
            // tpEliminar
            // 
            this.tpEliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpEliminar.Controls.Add(this.grpEliminar);
            this.tpEliminar.Location = new System.Drawing.Point(4, 25);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEliminar.Size = new System.Drawing.Size(612, 291);
            this.tpEliminar.TabIndex = 2;
            this.tpEliminar.Text = "Eliminar";
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.cmbEliminarUsuario);
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.lblEliminarUsuario);
            this.grpEliminar.Location = new System.Drawing.Point(155, 84);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(303, 134);
            this.grpEliminar.TabIndex = 14;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar";
            // 
            // cmbEliminarUsuario
            // 
            this.cmbEliminarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarUsuario.FormattingEnabled = true;
            this.cmbEliminarUsuario.Location = new System.Drawing.Point(104, 39);
            this.cmbEliminarUsuario.Name = "cmbEliminarUsuario";
            this.cmbEliminarUsuario.Size = new System.Drawing.Size(160, 24);
            this.cmbEliminarUsuario.TabIndex = 12;
            this.cmbEliminarUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbEliminarUsuario_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(104, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 46);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblEliminarUsuario
            // 
            this.lblEliminarUsuario.AutoSize = true;
            this.lblEliminarUsuario.Location = new System.Drawing.Point(6, 39);
            this.lblEliminarUsuario.Name = "lblEliminarUsuario";
            this.lblEliminarUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblEliminarUsuario.TabIndex = 0;
            this.lblEliminarUsuario.Text = "Usuario:";
            // 
            // tpListar
            // 
            this.tpListar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpListar.Controls.Add(this.dgvListar);
            this.tpListar.Controls.Add(this.btnListar);
            this.tpListar.Location = new System.Drawing.Point(4, 25);
            this.tpListar.Name = "tpListar";
            this.tpListar.Padding = new System.Windows.Forms.Padding(3);
            this.tpListar.Size = new System.Drawing.Size(612, 291);
            this.tpListar.TabIndex = 3;
            this.tpListar.Text = "Listar";
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(97, 46);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(419, 165);
            this.dgvListar.TabIndex = 17;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnListar.Location = new System.Drawing.Point(226, 236);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 46);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblSeleccionarUsuario
            // 
            this.lblSeleccionarUsuario.AutoSize = true;
            this.lblSeleccionarUsuario.Location = new System.Drawing.Point(6, 24);
            this.lblSeleccionarUsuario.Name = "lblSeleccionarUsuario";
            this.lblSeleccionarUsuario.Size = new System.Drawing.Size(135, 16);
            this.lblSeleccionarUsuario.TabIndex = 21;
            this.lblSeleccionarUsuario.Text = "Seleccionar Usuario:";
            // 
            // cmbUsuarioModificar
            // 
            this.cmbUsuarioModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioModificar.FormattingEnabled = true;
            this.cmbUsuarioModificar.Location = new System.Drawing.Point(147, 21);
            this.cmbUsuarioModificar.Name = "cmbUsuarioModificar";
            this.cmbUsuarioModificar.Size = new System.Drawing.Size(160, 24);
            this.cmbUsuarioModificar.TabIndex = 20;
            this.cmbUsuarioModificar.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarioModificar_SelectedIndexChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(620, 320);
            this.Controls.Add(this.tabUsuarios);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabUsuarios.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.grpIngresarDatos.ResumeLayout(false);
            this.grpIngresarDatos.PerformLayout();
            this.tpModificar.ResumeLayout(false);
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            this.tpEliminar.ResumeLayout(false);
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            this.tpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsuarios;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.GroupBox grpIngresarDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tpModificar;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.TextBox txtModificarUsuario;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.ComboBox cmbModificarCategoria;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Label lblModificarContraseña;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.TextBox txtModificarContraseña;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.ComboBox cmbEliminarUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminarUsuario;
        private System.Windows.Forms.TabPage tpListar;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblSeleccionarUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarioModificar;
    }
}