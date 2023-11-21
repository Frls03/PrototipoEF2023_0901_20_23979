using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_PrototipoMenu;

namespace Controlador_PrototipoMenu
{
    class Controlador
    {
        private Sentencias sen;
        public void InsertarReserva(string asientos, string subtotal, string factura)
        {
            sen.InsertarReserva(asientos, subtotal, factura);
        }

    }
}
