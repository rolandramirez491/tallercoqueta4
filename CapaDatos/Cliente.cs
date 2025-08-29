using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }

        public Cliente() { }
        public Cliente(string id, string nombre, string apellido, string edad, string cargo, string salario)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            Salario = salario;
        }
        //metodo para convertir a linea del archivo plano
        public string LineaArchivo()
        {
            return $"{Id}|{Nombre}|{Apellido}|{Edad}|{Cargo}|{Salario}";
        }
        public Cliente SepararLinea(string linea)
        {
            string[] datos = linea.Split('|');
            return new Cliente(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
        }
    }
}
