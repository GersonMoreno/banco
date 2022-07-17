using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace DAL
{
    public class ClienteRepository
    {
        public ClienteRepository()
        {

        }
        public  void Guardar(Cliente Cliente)
        {
            BD.Clientes.Add(Cliente);
        }
        public List<Cliente> TodosCLientes()
        {
            return BD.Clientes;
        }
        public Cliente UnCLiente(string cedula)
        {
            return BD.Clientes.FirstOrDefault(x => x.Cedula.Equals(cedula));
        }
    }
}
