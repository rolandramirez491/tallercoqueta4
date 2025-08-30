using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cliente2
    {
        //instanciar un objeto de la clase CD_Clientes
        private Cd_Cliente2 objCD2 = new Cd_Cliente2();
        //invocar los metodos
        public void RegistrarCliente2(string id,string nombre,string apellido,string edad, string cargo, string salario,string salud,string pension,string auxiliotransporte,string salarioneto)
            {
            Cliente2 cliente2 = new Cliente2
                {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Cargo = cargo,
                Salario = salario,
                Salud=salud,
                Pension=pension,
                Auxiliotransporte=auxiliotransporte,
                Salarioneto= salarioneto
            };
            objCD2.RegistrarCliente2(cliente2);
        }

        public List<object> BuscarClientes2(string id)
        {
            List<object> listaClientes2 = new List<object>();
            foreach (var cliente2 in objCD2.BuscarCliente2(id))
            {
                listaClientes2.Add(new
                {
                    Id = cliente2.Id,
                    Nombre = cliente2.Nombre,
                    Apellido = cliente2.Apellido,
                    Edad = cliente2.Edad,
                    Cargo = cliente2.Cargo,
                    Salario = cliente2.Salario,
                    Salud= cliente2.Salud,
                    Pension= cliente2.Pension,
                    Auxiliotransporte= cliente2.Auxiliotransporte,
                    Salarioneto= cliente2.Salarioneto
                });
            }
            foreach (var cliente2 in objCD2.BuscarCliente2(id))
            {
                listaClientes2.Add(cliente2);
            }
            return listaClientes2;
        }

        public List<object> ListarClientes2()
        {
            List<object> listaClientes2 = new List<object>();
            foreach (var cliente2 in objCD2.ListarClientes2())
            {
                listaClientes2.Add(cliente2);
            }
            return listaClientes2;
        }
    }
}
