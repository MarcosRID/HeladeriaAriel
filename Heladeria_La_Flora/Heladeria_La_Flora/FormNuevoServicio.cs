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
    public partial class FormNuevoServicio : Form
    {
        FormPrincipal formPrincipalPadre;

        public FormNuevoServicio(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalPadre = formPrincipal;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo;

            if (int.TryParse(this.txtCodigo.Text, out codigo))
            {

                formPrincipalPadre.HeladeriaLaFlora.ListaServicios.Add(new Producto(this.txtNombre.Text, codigo, 0));

            }

        }
    }
}
