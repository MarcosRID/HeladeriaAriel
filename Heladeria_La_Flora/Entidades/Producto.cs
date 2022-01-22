using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        #region Atributos / Propiedades


        private string nombre;
        private int codigo;
        private double precio;

        public string Nombre
        {
            get
            { return this.nombre; }
            set
            { this.nombre = value; }
        }

        public int Codigo
        {
            get
            { return this.codigo; }
            set
            { this.codigo = value; }
        }

        public double Precio
        {
            get
            { return this.precio; }
            set
            { this.precio = value; }
        }


        #endregion

        #region Ctor

        public Producto()
        {

        }
   
        public Producto(string nombre, int codigo, double precio)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
        }

        #endregion

        #region Metodos

        public static double CalcularPrecio(List<Producto> listaProductos)
        {
            double total = 0;

            if (listaProductos is not null)
            {
                foreach (Producto item in listaProductos)
                {
                    total += item.precio;
                }
            }

            return total;
        }

        #endregion

        #region Sobrecargar / override


        public static List<Producto> operator -(List<Producto> listaProductos, Producto producto)
        {

            try
            {

                if (listaProductos is not null && producto is not null)
                {
                    listaProductos.Remove(producto);
                }

            }
            catch (Exception ex)
            {

            }

            return listaProductos;

        }

        public static bool operator ==(Producto producto, int codigo)
        {
            return (producto is not null && codigo > 0) && producto.codigo == codigo;
        }
        public static bool operator !=(Producto producto, int codigo)
        { return !(producto == codigo); }

       
        #endregion
    }
}
