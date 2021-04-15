using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PCCRISTHIAN\\SQLEXPRESS;Initial Catalog=DesarrollosTime;Integrated Security=False;User Id=winplus;Password=Pbjjajlp5h4m1");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sacamos el hostname
            String hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            try
            {
                con.Open();
                SqlCommand query = new SqlCommand("select count(*) as existe from Empleados where usuario=@usuario and maquina=@hostname", con);
                query.Parameters.AddWithValue("@usuario", usuario.Text);
                query.Parameters.AddWithValue("@hostname", hostName);
                //para el comando

                String existe = "";

                using (SqlDataReader oReader = query.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        existe = oReader["existe"].ToString();
                    }
                }
                if (existe.Equals("1"))
                {
                    FrmPrincipal1 principal = new FrmPrincipal1();
                    this.Hide();
                    principal.Show();
                    
                }


                con.Close();
            }
            catch (Exception)
            {

            }
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
