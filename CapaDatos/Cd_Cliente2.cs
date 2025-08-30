using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace CapaDatos
{
    public class Cd_Cliente2
    {
        //instanciar un objeto de tipo cliente
        private Cliente2 cliente2 = new Cliente2();

        //indicar cual es la ruta y el archivo donde se almacenaran los datos
        private string ruta2 = @"C:\Users\Roland\Documents\GitHub\tallercoqueta4\Nomina.txt";

        //Registrar un cliente
        public void RegistrarCliente2(Cliente2 cliente2)
        {
            string carpeta = Path.GetDirectoryName(ruta2);
            if(!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            //appendAllText crea el archivo si no existe
            File.AppendAllText(ruta2, cliente2.LineaArchivo2() + Environment.NewLine);
        }
    
    //buscar cliente por id
    public List<Cliente2> BuscarCliente2(string id)
    {
            var lista2 = new List<Cliente2>();
            if (!File.Exists(ruta2))
                return lista2;

            var lineas = File.ReadAllLines(ruta2);
            foreach(var linea in lineas)
            {
                var cli = cliente2.SepararLinea2(linea);
                if (cli.Id == id)
                lista2.Add(cliente2.SepararLinea2(linea));
            }
            return lista2;
        
    }
        //listar todos los clientes
        public List<Cliente2> ListarClientes2()
        {
            var lista2 = new List<Cliente2>();
            if (!File.Exists(ruta2))
                return lista2;
            var lineas = File.ReadAllLines(ruta2);
            foreach (var linea in lineas)
            {
                lista2.Add(cliente2.SepararLinea2(linea));
            }
            return lista2;
        }
    }
}