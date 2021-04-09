using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;

namespace capapresentacion
{
    public partial class FrmDetalleProyecto : Form
    {
        bool esnuevo = false;
        bool esditar = false;
        public FrmDetalleProyecto()
        {
            InitializeComponent();
        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje,"Detalle de Proyecto",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            this.txtIdProyecto.Text = string.Empty;
            this.txtTituloProyecto.Text = string.Empty;
            this.txtTiempoTotalProyectos.Text = string.Empty;
            //this.dtFechaProyecto.Text = string.Empty;
            this.txtObservacionesProyecto.Text = string.Empty;
        }

        private void habilitar(bool valor)
        {
            this.txtIdProyecto.ReadOnly = true;
            this.txtTituloProyecto.ReadOnly = !valor;
            this.txtTiempoTotalProyectos.ReadOnly = !valor;
            this.txtTiempoTotalProyectos.ReadOnly = !valor;
            // this.dtFechaProyecto.ResumeLayout();
            this.txtObservacionesProyecto.ReadOnly = !valor;
        }
        
        private void botones()
        {
            if(esnuevo || this.esditar)
            {
                habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

       
        private void FrmDetalleProyecto_Load(object sender, EventArgs e)
        {
            this.botones();
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        private void cerrarX(object sender, EventArgs e)
        {
            FrmPrincipal1 frmPrincipal = new FrmPrincipal1();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            botones();
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(this.txtTituloProyecto.Text==string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    this.iconoerror.SetError(this.txtTituloProyecto, "Ingresar Título");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NProyecto.insertarproyecto(this.txtTituloProyecto.Text.Trim().ToUpper(),this.txtObservacionesProyecto.Text.Trim(), Convert.ToDateTime(this.dtFechaProyecto.Value));
                    }
                    else
                    {
                        rpta = NProyecto.editarproyecto(Convert.ToInt32(this.txtIdProyecto),this.txtTituloProyecto.Text.Trim().ToUpper(), this.txtObservacionesProyecto.Text.Trim(),Convert.ToDateTime(this.dtFechaProyecto));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado el proyecto satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("Se ha editado el proyecto satisfactoriamente");
                        }
                        
                    }
                    else {
                        this.mensajeerror(rpta);
                    }
                    this.esnuevo = false;
                    this.esditar = false;
                    botones();
                    this.limpiar();
                    //FrmPrincipal.mostrarproyectos();
                   
                    //TODO es necesario mostrar los proyectos desde detalleProyecto?

             
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
