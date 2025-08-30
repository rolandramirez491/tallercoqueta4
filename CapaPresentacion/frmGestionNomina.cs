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
    public partial class frmGestionNomina : Form
    {
        public frmGestionNomina()
        {
            InitializeComponent();
        }
        private CN_Cliente2 objCN2 = new CN_Cliente2();
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = objCN2.ListarClientes2();
            //string finder = File.ReadAllText("Nomina.txt");
            //var lista = new DataTable();
            //lista.Columns.Add("Codigo", typeof(string));
            //lista.Columns.Add("Nombre", typeof(string));
            //lista.Columns.Add("Apellido", typeof(string));
            //lista.Columns.Add("Edad", typeof(string));
            //lista.Columns.Add("Cargo", typeof(string));
            //lista.Columns.Add("Salario", typeof(string));
            //lista.Columns.Add("Deduccion Salud", typeof(string));
            //lista.Columns.Add("Deduccion Pension", typeof(string));
            //lista.Columns.Add("Auxilio de transporte", typeof(string));
            //lista.Columns.Add("Salario Neto", typeof(string));
            //foreach (var linea in System.IO.File.ReadLines("Nomina.txt"))
            //{
            //    var datos = linea.Split(',');
            //    if (datos[0] == txtCod.Text)
            //    {
            //        lista.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9]);
            //    }
            //}
            //dataGridView1.DataSource = lista;
            //dataGridView1.Refresh();
        }
    }
}
