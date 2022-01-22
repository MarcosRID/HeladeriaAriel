using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Heladeria_La_Flora
{
    public partial class FormProductoNuevo : Form
    {
        FormPrincipal formPrincipalPadre;

        public FormProductoNuevo(FormPrincipal formPrincipal)
        {

            InitializeComponent();
            formPrincipalPadre = formPrincipal;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                int codigo;
                double precio;

                if (int.TryParse(this.txtCodigo.Text, out codigo) && double.TryParse(this.txtPrecio.Text, out precio) && !Validaciones.StringIsNullEmptyWhite(this.txtNombre.Text) && (formPrincipalPadre.HeladeriaLaFlora | codigo) is null)
                {

                    Producto newProducto = new Producto(this.txtNombre.Text, codigo, precio);

                    formPrincipalPadre.HeladeriaLaFlora.ListaProductos.Add(newProducto);

                    Archivos<Heladeria>.Serializar(formPrincipalPadre.HeladeriaLaFlora, @"C:\Users\Usuario\Desktop\Nueva carpeta (3)\archivo");
                }



            }
            catch (Exception ex)
            {



            }
            finally
            {

                this.Close();
            
            }

        }

        private void FormProductoNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
