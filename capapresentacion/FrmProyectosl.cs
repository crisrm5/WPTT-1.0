using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capanegocio;

namespace capapresentacion
{
    public partial class FrmProyectos : Form
    {
        public FrmProyectos()
        {
            InitializeComponent();
            btnEliminarProyecto.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            mostrarproyectos();
            convertirWidget();
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void P_btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            mostrarproyectos();
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        public void mostrarproyectos()
        {
            this.dataListProyectos.DataSource = NProyecto.mostrarproyectos();
            this.ocultarcolumnas();
            this.btnEliminarProyecto.Visible = true;
            this.lblTotal.Text = "Número de proyectos: " + Convert.ToString(dataListProyectos.Rows.Count);
        }

        private void ocultarcolumnas()
        {
            this.dataListProyectos.Columns[0].Visible = false;
            this.dataListProyectos.Columns[1].Visible = false;
            this.btnEliminarProyecto.Enabled = false;
            this.cbEliminar.Checked = false;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    int id;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListProyectos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            aux = 1;

                            id = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NProyecto.eliminarproyecto(id);

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Registro eliminado");
                            }
                            else
                            {
                                this.mensajeerror("¡Ups!, Al parecer tienes tareas asignadas a este proyecto...");
                                this.mensajeerror(rpta);
                            }
                        }
                    }
                    if (aux < 1)
                    {
                        MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    this.mostrarproyectos();
                }
                else
                {
                    this.btnEliminarProyecto.Enabled = false;
                    this.cbEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void dataListProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListProyectos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListProyectos.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbEliminar.Checked)
            {
                this.dataListProyectos.Columns[0].Visible = true;
                this.btnEliminarProyecto.Enabled = true;
            }
            else
            {
                this.dataListProyectos.Columns[0].Visible = false;
                this.btnEliminarProyecto.Enabled = false;
            }
        }


        public FrmPrincipal1 frmparent;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmparent.lanzarNuevoProyecto(new FrmDetalleProyecto());
        }

        private void cerrarX(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }



        private void cboBuscarProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convertirWidget()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            ShowInTaskbar = false;
            this.Text = String.Empty;
            this.ControlBox = false;


        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlPestanias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*fin del drag*/
    }
}
