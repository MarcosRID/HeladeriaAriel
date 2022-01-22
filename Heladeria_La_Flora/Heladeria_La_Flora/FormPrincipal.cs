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
    public partial class FormPrincipal : Form
    {
        public Heladeria HeladeriaLaFlora;
        private List<Producto> listaProductosCliente;
        private List<Producto> listaDeVentasProductosDelDia;
        private List<Producto> listaProductosServiciosAbonados;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            this.HeladeriaLaFlora = new Heladeria();
            this.listaProductosCliente = new List<Producto>();
            this.listaDeVentasProductosDelDia = new List<Producto>();
            this.listaProductosServiciosAbonados = new List<Producto>();

            HeladeriaLaFlora = Archivos<Heladeria>.Deserializar(@"C:\Users\Usuario\Desktop\Nueva carpeta (3)\archivo.xml");

            this.lblVenta.ForeColor = Color.Green;
            this.lblCompra.ForeColor = Color.Red;
            this.btnCompra.Visible = false;
            this.lblCostoFactura.Visible = false;
            this.txtCostoFactura.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dtgCliente.RowCount != 0 && this.dtgCliente.SelectedRows is not null)
            {
                this.listaProductosCliente -= (Producto)this.dtgCliente.CurrentRow.DataBoundItem;
                this.dtgCliente.DataSource = null;
                this.dtgCliente.DataSource = this.listaProductosCliente;
            }
            else if (this.dtgVentaDelDia.RowCount != 0 && this.dtgVentaDelDia.SelectedRows is not null)
            {

                this.listaDeVentasProductosDelDia -= (Producto)this.dtgVentaDelDia.CurrentRow.DataBoundItem;
                this.dtgVentaDelDia.DataSource = null;
                this.dtgVentaDelDia.DataSource = this.listaDeVentasProductosDelDia;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoStg = this.txtCodigo.Text;
                int codigoInt;

                if (!Validaciones.StringIsNullEmptyWhite(codigoStg) && int.TryParse(codigoStg, out codigoInt))
                {
                    Producto productoSeleccionado = HeladeriaLaFlora | codigoInt;

                    if (productoSeleccionado is not null)
                    {

                        this.listaProductosCliente.Add(productoSeleccionado);
                        this.dtgCliente.DataSource = null;
                        this.dtgCliente.DataSource = this.listaProductosCliente;

                        this.txtTotalCliente.Text = Producto.CalcularPrecio(this.listaProductosCliente).ToString();
                    }
                }


            }
            catch (Exception ex)
            { }

        }

        private void chbVentaCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbVentaCompra.CheckState == CheckState.Checked)
            {

                this.btnVenta.Visible = true;
                this.lblVenta.ForeColor = Color.Green;

                this.btnCompra.Visible = false;
                this.lblCostoFactura.Visible = false;
                this.txtCostoFactura.Visible = false;
                this.lblCompra.ForeColor = Color.Red;
            }
            else if (this.chbVentaCompra.CheckState == CheckState.Unchecked)
            {


                this.btnVenta.Visible = false;
                this.lblVenta.ForeColor = Color.Red;

                this.btnCompra.Visible = true;
                this.lblCostoFactura.Visible = true;
                this.txtCostoFactura.Visible = true;
                this.lblCompra.ForeColor = Color.Green;
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

            string codigoStg = this.txtCodigo.Text;
            int codigoInt = 0;
            int.TryParse(codigoStg, out codigoInt);

            if (Validaciones.StringIsNullEmptyWhite(codigoStg))
            {
                try
                {
                    FormNuevoServicio formNuevoServicio = new FormNuevoServicio(this);

                    formNuevoServicio.ShowDialog();

                }
                catch (Exception ex)
                {}

            }
            else
            {
                double precio;

                foreach (Producto item in this.HeladeriaLaFlora.ListaServicios)
                {
                    if (item == codigoInt && double.TryParse(this.txtCostoFactura.Text, out precio))
                    {
                        Producto producto = item;
                        producto.Precio = (-precio);
                        listaProductosServiciosAbonados.Add(producto);

                        this.listaDeVentasProductosDelDia.AddRange(this.listaProductosServiciosAbonados);
                        this.dtgVentaDelDia.DataSource = null;
                        this.dtgVentaDelDia.DataSource = this.listaDeVentasProductosDelDia;
                        this.txtTotalDelDia.Text = Producto.CalcularPrecio(this.listaDeVentasProductosDelDia).ToString();

                    }

                }

            }

        }

        private void dtgCliente_Click(object sender, EventArgs e)
        {
            this.dtgVentaDelDia.ClearSelection();
        }

        private void dtgVentaDelDia_Click(object sender, EventArgs e)
        {

            this.dtgCliente.ClearSelection();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {

                this.listaDeVentasProductosDelDia.AddRange(this.listaProductosCliente);
                this.dtgVentaDelDia.DataSource = null;
                this.dtgVentaDelDia.DataSource = this.listaDeVentasProductosDelDia;
                this.txtTotalDelDia.Text = Producto.CalcularPrecio(this.listaDeVentasProductosDelDia).ToString();

                this.dtgCliente.DataSource = null;
                this.txtTotalCliente.Text = null;
                this.listaProductosCliente.Clear();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnGestionarTienda_Click(object sender, EventArgs e)
        {
            try
            {
                FormStock formStock = new FormStock(this);

                formStock.ShowDialog();

            }
            catch (Exception ex)
            { }

        }
    }
}
