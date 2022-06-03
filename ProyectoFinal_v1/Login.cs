using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ProyectoFinal_v1
{
    public partial class Login : Form
    {
        // Conexion a oracle
        OracleConnection ora = new OracleConnection(@"uid=Adminp;password=pwd2022");

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TxtUser.Text;
            string contrasena = TxtPass.Text;

            ora.Open();
            OracleCommand cmd = new OracleCommand("select usuario, contrasena from usuarios where usuario = (" + name + ") and contrasena = (" + contrasena +");", ora);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bienvenido");
            ora.Close();
        }
    }
}
