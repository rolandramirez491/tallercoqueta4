using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string finder = File.ReadAllText("Empleados.txt");
            var lista = new DataTable();
            lista.Columns.Add("Codigo", typeof(string));
            lista.Columns.Add("Nombre", typeof(string));
            lista.Columns.Add("Apellido", typeof(string));
            lista.Columns.Add("Edad", typeof(string));
            lista.Columns.Add("Cargo", typeof(string));
            lista.Columns.Add("Salario", typeof(string));
            foreach (var linea in System.IO.File.ReadLines("Empleados.txt"))
            {
                var datos = linea.Split(',');
                lista.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
            }
            dgvListado.DataSource = lista;
            dgvListado.Refresh();
        }
    }
}
