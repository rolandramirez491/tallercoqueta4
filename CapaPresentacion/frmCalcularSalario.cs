using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmCalcularSalario : Form
    {
        public frmCalcularSalario()
        {
            InitializeComponent();
        }
        private CN_Cliente objCN = new CN_Cliente();
        private CN_Cliente2 objCN2 = new CN_Cliente2();
        private List<object> lista = new List<object>();
        private List<object> lista2 = new List<object>();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lista = objCN.BuscarClientes(txtCod.Text);
            if (lista.Count > 0)
            {
                object cliente = lista[0];
                var tipo = cliente.GetType();
                lblNom.Text = tipo.GetProperty("Nombre").GetValue(cliente, null).ToString();
                lblApe.Text = tipo.GetProperty("Apellido").GetValue(cliente, null).ToString();
                lblEdad.Text = tipo.GetProperty("Edad").GetValue(cliente, null).ToString();
                lblCargo.Text = tipo.GetProperty("Cargo").GetValue(cliente, null).ToString();
                lblSalario.Text = tipo.GetProperty("Salario").GetValue(cliente, null).ToString();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
                txtCod.Text = "";
                lblNom.Text = "_";
                lblApe.Text = "_";
                lblEdad.Text = "_";
                lblCargo.Text = "_";
                lblSalario.Text = "_";
                txtCod.Focus();
            }
            //string finder = File.ReadAllText("Empleados.txt");
            //foreach (var linea in System.IO.File.ReadLines("Empleados.txt"))
            //{
            //    var datos = linea.Split(',');
            //    if (datos[0] == txtCod.Text)
            //    {
            //        lblNom.Text = datos[1];
            //        lblApe.Text = datos[2];
            //        lblEdad.Text = datos[3];
            //        lblCargo.Text = datos[4];
            //        lblSalario.Text = datos[5];
            //    }
            //}
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lista = objCN.BuscarClientes(txtCod.Text);
            
            if (lista.Count > 0)
            {
                object cliente = lista[0];
                var tipo = cliente.GetType();
                
                lblNom.Text = tipo.GetProperty("Nombre").GetValue(cliente, null).ToString();
                lblApe.Text = tipo.GetProperty("Apellido").GetValue(cliente, null).ToString();
                lblEdad.Text = tipo.GetProperty("Edad").GetValue(cliente, null).ToString();
                lblCargo.Text = tipo.GetProperty("Cargo").GetValue(cliente, null).ToString();
                lblSalario.Text = tipo.GetProperty("Salario").GetValue(cliente, null).ToString();

                lista2 = objCN2.BuscarClientes2(txtCod.Text);
                object cliente2 = lista2[0];
                var tipo2 = cliente2.GetType();

                lblSalud.Text= tipo2.GetProperty("Salud").GetValue(cliente2, null).ToString();
                lblPension.Text= tipo2.GetProperty("Pension").GetValue(cliente2, null).ToString();
                lblAuxilio.Text = tipo2.GetProperty("Auxiliotransporte").GetValue(cliente2, null).ToString();
                lblSalarioNeto.Text = tipo2.GetProperty("Salarioneto").GetValue(cliente2, null).ToString();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
                txtCod.Text = "";
                lblNom.Text = "_";
                lblApe.Text = "_";
                lblEdad.Text = "_";
                lblCargo.Text = "_";
                lblSalario.Text = "_";
                txtCod.Focus();
            }
            //string id = txtCod.Text;
            //string nombre = txtNom.Text;
            //string apellido = txtApe.Text;
            //string edad = txtEdad.Text;
            //string cargo = txtCargo.Text;
            //string salario = txtSalario.Text;
            ////File.AppendAllText("Empleados.txt", txtCod.Text + "," + txtNom.Text + "," + txtApe.Text + "," + txtEdad.Text + "," + txtCargo.Text + "," + txtSalario.Text + Environment.NewLine);
            //objCN2.RegistrarCliente2(id, nombre, apellido, edad, cargo, salario);
            //MessageBox.Show("Nomina calculada");
            //txtCod.Clear();

            //double salariomin = 1423500;
            //string finder = File.ReadAllText("Registro.txt");
            //double salud = 0;
            //double pension = 0;
            //foreach (var linea in System.IO.File.ReadLines("Registro.txt"))
            //{
            //    var datos = linea.Split(',');
            //    if (datos[0] == txtCod.Text)
            //    {
            //        salud = double.Parse(datos[5], CultureInfo.CurrentCulture) * 0.04;
            //        pension = double.Parse(datos[5], CultureInfo.CurrentCulture) * 0.04;
            //        lblSalud.Text = Convert.ToString(salud);
            //        lblPension.Text = Convert.ToString(pension);
            //        if (double.Parse(datos[5], CultureInfo.CurrentCulture) < salariomin * 2)
            //        {
            //            lblAuxilio.Text = 200000.ToString();
            //        }
            //        else
            //        {
            //            lblAuxilio.Text = "0";
            //        }
            //        lblSalarioNeto.Text = Convert.ToString(double.Parse(datos[5], CultureInfo.CurrentCulture) - salud - pension + double.Parse(lblAuxilio.Text, CultureInfo.CurrentCulture));
            //        File.AppendAllText("Nomina.txt", txtCod.Text + "," + datos[1] + "," + datos[2] + "," + datos[3] + "," + datos[4] + "," + datos[5] + "," + lblSalud.Text + "," + lblPension.Text + "," + lblAuxilio.Text + "," + lblSalarioNeto.Text + Environment.NewLine);

            //    }
            //}
        }
    }
    
}
