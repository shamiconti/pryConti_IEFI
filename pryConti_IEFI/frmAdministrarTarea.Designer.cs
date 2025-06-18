namespace pryConti_IEFI
{
    partial class frmAdministrarTarea
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
            this.tabAdministrar = new System.Windows.Forms.TabControl();
            this.tpTarea = new System.Windows.Forms.TabPage();
            this.dgvMostrarTarea = new System.Windows.Forms.DataGridView();
            this.btnMostrarTarea = new System.Windows.Forms.Button();
            this.grpTarea = new System.Windows.Forms.GroupBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.lblSeleccionarTarea = new System.Windows.Forms.Label();
            this.lblNuevaTarea = new System.Windows.Forms.Label();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.btnModifcarTarea = new System.Windows.Forms.Button();
            this.tpLugar = new System.Windows.Forms.TabPage();
            this.dgvMostrarLugar = new System.Windows.Forms.DataGridView();
            this.btnMostrarLugar = new System.Windows.Forms.Button();
            this.grpLugar = new System.Windows.Forms.GroupBox();
            this.btnEliminarLugar = new System.Windows.Forms.Button();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblSeleccionarLugar = new System.Windows.Forms.Label();
            this.lblNuevoLugar = new System.Windows.Forms.Label();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnModificarLugar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAdministrar.SuspendLayout();
            this.tpTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarTarea)).BeginInit();
            this.grpTarea.SuspendLayout();
            this.tpLugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLugar)).BeginInit();
            this.grpLugar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdministrar
            // 
            this.tabAdministrar.Controls.Add(this.tpTarea);
            this.tabAdministrar.Controls.Add(this.tpLugar);
            this.tabAdministrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdministrar.Location = new System.Drawing.Point(0, 0);
            this.tabAdministrar.Name = "tabAdministrar";
            this.tabAdministrar.SelectedIndex = 0;
            this.tabAdministrar.Size = new System.Drawing.Size(606, 364);
            this.tabAdministrar.TabIndex = 8;
            // 
            // tpTarea
            // 
            this.tpTarea.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpTarea.Controls.Add(this.dgvMostrarTarea);
            this.tpTarea.Controls.Add(this.btnMostrarTarea);
            this.tpTarea.Controls.Add(this.grpTarea);
            this.tpTarea.Location = new System.Drawing.Point(4, 25);
            this.tpTarea.Name = "tpTarea";
            this.tpTarea.Padding = new System.Windows.Forms.Padding(3);
            this.tpTarea.Size = new System.Drawing.Size(598, 335);
            this.tpTarea.TabIndex = 0;
            this.tpTarea.Text = "Tarea";
            // 
            // dgvMostrarTarea
            // 
            this.dgvMostrarTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarTarea.Location = new System.Drawing.Point(172, 163);
            this.dgvMostrarTarea.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrarTarea.Name = "dgvMostrarTarea";
            this.dgvMostrarTarea.Size = new System.Drawing.Size(272, 130);
            this.dgvMostrarTarea.TabIndex = 18;
            // 
            // btnMostrarTarea
            // 
            this.btnMostrarTarea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrarTarea.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMostrarTarea.Location = new System.Drawing.Point(234, 301);
            this.btnMostrarTarea.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarTarea.Name = "btnMostrarTarea";
            this.btnMostrarTarea.Size = new System.Drawing.Size(148, 28);
            this.btnMostrarTarea.TabIndex = 17;
            this.btnMostrarTarea.Text = "MOSTRAR";
            this.btnMostrarTarea.UseVisualStyleBackColor = false;
            this.btnMostrarTarea.Click += new System.EventHandler(this.btnMostrarTarea_Click);
            // 
            // grpTarea
            // 
            this.grpTarea.Controls.Add(this.btnEliminarTarea);
            this.grpTarea.Controls.Add(this.btnAgregarTarea);
            this.grpTarea.Controls.Add(this.txtTarea);
            this.grpTarea.Controls.Add(this.lblSeleccionarTarea);
            this.grpTarea.Controls.Add(this.lblNuevaTarea);
            this.grpTarea.Controls.Add(this.cmbTarea);
            this.grpTarea.Controls.Add(this.btnModifcarTarea);
            this.grpTarea.Location = new System.Drawing.Point(9, 6);
            this.grpTarea.Name = "grpTarea";
            this.grpTarea.Size = new System.Drawing.Size(581, 140);
            this.grpTarea.TabIndex = 8;
            this.grpTarea.TabStop = false;
            this.grpTarea.Text = "Agregar, Modificar o Eliminar";
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTarea.Location = new System.Drawing.Point(393, 83);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(149, 28);
            this.btnEliminarTarea.TabIndex = 10;
            this.btnEliminarTarea.Text = "Eliminar";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarTarea.Location = new System.Drawing.Point(39, 83);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(149, 28);
            this.btnAgregarTarea.TabIndex = 8;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(101, 36);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(149, 22);
            this.txtTarea.TabIndex = 3;
            // 
            // lblSeleccionarTarea
            // 
            this.lblSeleccionarTarea.AutoSize = true;
            this.lblSeleccionarTarea.Location = new System.Drawing.Point(281, 39);
            this.lblSeleccionarTarea.Name = "lblSeleccionarTarea";
            this.lblSeleccionarTarea.Size = new System.Drawing.Size(121, 16);
            this.lblSeleccionarTarea.TabIndex = 0;
            this.lblSeleccionarTarea.Text = "Seleccionar Tarea:";
            // 
            // lblNuevaTarea
            // 
            this.lblNuevaTarea.AutoSize = true;
            this.lblNuevaTarea.Location = new System.Drawing.Point(6, 39);
            this.lblNuevaTarea.Name = "lblNuevaTarea";
            this.lblNuevaTarea.Size = new System.Drawing.Size(89, 16);
            this.lblNuevaTarea.TabIndex = 0;
            this.lblNuevaTarea.Text = "Nueva Tarea:";
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(408, 36);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(149, 24);
            this.cmbTarea.TabIndex = 15;
            // 
            // btnModifcarTarea
            // 
            this.btnModifcarTarea.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModifcarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifcarTarea.Location = new System.Drawing.Point(216, 83);
            this.btnModifcarTarea.Name = "btnModifcarTarea";
            this.btnModifcarTarea.Size = new System.Drawing.Size(149, 28);
            this.btnModifcarTarea.TabIndex = 14;
            this.btnModifcarTarea.Text = "Modificar";
            this.btnModifcarTarea.UseVisualStyleBackColor = false;
            this.btnModifcarTarea.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // tpLugar
            // 
            this.tpLugar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpLugar.Controls.Add(this.dgvMostrarLugar);
            this.tpLugar.Controls.Add(this.btnMostrarLugar);
            this.tpLugar.Controls.Add(this.grpLugar);
            this.tpLugar.Controls.Add(this.button1);
            this.tpLugar.Location = new System.Drawing.Point(4, 25);
            this.tpLugar.Name = "tpLugar";
            this.tpLugar.Padding = new System.Windows.Forms.Padding(3);
            this.tpLugar.Size = new System.Drawing.Size(598, 335);
            this.tpLugar.TabIndex = 1;
            this.tpLugar.Text = "Lugar";
            // 
            // dgvMostrarLugar
            // 
            this.dgvMostrarLugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLugar.Location = new System.Drawing.Point(173, 163);
            this.dgvMostrarLugar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrarLugar.Name = "dgvMostrarLugar";
            this.dgvMostrarLugar.Size = new System.Drawing.Size(272, 130);
            this.dgvMostrarLugar.TabIndex = 26;
            // 
            // btnMostrarLugar
            // 
            this.btnMostrarLugar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrarLugar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMostrarLugar.Location = new System.Drawing.Point(235, 301);
            this.btnMostrarLugar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarLugar.Name = "btnMostrarLugar";
            this.btnMostrarLugar.Size = new System.Drawing.Size(148, 28);
            this.btnMostrarLugar.TabIndex = 25;
            this.btnMostrarLugar.Text = "MOSTRAR";
            this.btnMostrarLugar.UseVisualStyleBackColor = false;
            this.btnMostrarLugar.Click += new System.EventHandler(this.btnMostrarLugar_Click);
            // 
            // grpLugar
            // 
            this.grpLugar.Controls.Add(this.txtLugar);
            this.grpLugar.Controls.Add(this.lblSeleccionarLugar);
            this.grpLugar.Controls.Add(this.lblNuevoLugar);
            this.grpLugar.Controls.Add(this.cmbLugar);
            this.grpLugar.Controls.Add(this.btnEliminarLugar);
            this.grpLugar.Controls.Add(this.btnAgregarLugar);
            this.grpLugar.Controls.Add(this.btnModificarLugar);
            this.grpLugar.Location = new System.Drawing.Point(10, 6);
            this.grpLugar.Name = "grpLugar";
            this.grpLugar.Size = new System.Drawing.Size(580, 140);
            this.grpLugar.TabIndex = 23;
            this.grpLugar.TabStop = false;
            this.grpLugar.Text = "Agregar, Modificar o Eliminar";
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminarLugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarLugar.Location = new System.Drawing.Point(401, 87);
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.Size = new System.Drawing.Size(149, 28);
            this.btnEliminarLugar.TabIndex = 10;
            this.btnEliminarLugar.Text = "Eliminar";
            this.btnEliminarLugar.UseVisualStyleBackColor = false;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarLugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarLugar.Location = new System.Drawing.Point(31, 87);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(149, 28);
            this.btnAgregarLugar.TabIndex = 8;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.UseVisualStyleBackColor = false;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(103, 36);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(149, 22);
            this.txtLugar.TabIndex = 3;
            // 
            // lblSeleccionarLugar
            // 
            this.lblSeleccionarLugar.AutoSize = true;
            this.lblSeleccionarLugar.Location = new System.Drawing.Point(284, 39);
            this.lblSeleccionarLugar.Name = "lblSeleccionarLugar";
            this.lblSeleccionarLugar.Size = new System.Drawing.Size(122, 16);
            this.lblSeleccionarLugar.TabIndex = 0;
            this.lblSeleccionarLugar.Text = "Seleccionar Lugar:";
            // 
            // lblNuevoLugar
            // 
            this.lblNuevoLugar.AutoSize = true;
            this.lblNuevoLugar.Location = new System.Drawing.Point(6, 39);
            this.lblNuevoLugar.Name = "lblNuevoLugar";
            this.lblNuevoLugar.Size = new System.Drawing.Size(91, 16);
            this.lblNuevoLugar.TabIndex = 0;
            this.lblNuevoLugar.Text = "Nuevo Lugar:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(412, 36);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(149, 24);
            this.cmbLugar.TabIndex = 15;
            // 
            // btnModificarLugar
            // 
            this.btnModificarLugar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModificarLugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarLugar.Location = new System.Drawing.Point(216, 87);
            this.btnModificarLugar.Name = "btnModificarLugar";
            this.btnModificarLugar.Size = new System.Drawing.Size(149, 28);
            this.btnModificarLugar.TabIndex = 14;
            this.btnModificarLugar.Text = "Modificar";
            this.btnModificarLugar.UseVisualStyleBackColor = false;
            this.btnModificarLugar.Click += new System.EventHandler(this.btnModificarLugar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(380, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAdministrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(606, 364);
            this.Controls.Add(this.tabAdministrar);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdministrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.frmAdministrarTarea_Load);
            this.tabAdministrar.ResumeLayout(false);
            this.tpTarea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarTarea)).EndInit();
            this.grpTarea.ResumeLayout(false);
            this.grpTarea.PerformLayout();
            this.tpLugar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLugar)).EndInit();
            this.grpLugar.ResumeLayout(false);
            this.grpLugar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdministrar;
        private System.Windows.Forms.TabPage tpTarea;
        private System.Windows.Forms.DataGridView dgvMostrarTarea;
        private System.Windows.Forms.Button btnMostrarTarea;
        private System.Windows.Forms.GroupBox grpTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label lblNuevaTarea;
        private System.Windows.Forms.TabPage tpLugar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSeleccionarTarea;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button btnModifcarTarea;
        private System.Windows.Forms.DataGridView dgvMostrarLugar;
        private System.Windows.Forms.Button btnMostrarLugar;
        private System.Windows.Forms.Button btnEliminarLugar;
        private System.Windows.Forms.Label lblSeleccionarLugar;
        private System.Windows.Forms.Button btnModificarLugar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.GroupBox grpLugar;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblNuevoLugar;
    }
}