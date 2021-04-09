
namespace capapresentacion
{
    partial class FrmProyectosl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProyectosl));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabProyectos = new System.Windows.Forms.TabPage();
            this.cboBuscarProyecto = new System.Windows.Forms.ComboBox();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListProyectos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ControlPestanias = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabProyectos.SuspendLayout();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProyectos)).BeginInit();
            this.ControlPestanias.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabProyectos
            // 
            this.tabProyectos.Controls.Add(this.panelRecuadro);
            this.tabProyectos.Controls.Add(this.btnNuevo);
            this.tabProyectos.Controls.Add(this.btnEliminarProyecto);
            this.tabProyectos.Controls.Add(this.lblTotal);
            this.tabProyectos.Controls.Add(this.cbEliminar);
            this.tabProyectos.Controls.Add(this.btnBuscarProyecto);
            this.tabProyectos.Controls.Add(this.txtBuscarProyecto);
            this.tabProyectos.Controls.Add(this.cboBuscarProyecto);
            this.tabProyectos.Location = new System.Drawing.Point(4, 22);
            this.tabProyectos.Name = "tabProyectos";
            this.tabProyectos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProyectos.Size = new System.Drawing.Size(802, 517);
            this.tabProyectos.TabIndex = 0;
            this.tabProyectos.Text = "Proyectos";
            this.tabProyectos.UseVisualStyleBackColor = true;
            // 
            // cboBuscarProyecto
            // 
            this.cboBuscarProyecto.FormattingEnabled = true;
            this.cboBuscarProyecto.Items.AddRange(new object[] {
            "titulo",
            "observaciones",
            "codigo_proyecto"});
            this.cboBuscarProyecto.Location = new System.Drawing.Point(28, 25);
            this.cboBuscarProyecto.Name = "cboBuscarProyecto";
            this.cboBuscarProyecto.Size = new System.Drawing.Size(165, 21);
            this.cboBuscarProyecto.TabIndex = 2;
            this.cboBuscarProyecto.Text = "titulo";
            this.cboBuscarProyecto.SelectedIndexChanged += new System.EventHandler(this.cboBuscarProyecto_SelectedIndexChanged);
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.Location = new System.Drawing.Point(228, 25);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(316, 20);
            this.txtBuscarProyecto.TabIndex = 5;
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProyecto.Image = global::capapresentacion.Properties.Resources.Lupa;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(566, 8);
            this.btnBuscarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(46, 52);
            this.btnBuscarProyecto.TabIndex = 6;
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.P_btnBuscar_Click);
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(28, 106);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 7;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(397, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "lblTotal";
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.Image = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(93, 85);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(55, 56);
            this.btnEliminarProyecto.TabIndex = 9;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Image = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.Location = new System.Drawing.Point(642, 8);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(71, 74);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListProyectos);
            this.panelRecuadro.Location = new System.Drawing.Point(21, 150);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(480, 282);
            this.panelRecuadro.TabIndex = 11;
            // 
            // dataListProyectos
            // 
            this.dataListProyectos.AllowUserToAddRows = false;
            this.dataListProyectos.AllowUserToDeleteRows = false;
            this.dataListProyectos.AllowUserToOrderColumns = true;
            this.dataListProyectos.BackgroundColor = System.Drawing.Color.White;
            this.dataListProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListProyectos.Location = new System.Drawing.Point(0, 0);
            this.dataListProyectos.Name = "dataListProyectos";
            this.dataListProyectos.ReadOnly = true;
            this.dataListProyectos.RowHeadersWidth = 51;
            this.dataListProyectos.Size = new System.Drawing.Size(480, 282);
            this.dataListProyectos.TabIndex = 4;
            this.dataListProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListProyectos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 2;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ControlPestanias
            // 
            this.ControlPestanias.Controls.Add(this.tabProyectos);
            this.ControlPestanias.Location = new System.Drawing.Point(12, 12);
            this.ControlPestanias.Name = "ControlPestanias";
            this.ControlPestanias.SelectedIndex = 0;
            this.ControlPestanias.Size = new System.Drawing.Size(810, 543);
            this.ControlPestanias.TabIndex = 0;
            // 
            // FrmProyectosl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 567);
            this.Controls.Add(this.ControlPestanias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProyectosl";
            this.Text = "WPTimeTracking";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabProyectos.ResumeLayout(false);
            this.tabProyectos.PerformLayout();
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListProyectos)).EndInit();
            this.ControlPestanias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl ControlPestanias;
        private System.Windows.Forms.TabPage tabProyectos;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListProyectos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.TextBox txtBuscarProyecto;
        private System.Windows.Forms.ComboBox cboBuscarProyecto;
    }
}