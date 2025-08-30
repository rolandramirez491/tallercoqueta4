using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cliente2
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }

        public string Salud { get; set; }
        public string Pension { get; set; }
        public string Auxiliotransporte { get; set; }
        public string Salarioneto { get; set; }

        public Cliente2() { }
        public Cliente2(string id, string nombre, string apellido, string edad, string cargo, string salario, string salud, string pension, string auxiliotransporte, string salarioneto)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            Salario = salario;
            Salud = salud;
            Pension = pension;
            Auxiliotransporte = auxiliotransporte;
            Salarioneto = salarioneto;
        }
        //metodo para convertir a linea del archivo plano
        public string LineaArchivo2()
        {
            double Salariomin = 1423500;
            double Salud1 = 0;
            double Pension1 = 0;
            double Auxiliotransporte1 = 0;
            double Salarioneto1 = 0;
            Salud1 = double.Parse(Salario, CultureInfo.CurrentCulture) * 0.04;
            Pension1 = double.Parse(Salario, CultureInfo.CurrentCulture) * 0.04;
            if (double.Parse(Salario, CultureInfo.CurrentCulture) < Salariomin * 2)
            {
                Auxiliotransporte1 = 200000;
            }
            else
            {
                Auxiliotransporte1 =0;
            }
            Salarioneto1 = double.Parse(Salario, CultureInfo.CurrentCulture) - Salud1 - Pension1 + Auxiliotransporte1;
            Salud= Convert.ToString(Salud1);
            Pension= Convert.ToString(Pension1);
            Auxiliotransporte= Convert.ToString(Auxiliotransporte1);
            Salarioneto= Convert.ToString(Salarioneto1);
            return $"{Id},{Nombre},{Apellido},{Edad},{Cargo},{Salario},{Salud},{Pension},{Auxiliotransporte},{Salarioneto}";
        }
        public Cliente2 SepararLinea2(string linea)
        {
            string[] datos = linea.Split(',');
            return new Cliente2(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9]);
        }
    }
}
