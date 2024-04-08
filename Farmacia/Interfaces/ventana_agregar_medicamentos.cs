using System;
using System.Windows.Forms;

namespace Farmacia.Interfaces
{
    public partial class ventana_agregar_medicamentos : Form
    {
        public ventana_agregar_medicamentos(string id, string nombre, string descripcion, double precio, int cantidad, string fecha)
        {
            InitializeComponent();

            //Asignamos los valores del registro que seleccionamos 
            txt_nombre.Text = nombre;
            txt_id.Text = id;
            txt_descripcion.Text = descripcion;
            txt_cantidad.Text = cantidad.ToString();
            txt_precio.Text = precio.ToString();
            txt_fecha.Text = fecha;
        }

        private void bt_calcular_venta_Click(object sender, EventArgs e)
        {
            if (txt_cantidad_agregar.Value != 0)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Agregue la cantidad de productos a guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] pedirDatos() //Se usara en la ventana de ventana_farmacia para saber el id, cantidad vendida y el precio final
        {
            string[] lista = new string[2];
            lista[0] = txt_id.Text;
            lista[1] = string.Concat(txt_cantidad_agregar.Value);

            return lista;
        }

        private void ventana_agregar_medicamentos_Load(object sender, EventArgs e)
        {

        }

        private void bt_salir_Click_1(object sender, EventArgs e)
        {
            //No almacena ningun dato que registra el usuario y lo cierra por completo sin afectar al principal
            this.Close();
            txt_nombre.Text = "";
            txt_id.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
            txt_precio.Text = "";
            txt_fecha.Text = "";
            txt_cantidad_agregar.Value = 0;
        }

        private void ventana_agregar_medicamentos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
