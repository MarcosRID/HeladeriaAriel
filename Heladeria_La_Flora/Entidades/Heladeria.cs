using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Heladeria
    {


        #region Atributos / Propiedades


        private string nombre;
        private List<Producto> listaProductos;
        private List<Producto> listaProductosServiciosAbonados;

        public string Nombre
        {
            get
            { return this.nombre; }
            set
            { this.nombre = value; }
        }

         
        public List<Producto> ListaProductos
        {
            get
            { return this.listaProductos; }
            set
            { this.listaProductos = value; }
        }

        public List<Producto> ListaServicios
        {
            get
            { return this.listaProductosServiciosAbonados; }
            set
            { this.listaProductosServiciosAbonados= value; }
        }



        #endregion



        #region Ctor

        public Heladeria()
        {
            this.listaProductos = new List<Producto>();
        }

        public Heladeria(string nombre, List<Producto> listaProductos,  List<Producto> listaServicios) : this()
        {
            this.nombre = nombre;
            this.listaProductos = listaProductos;
            this.listaProductosServiciosAbonados = listaServicios;
        }

        #endregion



        #region Sobrecargas / Override


        public static Producto operator |( Heladeria heladeria, int codigo)
        {
            Producto producto;

            try
            {
                foreach (Producto item in heladeria.listaProductos)
                {
                    if (item.Codigo == codigo)
                    {
                        return item;
                    }
                }


            }
            catch (Exception ex)
            {
                return null;
            }

            
            return null; 
        }
       


        public static bool operator ==(int codigo, Heladeria heladeria)
        {

            try
            {
                foreach (Producto item in heladeria.listaProductos)
                {
                    if (codigo == item.Codigo)
                    {
                        return true;
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                return false;
            }
            return false;
        }

        public static bool operator !=(int codigo, Heladeria heladeria)
        { return !(codigo == heladeria); }

        public static bool operator ==(string codigoString, Heladeria heladeria)
        {
            int codigo;

            if (int.TryParse(codigoString, out codigo))
            {
                return codigo == heladeria;
            }

            return false;
        }

        public static bool operator !=(string codigoString, Heladeria heladeria)
        { return !(codigoString == heladeria); }




        #endregion
    }
}
