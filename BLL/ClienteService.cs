using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public class ClienteService
    {
        public ClienteService()
        {

        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return "No existe el cliente";
                if (cliente.Nombre.Trim().Equals(string.Empty) || cliente.Nombre == null)
                    return "El nombre del cliente es obligatorio";
                if (cliente.Cedula.Trim().Equals(string.Empty) || cliente.Cedula == null)
                    return "La cedula del cliente es obligatorio";
            }
            catch (Exception e)
            {

                throw;
            }
            
        }
    }
}
