using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class FrmTarea : Form
    {
        public FrmTarea()
        {
            InitializeComponent();
            
        }
        public FrmPrincipal1 frmparent;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmparent.lanzarNuevoProyecto(new FrmDetalleTarea());
        }

        private void label_añadir_Click(object sender, EventArgs e)
        {

        }



        private void dataListProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
