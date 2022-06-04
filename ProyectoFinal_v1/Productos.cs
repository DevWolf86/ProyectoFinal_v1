using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_v1
{
    public partial class Productos : Form
    {
        private int n = 0;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Cbaño.Items.Add("2022");
            Cbaño.Items.Add("2021");
            Cbaño.Items.Add("2020");
            Cbaño.Items.Add("2019");
            Cbaño.Items.Add("2018");
            Cbaño.Items.Add("2017");

            CbGenero.Items.Add("Accion");
            CbGenero.Items.Add("Comedia");
            CbGenero.Items.Add("Anime");
            CbGenero.Items.Add("Ciencia Ficcion");
            CbGenero.Items.Add("Drama");
            CbGenero.Items.Add("Documental");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adicionar usuarios a tabla
            int n = GrdPelis.Rows.Add();

            // diligenciamos los campos
            GrdPelis.Rows[n].Cells[0].Value = TxtNomPelicula.Text;
            GrdPelis.Rows[n].Cells[1].Value = CbGenero.Text;
            GrdPelis.Rows[n].Cells[2].Value = Cbaño.Text;

            // Se limpian los campos
            TxtNomPelicula.Text = "";
            CbGenero.Text = "";
            Cbaño.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Elimina la celda cargada
            if (n != -1)
            {
                GrdPelis.Rows.RemoveAt(n);
            }
        }
    }
}
