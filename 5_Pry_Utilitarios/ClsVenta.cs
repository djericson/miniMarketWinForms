using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsVenta
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        public int IdCajeto { get; set; }

        public int IdAyudante { get; set; }

        public int NumeroOperacion { get; set; }

        public DateTime FechaVenta { get; set; }

        public double PrecioTotal { get; set; }

        public string DetalleVenta { get; set; }
    }

}
