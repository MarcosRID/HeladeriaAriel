
namespace Heladeria_La_Flora
{
    partial class FormPrincipal
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
            this.dtgVentaDelDia = new System.Windows.Forms.DataGridView();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnGestionarTienda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTotalDelDia = new System.Windows.Forms.TextBox();
            this.txtTotalCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblCostoFactura = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTotalCliente = new System.Windows.Forms.Label();
            this.lblTotalDelDia = new System.Windows.Forms.Label();
            this.lblVentaDelDia = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtCostoFactura = new System.Windows.Forms.TextBox();
            this.chbVentaCompra = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaDelDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentaDelDia
            // 
            this.dtgVentaDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaDelDia.Location = new System.Drawing.Point(620, 55);
            this.dtgVentaDelDia.Name = "dtgVentaDelDia";
            this.dtgVentaDelDia.RowTemplate.Height = 25;
            this.dtgVentaDelDia.Size = new System.Drawing.Size(303, 399);
            this.dtgVentaDelDia.TabIndex = 0;
            this.dtgVentaDelDia.Click += new System.EventHandler(this.dtgVentaDelDia_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(199, 55);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.RowTemplate.Height = 25;
            this.dtgCliente.Size = new System.Drawing.Size(303, 399);
            this.dtgCliente.TabIndex = 1;
            this.dtgCliente.Click += new System.EventHandler(this.dtgCliente_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(12, 65);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(75, 23);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(113, 65);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 3;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnGestionarTienda
            // 
            this.btnGestionarTienda.Location = new System.Drawing.Point(78, 199);
            this.btnGestionarTienda.Name = "btnGestionarTienda";
            this.btnGestionarTienda.Size = new System.Drawing.Size(110, 23);
            this.btnGestionarTienda.TabIndex = 5;
            this.btnGestionarTienda.Text = "Gestionar/Tienda";
            this.btnGestionarTienda.UseVisualStyleBackColor = true;
            this.btnGestionarTienda.Click += new System.EventHandler(this.btnGestionarTienda_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(508, 413);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(377, 469);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(98, 24);
            this.btnRealizarVenta.TabIndex = 7;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 104);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(96, 23);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtTotalDelDia
            // 
            this.txtTotalDelDia.Location = new System.Drawing.Point(723, 471);
            this.txtTotalDelDia.Name = "txtTotalDelDia";
            this.txtTotalDelDia.Size = new System.Drawing.Size(100, 23);
            this.txtTotalDelDia.TabIndex = 9;
            // 
            // txtTotalCliente
            // 
            this.txtTotalCliente.Location = new System.Drawing.Point(271, 470);
            this.txtTotalCliente.Name = "txtTotalCliente";
            this.txtTotalCliente.Size = new System.Drawing.Size(100, 23);
            this.txtTotalCliente.TabIndex = 10;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(318, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblVenta.Location = new System.Drawing.Point(24, 34);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(49, 20);
            this.lblVenta.TabIndex = 12;
            this.lblVenta.Text = "Venta";
            // 
            // lblCostoFactura
            // 
            this.lblCostoFactura.AutoSize = true;
            this.lblCostoFactura.Location = new System.Drawing.Point(1, 155);
            this.lblCostoFactura.Name = "lblCostoFactura";
            this.lblCostoFactura.Size = new System.Drawing.Size(86, 15);
            this.lblCostoFactura.TabIndex = 13;
            this.lblCostoFactura.Text = "Costo Factura :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 107);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 15);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblTotalCliente
            // 
            this.lblTotalCliente.AutoSize = true;
            this.lblTotalCliente.Location = new System.Drawing.Point(221, 474);
            this.lblTotalCliente.Name = "lblTotalCliente";
            this.lblTotalCliente.Size = new System.Drawing.Size(38, 15);
            this.lblTotalCliente.TabIndex = 15;
            this.lblTotalCliente.Text = "Total :";
            // 
            // lblTotalDelDia
            // 
            this.lblTotalDelDia.AutoSize = true;
            this.lblTotalDelDia.Location = new System.Drawing.Point(679, 475);
            this.lblTotalDelDia.Name = "lblTotalDelDia";
            this.lblTotalDelDia.Size = new System.Drawing.Size(38, 15);
            this.lblTotalDelDia.TabIndex = 16;
            this.lblTotalDelDia.Text = "Total :";
            // 
            // lblVentaDelDia
            // 
            this.lblVentaDelDia.AutoSize = true;
            this.lblVentaDelDia.Location = new System.Drawing.Point(756, 28);
            this.lblVentaDelDia.Name = "lblVentaDelDia";
            this.lblVentaDelDia.Size = new System.Drawing.Size(80, 15);
            this.lblVentaDelDia.TabIndex = 17;
            this.lblVentaDelDia.Text = "Ventas del Dia";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCompra.Location = new System.Drawing.Point(113, 33);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(64, 20);
            this.lblCompra.TabIndex = 18;
            this.lblCompra.Text = "Compra";
            // 
            // txtCostoFactura
            // 
            this.txtCostoFactura.Location = new System.Drawing.Point(93, 147);
            this.txtCostoFactura.Name = "txtCostoFactura";
            this.txtCostoFactura.Size = new System.Drawing.Size(95, 23);
            this.txtCostoFactura.TabIndex = 19;
            // 
            // chbVentaCompra
            // 
            this.chbVentaCompra.AutoSize = true;
            this.chbVentaCompra.Checked = true;
            this.chbVentaCompra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVentaCompra.Location = new System.Drawing.Point(92, 39);
            this.chbVentaCompra.Name = "chbVentaCompra";
            this.chbVentaCompra.Size = new System.Drawing.Size(15, 14);
            this.chbVentaCompra.TabIndex = 20;
            this.chbVentaCompra.UseVisualStyleBackColor = true;
            this.chbVentaCompra.CheckedChanged += new System.EventHandler(this.chbVentaCompra_CheckedChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 510);
            this.Controls.Add(this.chbVentaCompra);
            this.Controls.Add(this.txtCostoFactura);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblVentaDelDia);
            this.Controls.Add(this.lblTotalDelDia);
            this.Controls.Add(this.lblTotalCliente);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCostoFactura);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtTotalCliente);
            this.Controls.Add(this.txtTotalDelDia);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGestionarTienda);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.dtgVentaDelDia);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaDelDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVentaDelDia;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnGestionarTienda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTotalDelDia;
        private System.Windows.Forms.TextBox txtTotalCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblCostoFactura;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTotalCliente;
        private System.Windows.Forms.Label lblTotalDelDia;
        private System.Windows.Forms.Label lblVentaDelDia;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtCostoFactura;
        private System.Windows.Forms.CheckBox chbVentaCompra;
    }
}