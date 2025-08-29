using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Clientes
    {
        //instanciar un objeto de la clase CD_Clientes
        private Cd_Cliente objCD = new Cd_Cliente();
        //invocar los metodos
        public void RegistrarCliente(string id,string nombre,string apellido,string,string edad, string cargo, string salario)
            {
            Cliente cliente = new Cliente
                {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Cargo = cargo,
                Salario = salario
            };
            objCD.RegistrarCliente(cliente);
        }

        public List<object> BuscarClientes(string id)
        {
            List<object> listaClientes = new List<object>();
            //foreach (var cliente in objCD.BuscarCliente(id))
            //{
            //    listaClientes.Add(new
            //    {
            //        Id = cliente.Id,
            //        Nombre = cliente.Nombre,
            //        Apellido = cliente.Apellido,
            //        Edad = cliente.Edad,
            //        Cargo = cliente.Cargo,
            //        Salario = cliente.Salario
            //    });
            //}
            foreach (var cliente in objCD.BuscarCliente(id))
            {
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        public List<object> ListarClientes()
        {
            List<object> listaClientes = new List<object>();
            foreach (var cliente in objCD.ListarClientes())
            {
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }
    }
}
