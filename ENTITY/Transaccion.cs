using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Transaccion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Transaccion()
        {
            Cliente = new Cliente();
        }
    }
}
