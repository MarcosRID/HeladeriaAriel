
namespace Heladeria_La_Flora
{
    partial class FormStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNewNombre = new System.Windows.Forms.TextBox();
            this.txtNewPrecio = new System.Windows.Forms.TextBox();
            this.txtNewCodigo = new System.Windows.Forms.TextBox();
            this.lblNewPrecio = new System.Windows.Forms.Label();
            this.lblNewNombre = new System.Windows.Forms.Label();
            this.lblNewCodigo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInventario
            // 
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Location = new System.Drawing.Point(12, 64);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.RowTemplate.Height = 25;
            this.dtgInventario.Size = new System.Drawing.Size(341, 383);
            this.dtgInventario.TabIndex = 0;
            this.dtgInventario.Click += new System.EventHandler(this.dtgInventario_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(682, 342);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(134, 23);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnAgragar
            // 
            this.btnAgragar.Location = new System.Drawing.Point(12, 453);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(126, 24);
            this.btnAgragar.TabIndex = 2;
            this.btnAgragar.Text = "Nuevo Producto";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarrito.Location = new System.Drawing.Point(545, 64);
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.RowTemplate.Height = 25;
            this.dtgCarrito.Size = new System.Drawing.Size(271, 272);
            this.dtgCarrito.TabIndex = 3;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(545, 342);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(131, 23);
            this.btnAgregarCarrito.TabIndex = 4;
            this.btnAgregarCarrito.Text = "Añadir al Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.Location = new System.Drawing.Point(12, 27);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(123, 23);
            this.lblInventario.TabIndex = 5;
            this.lblInventario.Text = "Inventario";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.Location = new System.Drawing.Point(545, 27);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(93, 23);
            this.lblCarrito.TabIndex = 6;
            this.lblCarrito.Text = "Carrito";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(359, 423);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(110, 24);
            this.btnGuardarCambios.TabIndex = 7;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(682, 380);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtNewNombre
            // 
            this.txtNewNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNewNombre.Location = new System.Drawing.Point(359, 286);
            this.txtNewNombre.Name = "txtNewNombre";
            this.txtNewNombre.Size = new System.Drawing.Size(110, 23);
            this.txtNewNombre.TabIndex = 9;
            this.txtNewNombre.Text = "Nombre";
            this.txtNewNombre.TextChanged += new System.EventHandler(this.txtNewNombre_TextChanged);
            // 
            // txtNewPrecio
            // 
            this.txtNewPrecio.Location = new System.Drawing.Point(359, 380);
            this.txtNewPrecio.Name = "txtNewPrecio";
            this.txtNewPrecio.Size = new System.Drawing.Size(110, 23);
            this.txtNewPrecio.TabIndex = 10;
            this.txtNewPrecio.Text = "Precio";
            this.txtNewPrecio.TextChanged += new System.EventHandler(this.txtNewPrecio_TextChanged);
            // 
            // txtNewCodigo
            // 
            this.txtNewCodigo.Location = new System.Drawing.Point(359, 332);
            this.txtNewCodigo.Name = "txtNewCodigo";
            this.txtNewCodigo.Size = new System.Drawing.Size(110, 23);
            this.txtNewCodigo.TabIndex = 11;
            this.txtNewCodigo.Text = "Codigo";
            this.txtNewCodigo.TextChanged += new System.EventHandler(this.txtNewCodigo_TextChanged);
            // 
            // lblNewPrecio
            // 
            this.lblNewPrecio.AutoSize = true;
            this.lblNewPrecio.Location = new System.Drawing.Point(359, 362);
            this.lblNewPrecio.Name = "lblNewPrecio";
            this.lblNewPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblNewPrecio.TabIndex = 12;
            this.lblNewPrecio.Text = "Precio";
            // 
            // lblNewNombre
            // 
            this.lblNewNombre.AutoSize = true;
            this.lblNewNombre.Location = new System.Drawing.Point(359, 268);
            this.lblNewNombre.Name = "lblNewNombre";
            this.lblNewNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNewNombre.TabIndex = 13;
            this.lblNewNombre.Text = "Nombre";
            // 
            // lblNewCodigo
            // 
            this.lblNewCodigo.AutoSize = true;
            this.lblNewCodigo.Location = new System.Drawing.Point(359, 314);
            this.lblNewCodigo.Name = "lblNewCodigo";
            this.lblNewCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblNewCodigo.TabIndex = 14;
            this.lblNewCodigo.Text = "Codigo";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(475, 428);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 15);
            this.lblMensaje.TabIndex = 15;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 485);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblNewCodigo);
            this.Controls.Add(this.lblNewNombre);
            this.Controls.Add(this.lblNewPrecio);
            this.Controls.Add(this.txtNewCodigo);
            this.Controls.Add(this.txtNewPrecio);
            this.Controls.Add(this.txtNewNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.dtgCarrito);
            this.Controls.Add(this.btnAgragar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dtgInventario);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInventario;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.DataGridView dtgCarrito;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNewNombre;
        private System.Windows.Forms.TextBox txtNewPrecio;
        private System.Windows.Forms.TextBox txtNewCodigo;
        private System.Windows.Forms.Label lblNewPrecio;
        private System.Windows.Forms.Label lblNewNombre;
        private System.Windows.Forms.Label lblNewCodigo;
        private System.Windows.Forms.Label lblMensaje;
    }
}