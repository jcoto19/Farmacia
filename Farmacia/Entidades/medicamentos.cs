using System;

namespace Farmacia.Entidades
{
    public class Medicamentos
    {

        //Atributos de la clase de Medicamentos
        private string id;
        private string nombre;
        private string descripcion;
        private string fecha_ingreso;
        private double precio_unitario;
        private int cantidad;
        private double precio_total;

        public Medicamentos() //Constructor vacio para instanciar a la clase sin necesidad de parsaele todos sus atributos por parametro
        {
        }

        //Constructor con todos sus atributos por parametro 
        public Medicamentos(string id, string nombre, string descripcion, string fecha_ingreso, double precio_unitario, int cantidad, double precio_total)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha_ingreso = fecha_ingreso;
            this.precio_unitario = precio_unitario;
            this.cantidad = cantidad;
            this.precio_total = precio_total;
        }

        //Getter and Setters
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public string Fecha_ingreso
        {
            get
            {
                return fecha_ingreso;
            }
            set
            {
                fecha_ingreso = value;
            }
        }

        public double Precio_unitario
        {
            get
            {
                return precio_unitario;
            }
            set
            {
                precio_unitario = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public double Precio_total
        {
            get
            {
                return precio_total;
            }
            set
            {
                precio_total = value;
            }
        }
    }
}