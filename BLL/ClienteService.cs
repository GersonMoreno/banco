using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class ClienteService
    {
        private readonly ClienteRepository clienteRepository;
        public ClienteService()
        {
            clienteRepository = new ClienteRepository();
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return "No existe el cliente";
                if ( String.IsNullOrEmpty(cliente.Nombre.Trim()))
                    return "El nombre del cliente es obligatorio";
                if (String.IsNullOrEmpty(cliente.Cedula.Trim()))
                    return "La cedula del cliente es obligatorio";
                if (cliente.Saldo <= 0)
                    return "El saldo debe ser mayor que 0";
                cliente.Id = BD.Clientes.Any() ? BD.Clientes.LastOrDefault().Id + 1  : 1;
                clienteRepository.Guardar(cliente);
                return "Se guardo el cliente correctamente";
            }
            catch (Exception e)
            {

                return "Error: "+e.Message;
            }
            
        }
        public List<Cliente> TodosCLientes()
        {
            return clienteRepository.TodosCLientes();
        }
    }
}
