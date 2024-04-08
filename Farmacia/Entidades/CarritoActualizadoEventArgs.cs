using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Farmacia.ventana_farmacia;

namespace Farmacia.Entidades
{
    public class CarritoActualizadoEventArgs : EventArgs
    {
        public List<MedicamentoEnCarrito> Carrito { get; }

        public CarritoActualizadoEventArgs(List<MedicamentoEnCarrito> carrito)
        {
            Carrito = carrito;
        }
    }
}
