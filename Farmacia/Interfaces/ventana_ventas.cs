using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Farmacia.ventana_farmacia;

namespace Farmacia
{
    public partial class ventana_ventas : Form
    {

        private ventana_farmacia farmacia;
        public event EventHandler<CarritoActualizadoEventArgs> CarritoActualizado;

        public ventana_ventas(ventana_farmacia farmacia)
        {
            InitializeComponent();
            this.farmacia = farmacia;
            farmacia.CarritoActualizado += Farmacia_CarritoActualizado;

            /*dgv_factura.Columns.Add("Id", "ID");
            dgv_factura.Columns.Add("Nombre", "Nombre");
            dgv_factura.Columns.Add("Cantidad", "Cantidad");
            dgv_factura.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgv_factura.Columns.Add("Total", "Total");*/
        }
                
        private void Farmacia_CarritoActualizado(object sender, CarritoActualizadoEventArgs e)
        {
            dgv_factura.DataSource = null;
            dgv_factura.DataSource = e.Carrito;
        }

        // Método para mostrar los elementos del carrito en la interfaz de usuario
        public void MostrarCarrito(List<MedicamentoEnCarrito> carrito)
        {
            // Limpiar la lista actual de elementos del carrito en la interfaz de usuario
            dgv_factura.Rows.Clear();

            // Agregar cada medicamento del carrito a la lista en la interfaz de usuario
            foreach (var medicamento in carrito)
            {
                dgv_factura.Rows.Add(medicamento.Id, medicamento.Nombre, medicamento.Cantidad, medicamento.PrecioUnitario, medicamento.Total);
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {


        }

        public void MostrarDatosDelCarrito(List<MedicamentoEnCarrito> carrito)
        {
            // Limpiar la tabla antes de agregar nuevos datos
            dgv_factura.Rows.Clear();

            // Agregar cada medicamento del carrito a la tabla
            foreach (MedicamentoEnCarrito item in carrito)
            {
                dgv_factura.Rows.Add(item.Id, item.Nombre, item.Cantidad, item.PrecioUnitario, item.Total);
            }
        }

        private void bt_agregarCliente_Click(object sender, EventArgs e)
        {
            ventana_agregar formAgregarCliente = new ventana_agregar();
            formAgregarCliente.ShowDialog();
        }
    }
}
