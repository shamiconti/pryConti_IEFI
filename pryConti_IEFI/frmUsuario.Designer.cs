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
            this.tpAgregarEliminar = new System.Windows.Forms.TabPage();
            this.tpModificarMostrar = new System.Windows.Forms.TabPage();
            this.grpIngresarDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.txtModificarUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.cmbModificarCategoria = new System.Windows.Forms.ComboBox();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.lblModificarContraseña = new System.Windows.Forms.Label();
            this.txtModificarContraseña = new System.Windows.Forms.TextBox();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.cmbEliminarUsuario = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminarUsuario = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tabUsuarios.SuspendLayout();
            this.tpAgregarEliminar.SuspendLayout();
            this.tpModificarMostrar.SuspendLayout();
            this.grpIngresarDatos.SuspendLayout();
            this.grpModificar.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tpAgregarEliminar);
            this.tabUsuarios.Controls.Add(this.tpModificarMostrar);
            this.tabUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.SelectedIndex = 0;
            this.tabUsuarios.Size = new System.Drawing.Size(620, 320);
            this.tabUsuarios.TabIndex = 7;
            // 
            // tpAgregarEliminar
            // 
            this.tpAgregarEliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpAgregarEliminar.Controls.Add(this.grpEliminar);
            this.tpAgregarEliminar.Controls.Add(this.grpIngresarDatos);
            this.tpAgregarEliminar.Location = new System.Drawing.Point(4, 25);
            this.tpAgregarEliminar.Name = "tpAgregarEliminar";
            this.tpAgregarEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregarEliminar.Size = new System.Drawing.Size(612, 291);
            this.tpAgregarEliminar.TabIndex = 0;
            this.tpAgregarEliminar.Text = "Agregar y Eliminar";
            this.tpAgregarEliminar.Click += new System.EventHandler(this.tpAgregarEliminar_Click);
            // 
            // tpModificarMostrar
            // 
            this.tpModificarMostrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpModificarMostrar.Controls.Add(this.dgvMostrar);
            this.tpModificarMostrar.Controls.Add(this.btnMostrar);
            this.tpModificarMostrar.Controls.Add(this.grpModificar);
            this.tpModificarMostrar.Location = new System.Drawing.Point(4, 25);
            this.tpModificarMostrar.Name = "tpModificarMostrar";
            this.tpModificarMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpModificarMostrar.Size = new System.Drawing.Size(612, 291);
            this.tpModificarMostrar.TabIndex = 1;
            this.tpModificarMostrar.Text = "Modificar y Mostrar";
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
            this.grpIngresarDatos.Location = new System.Drawing.Point(8, 6);
            this.grpIngresarDatos.Name = "grpIngresarDatos";
            this.grpIngresarDatos.Size = new System.Drawing.Size(261, 159);
            this.grpIngresarDatos.TabIndex = 8;
            this.grpIngresarDatos.TabStop = false;
            this.grpIngresarDatos.Text = "Ingresar datos de usuario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(93, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 28);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(93, 84);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(149, 24);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(93, 56);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(149, 22);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(93, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(6, 59);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 16);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.lblModificarCategoria);
            this.grpModificar.Controls.Add(this.txtModificarContraseña);
            this.grpModificar.Controls.Add(this.txtModificarUsuario);
            this.grpModificar.Controls.Add(this.lblNuevoUsuario);
            this.grpModificar.Controls.Add(this.cmbModificarCategoria);
            this.grpModificar.Controls.Add(this.btnModifcar);
            this.grpModificar.Controls.Add(this.lblModificarContraseña);
            this.grpModificar.Location = new System.Drawing.Point(8, 6);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(287, 188);
            this.grpModificar.TabIndex = 13;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar";
            // 
            // txtModificarUsuario
            // 
            this.txtModificarUsuario.Location = new System.Drawing.Point(125, 31);
            this.txtModificarUsuario.Name = "txtModificarUsuario";
            this.txtModificarUsuario.Size = new System.Drawing.Size(149, 22);
            this.txtModificarUsuario.TabIndex = 17;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(12, 34);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblNuevoUsuario.TabIndex = 16;
            this.lblNuevoUsuario.Text = "Usuario:";
            // 
            // cmbModificarCategoria
            // 
            this.cmbModificarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarCategoria.FormattingEnabled = true;
            this.cmbModificarCategoria.Location = new System.Drawing.Point(125, 103);
            this.cmbModificarCategoria.Name = "cmbModificarCategoria";
            this.cmbModificarCategoria.Size = new System.Drawing.Size(149, 24);
            this.cmbModificarCategoria.TabIndex = 15;
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModifcar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifcar.Location = new System.Drawing.Point(126, 133);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(148, 28);
            this.btnModifcar.TabIndex = 14;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // lblModificarContraseña
            // 
            this.lblModificarContraseña.AutoSize = true;
            this.lblModificarContraseña.Location = new System.Drawing.Point(12, 72);
            this.lblModificarContraseña.Name = "lblModificarContraseña";
            this.lblModificarContraseña.Size = new System.Drawing.Size(81, 16);
            this.lblModificarContraseña.TabIndex = 13;
            this.lblModificarContraseña.Text = "Contraseña:";
            // 
            // txtModificarContraseña
            // 
            this.txtModificarContraseña.Location = new System.Drawing.Point(125, 67);
            this.txtModificarContraseña.Name = "txtModificarContraseña";
            this.txtModificarContraseña.Size = new System.Drawing.Size(149, 22);
            this.txtModificarContraseña.TabIndex = 18;
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Location = new System.Drawing.Point(13, 106);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(70, 16);
            this.lblModificarCategoria.TabIndex = 19;
            this.lblModificarCategoria.Text = "Categoría:";
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.cmbEliminarUsuario);
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.lblEliminarUsuario);
            this.grpEliminar.Location = new System.Drawing.Point(332, 6);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(272, 105);
            this.grpEliminar.TabIndex = 13;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar";
            // 
            // cmbEliminarUsuario
            // 
            this.cmbEliminarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarUsuario.FormattingEnabled = true;
            this.cmbEliminarUsuario.Location = new System.Drawing.Point(104, 36);
            this.cmbEliminarUsuario.Name = "cmbEliminarUsuario";
            this.cmbEliminarUsuario.Size = new System.Drawing.Size(149, 24);
            this.cmbEliminarUsuario.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(104, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 28);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(302, 13);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(301, 145);
            this.dgvMostrar.TabIndex = 15;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMostrar.Location = new System.Drawing.Point(378, 166);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(148, 28);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(620, 320);
            this.Controls.Add(this.tabUsuarios);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabUsuarios.ResumeLayout(false);
            this.tpAgregarEliminar.ResumeLayout(false);
            this.tpModificarMostrar.ResumeLayout(false);
            this.grpIngresarDatos.ResumeLayout(false);
            this.grpIngresarDatos.PerformLayout();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsuarios;
        private System.Windows.Forms.TabPage tpAgregarEliminar;
        private System.Windows.Forms.GroupBox grpIngresarDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tpModificarMostrar;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.TextBox txtModificarUsuario;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.ComboBox cmbModificarCategoria;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Label lblModificarContraseña;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.TextBox txtModificarContraseña;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.ComboBox cmbEliminarUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminarUsuario;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnMostrar;
    }
}