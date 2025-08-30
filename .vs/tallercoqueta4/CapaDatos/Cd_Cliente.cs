using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace CapaDatos
{
    public class Cd_Cliente
    {
        //instanciar un objeto de tipo cliente
        private Cliente cliente = new Cliente();

        //indicar cual es la ruta y el archivo donde se almacenaran los datos
        private string ruta = @"C:\Users\Roland\Documents\GitHub\tallercoqueta4\Registro.txt";

        //Registrar un cliente
        public void RegistrarCliente(Cliente cliente)
        {
            string carpeta = Path.GetDirectoryName(ruta);
            if(!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            //appendAllText crea el archivo si no existe
            File.AppendAllText(ruta, cliente.LineaArchivo() + Environment.NewLine);
        }
    
    //buscar cliente por id
    public List<Cliente> BuscarCliente(string id)
    {
            var lista = new List<Cliente>();
            if (!File.Exists(ruta))
                return lista;

            var lineas = File.ReadAllLines(ruta);
            foreach(var linea in lineas)
            {
                var cli = cliente.SepararLinea(linea);
                if (cli.Id == id)
                lista.Add(cliente.SepararLinea(linea));
            }
            return lista;
        
    }
        //listar todos los clientes
        public List<Cliente> ListarClientes()
        {
            var lista = new List<Cliente>();
            if (!File.Exists(ruta))
                return lista;
            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                lista.Add(cliente.SepararLinea(linea));
            }
            return lista;
        }
    }
}