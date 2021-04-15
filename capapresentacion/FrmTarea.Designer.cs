
namespace capapresentacion
{
    partial class FrmTarea
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
            this.label_añadir = new System.Windows.Forms.Label();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListTareas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.cboBuscarTareas = new System.Windows.Forms.ComboBox();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarTareas = new System.Windows.Forms.Button();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(170, 138);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 21;
            this.label_añadir.Text = "Añadir";
            this.label_añadir.Click += new System.EventHandler(this.label_añadir_Click);
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTareas);
            this.panelRecuadro.Location = new System.Drawing.Point(38, 180);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(663, 282);
            this.panelRecuadro.TabIndex = 20;
            // 
            // dataListTareas
            // 
            this.dataListTareas.AllowUserToAddRows = false;
            this.dataListTareas.AllowUserToDeleteRows = false;
            this.dataListTareas.AllowUserToOrderColumns = true;
            this.dataListTareas.BackgroundColor = System.Drawing.Color.White;
            this.dataListTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListTareas.Location = new System.Drawing.Point(0, 0);
            this.dataListTareas.Name = "dataListTareas";
            this.dataListTareas.ReadOnly = true;
            this.dataListTareas.RowHeadersWidth = 51;
            this.dataListTareas.Size = new System.Drawing.Size(663, 282);
            this.dataListTareas.TabIndex = 4;
            this.dataListTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListProyectos_CellContentClick);
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
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProyecto.Location = new System.Drawing.Point(222, 59);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(452, 20);
            this.txtBuscarProyecto.TabIndex = 14;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(46, 137);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 22;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // cboBuscarTareas
            // 
            this.cboBuscarTareas.FormattingEnabled = true;
            this.cboBuscarTareas.Items.AddRange(new object[] {
            "titulo",
            "observaciones",
            "codigo_proyecto"});
            this.cboBuscarTareas.Location = new System.Drawing.Point(46, 58);
            this.cboBuscarTareas.Name = "cboBuscarTareas";
            this.cboBuscarTareas.Size = new System.Drawing.Size(153, 21);
            this.cboBuscarTareas.TabIndex = 13;
            this.cboBuscarTareas.Text = "titulo";
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(114, 130);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarProyecto.TabIndex = 23;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(222, 130);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarTareas
            // 
            this.btnBuscarTareas.BackColor = System.Drawing.Color.White;
            this.btnBuscarTareas.BackgroundImage = global::capapresentacion.Properties.Resources.Lupa;
            this.btnBuscarTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTareas.Location = new System.Drawing.Point(677, 59);
            this.btnBuscarTareas.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarTareas.Name = "btnBuscarTareas";
            this.btnBuscarTareas.Size = new System.Drawing.Size(25, 21);
            this.btnBuscarTareas.TabIndex = 15;
            this.btnBuscarTareas.UseVisualStyleBackColor = false;
            // 
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscarTareas);
            this.Controls.Add(this.txtBuscarProyecto);
            this.Controls.Add(this.cboBuscarTareas);
            this.Name = "FrmTarea";
            this.Text = "FrmTarea";
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListTareas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscarTareas;
        private System.Windows.Forms.TextBox txtBuscarProyecto;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.ComboBox cboBuscarTareas;
    }
}