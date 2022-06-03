using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_v1
{
    public partial class Form1 : Form
    {
        private int n = 0;

        // Conexion a oracle
        OracleConnection ora = new OracleConnection(@"uid=Adminp;password=pwd2022");
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adicionar usuarios a tabla
            int n = GrdUsuarios.Rows.Add();

            // diligenciamos los campos
            GrdUsuarios.Rows[n].Cells[0].Value = txtname.Text;
            GrdUsuarios.Rows[n].Cells[1].Value = TxtApellido.Text;
            GrdUsuarios.Rows[n].Cells[2].Value = CmRol.Text;

            // Se limpian los campos
            txtname.Text = "";
            TxtApellido.Text = "";
            CmRol.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmRol.Items.Add("Administrador");
            CmRol.Items.Add("Supervisor");
            CmRol.Items.Add("Coordinador");
            CmRol.Items.Add("Tecnico");
            CmRol.Items.Add("Soporte");
            CmRol.Items.Add("Usuario");           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Elimina la celda cargada
            if (n != -1)
            {
                GrdUsuarios.Rows.RemoveAt(n);
            }
        }

        private void GrdUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selecciona la celda para poder elimianrla 
            n = e.RowIndex;

            if (n != -1)
            {
                txtname.Text = (string)GrdUsuarios.Rows[n].Cells[0].Value;
                TxtApellido.Text = (string)GrdUsuarios.Rows[n].Cells[1].Value;
            }
        }
    }
}
