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
    public partial class FormStock : Form
    {
        FormPrincipal formPrincipalPadre;

        public FormStock(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalPadre = formPrincipal;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {

            dtgInventario.DataSource = formPrincipalPadre.HeladeriaLaFlora.ListaProductos;
            this.btnGuardarCambios.Text = "Editar Producto";
            this.txtNewNombre.Visible = false;
            this.lblNewNombre.Visible = false;
            this.txtNewCodigo.Visible = false;
            this.lblNewCodigo.Visible = false;
            this.txtNewPrecio.Visible = false;
            this.lblNewPrecio.Visible = false;
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {

            FormProductoNuevo formProductoNuevo = new FormProductoNuevo(formPrincipalPadre);

            try
            {
                formProductoNuevo.ShowDialog();
            }
            catch (Exception ex)
            { }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.btnGuardarCambios.Text.Equals("Editar Producto"))
            {
                this.btnGuardarCambios.Text = "Guardar Cambios";
                this.txtNewNombre.Visible = true;
                this.lblNewNombre.Visible = true;
                this.txtNewCodigo.Visible = true;
                this.lblNewCodigo.Visible = true;
                this.lblNewPrecio.Visible = true;
                this.txtNewPrecio.Visible = true;

            }
            else if (this.btnGuardarCambios.Text.Equals("Guardar Cambios"))
            {

                Producto productoEditado = (Producto)this.dtgInventario.CurrentRow.DataBoundItem;
      
                string[] editProducto = new string[3];

                editProducto[0] = this.txtNewNombre.Text;
                editProducto[1] = this.txtNewCodigo.Text;
                editProducto[2] = this.txtNewPrecio.Text;

                if (Validaciones.StringIsNullEmptyWhite(editProducto[0])
                    || Validaciones.StringIsNullEmptyWhite(editProducto[1])
                    || Validaciones.StringIsNullEmptyWhite(editProducto[2]))
                {
                    this.lblMensaje.Text = "Algunos de los campos esta vacio";
                    this.lblMensaje.ForeColor = Color.Red;
                }
                else
                {
                    int codigo = 0;
                    double precio = 0;

                    if (int.TryParse(this.txtNewCodigo.Text, out codigo)
                        && double.TryParse(this.txtNewPrecio.Text, out precio))
                    {

                        foreach (Producto item in formPrincipalPadre.HeladeriaLaFlora.ListaProductos)
                        {
                            if (item == productoEditado)
                            {
                                item.Nombre = this.txtNewNombre.Text;
                                item.Codigo = codigo;
                                item.Precio = precio;
                                this.dtgInventario.DataSource = null;
                                this.dtgInventario.DataSource = formPrincipalPadre.HeladeriaLaFlora.ListaProductos;
                                Archivos<Heladeria>.Serializar(formPrincipalPadre.HeladeriaLaFlora, @"C:\Users\Usuario\Desktop\Nueva carpeta (3)\archivo");
                                break;
                            }
                        }

                        this.btnGuardarCambios.Text = "Editar Producto";
                        this.txtNewNombre.Visible = false;
                        this.lblNewNombre.Visible = false;
                        this.txtNewCodigo.Visible = false;
                        this.lblNewCodigo.Visible = false;
                        this.txtNewPrecio.Visible = false;
                        this.lblNewPrecio.Visible = false;


                    }

                }
            }
        }

        private void txtNewPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgInventario_Click(object sender, EventArgs e)
        {
            if (this.btnGuardarCambios.Text.Equals("Guardar Cambios"))
            {
                Producto productoEditado = (Producto)this.dtgInventario.CurrentRow.DataBoundItem;
                this.txtNewNombre.Text = productoEditado.Nombre;
                this.txtNewCodigo.Text = productoEditado.Codigo.ToString();
                this.txtNewPrecio.Text = productoEditado.Precio.ToString();

            }
        }
    }
}
