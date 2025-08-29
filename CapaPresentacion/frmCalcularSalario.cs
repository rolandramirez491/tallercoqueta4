using System;
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
namespace CapaPresentacion
{
    public partial class frmCalcularSalario : Form
    {
        public frmCalcularSalario()
        {
            InitializeComponent();
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salariomin = 1423500;
            string finder = File.ReadAllText("Empleados.txt");
            double salud = 0;
            double pension = 0;
            foreach (var linea in System.IO.File.ReadLines("Empleados.txt"))
            {
                var datos = linea.Split(',');
                if (datos[0] == txtCod.Text)
                {
                    salud = double.Parse(datos[5], CultureInfo.CurrentCulture) * 0.04;
                    pension = double.Parse(datos[5], CultureInfo.CurrentCulture) * 0.04;
                    lblSalud.Text = Convert.ToString(salud);
                    lblPension.Text = Convert.ToString(pension);
                    if (double.Parse(datos[5], CultureInfo.CurrentCulture) < salariomin * 2)
                    {
                        lblAuxilio.Text = 200000.ToString();
                    }
                    else
                    {
                        lblAuxilio.Text = "0";
                    }
                    lblSalarioNeto.Text = Convert.ToString(double.Parse(datos[5], CultureInfo.CurrentCulture) - salud - pension + double.Parse(lblAuxilio.Text, CultureInfo.CurrentCulture));
                    File.AppendAllText("Nomina.txt", txtCod.Text + "," + datos[1] + "," + datos[2] + "," + datos[3] + "," + datos[4] + "," + datos[5] + "," + lblSalud.Text + "," + lblPension.Text + "," + lblAuxilio.Text + "," + lblSalarioNeto.Text + Environment.NewLine);

                }
            }
        }
    }
}
