
namespace capapresentacion
{
    partial class FrmDetalleProyecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleProyecto));
            this.lbl_idproyecto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloProyecto = new System.Windows.Forms.Label();
            this.txtObservacionesProyecto = new System.Windows.Forms.RichTextBox();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.txtTituloProyecto = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mensajetool = new System.Windows.Forms.ToolTip(this.components);
            this.iconoerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dtFechaProyecto = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idproyecto
            // 
            this.lbl_idproyecto.AutoSize = true;
            this.lbl_idproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idproyecto.Location = new System.Drawing.Point(37, 31);
            this.lbl_idproyecto.Name = "lbl_idproyecto";
            this.lbl_idproyecto.Size = new System.Drawing.Size(114, 25);
            this.lbl_idproyecto.TabIndex = 1;
            this.lbl_idproyecto.Text = "IdProyecto";
            this.lbl_idproyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Proyecto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(39, 178);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(162, 25);
            this.lblObservaciones.TabIndex = 11;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha";
            // 
            // lblTituloProyecto
            // 
            this.lblTituloProyecto.AutoSize = true;
            this.lblTituloProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProyecto.Location = new System.Drawing.Point(92, 68);
            this.lblTituloProyecto.Name = "lblTituloProyecto";
            this.lblTituloProyecto.Size = new System.Drawing.Size(65, 25);
            this.lblTituloProyecto.TabIndex = 8;
            this.lblTituloProyecto.Text = "Título";
            this.lblTituloProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObservacionesProyecto
            // 
            this.txtObservacionesProyecto.Location = new System.Drawing.Point(42, 217);
            this.txtObservacionesProyecto.Name = "txtObservacionesProyecto";
            this.txtObservacionesProyecto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservacionesProyecto.Size = new System.Drawing.Size(651, 210);
            this.txtObservacionesProyecto.TabIndex = 14;
            this.txtObservacionesProyecto.Text = "";
            this.txtObservacionesProyecto.TextChanged += new System.EventHandler(this.txtObservacionesProyecto_TextChanged);
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Location = new System.Drawing.Point(169, 31);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(162, 20);
            this.txtIdProyecto.TabIndex = 15;
            this.txtIdProyecto.TextChanged += new System.EventHandler(this.txtIdProyecto_TextChanged);
            // 
            // txtTituloProyecto
            // 
            this.txtTituloProyecto.Location = new System.Drawing.Point(169, 68);
            this.txtTituloProyecto.Name = "txtTituloProyecto";
            this.txtTituloProyecto.Size = new System.Drawing.Size(162, 20);
            this.txtTituloProyecto.TabIndex = 16;
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(169, 109);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(162, 20);
            this.txtProyecto.TabIndex = 17;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(126, 449);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(256, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(408, 449);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(542, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // iconoerror
            // 
            this.iconoerror.ContainerControl = this;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(489, 25);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(204, 20);
            this.txtFecha.TabIndex = 23;
            // 
            // dtFechaProyecto
            // 
            this.dtFechaProyecto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaProyecto.Location = new System.Drawing.Point(489, 65);
            this.dtFechaProyecto.Name = "dtFechaProyecto";
            this.dtFechaProyecto.Size = new System.Drawing.Size(204, 20);
            this.dtFechaProyecto.TabIndex = 18;
            this.dtFechaProyecto.ValueChanged += new System.EventHandler(this.dtFechaProyecto_ValueChanged);
            // 
            // FrmDetalleProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 494);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtFechaProyecto);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.txtTituloProyecto);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.txtObservacionesProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloProyecto);
            this.Controls.Add(this.lbl_idproyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetalleProyecto";
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.FrmDetalleProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idproyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloProyecto;
        private System.Windows.Forms.RichTextBox txtObservacionesProyecto;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.TextBox txtTituloProyecto;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip mensajetool;
        private System.Windows.Forms.ErrorProvider iconoerror;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DateTimePicker dtFechaProyecto;
    }
}