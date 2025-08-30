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
using System.Drawing.Text;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmRegistro_Busqueda : Form
    {
        public frmRegistro_Busqueda()
        {
            InitializeComponent();
        }
        //objeto de la capa negocio
        private CN_Cliente objCN = new CN_Cliente();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            string id= txtCod.Text;
            string nombre= txtNom.Text;
            string apellido= txtApe.Text;
            string edad= txtEdad.Text;
            string cargo= txtCargo.Text;
            string salario= txtSalario.Text;
            //File.AppendAllText("Empleados.txt", txtCod.Text + "," + txtNom.Text + "," + txtApe.Text + "," + txtEdad.Text + "," + txtCargo.Text + "," + txtSalario.Text + Environment.NewLine);
            objCN.RegistrarCliente(id, nombre, apellido, edad, cargo, salario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string finder = File.ReadAllText("Empleados.txt");
            foreach (var linea in System.IO.File.ReadLines("Empleados.txt"))
            {
                var datos = linea.Split(',');
                if (datos[0] == txtCod.Text)
                {
                    lblNom.Text = datos[1];
                    lblApe.Text = datos[2];
                    lblEdad.Text = datos[3];
                    lblCargo.Text = datos[4];
                    lblSalario.Text = datos[5];
                }
            }
        }
    }
}
