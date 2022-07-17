using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class TransaccionRepository
    {
        public TransaccionRepository()
        {

        }
        public void Guardar(Transaccion transaccion)
        {
            BD.Transaciones.Add(transaccion);
        }
        public List<Transaccion> TodasTransaccionesDia(DateTime fecha) {
            return BD.Transaciones.Where(x => x.Fecha == fecha).ToList();
        }
        public List<Transaccion> TodasTrancionesCliente(string cedula)
        {
            return BD.Transaciones.Where(x => x.Cliente.Cedula.Equals(cedula)).ToList();
        }
        public Transaccion UnaTransaccion(int id)
        {
            return BD.Transaciones.FirstOrDefault(x => x.Id == id);
        }
    }
}
