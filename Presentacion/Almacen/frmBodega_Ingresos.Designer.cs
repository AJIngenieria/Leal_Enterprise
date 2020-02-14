namespace Presentacion
{
    partial class frmBodega_Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodega_Ingresos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TBStockActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGDetalleDeIngreso = new System.Windows.Forms.DataGridView();
            this.IDIngresos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBStockInicial = new System.Windows.Forms.TextBox();
            this.TBNu_Comprobante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBValorDeCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBIdproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBComprobante = new System.Windows.Forms.ComboBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.DTAIAFechaDeIngreso = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleDeIngreso)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso a Bodegas - Leal Enterprise";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(600, 484);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(518, 484);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.BV_Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(92, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(10, 484);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TBStockActual);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CBProveedor);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.DGDetalleDeIngreso);
            this.tabPage1.Controls.Add(this.IDIngresos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TBStockInicial);
            this.tabPage1.Controls.Add(this.TBNu_Comprobante);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.TBValorDeCompra);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TBProducto);
            this.tabPage1.Controls.Add(this.TBIdproducto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CBComprobante);
            this.tabPage1.Controls.Add(this.TBCodigo);
            this.tabPage1.Controls.Add(this.DTAIAFechaDeIngreso);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TBStockActual
            // 
            this.TBStockActual.Location = new System.Drawing.Point(544, 118);
            this.TBStockActual.Name = "TBStockActual";
            this.TBStockActual.Size = new System.Drawing.Size(122, 21);
            this.TBStockActual.TabIndex = 124;
            this.TBStockActual.Enter += new System.EventHandler(this.TBStockActual_Enter);
            this.TBStockActual.Leave += new System.EventHandler(this.TBStockActual_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 123;
            this.label5.Text = "Stock Actual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 122;
            this.label11.Text = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 121;
            this.label10.Text = "------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 120;
            this.label9.Text = "Valor del Ingreso: ";
            // 
            // CBProveedor
            // 
            this.CBProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(91, 6);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(250, 23);
            this.CBProveedor.TabIndex = 119;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(347, 67);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 15);
            this.lblTotal.TabIndex = 118;
            this.lblTotal.Text = "Productos Ingresados";
            // 
            // DGDetalleDeIngreso
            // 
            this.DGDetalleDeIngreso.AllowUserToAddRows = false;
            this.DGDetalleDeIngreso.AllowUserToDeleteRows = false;
            this.DGDetalleDeIngreso.BackgroundColor = System.Drawing.Color.White;
            this.DGDetalleDeIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleDeIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGDetalleDeIngreso.Location = new System.Drawing.Point(8, 145);
            this.DGDetalleDeIngreso.Name = "DGDetalleDeIngreso";
            this.DGDetalleDeIngreso.ReadOnly = true;
            this.DGDetalleDeIngreso.RowHeadersVisible = false;
            this.DGDetalleDeIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDetalleDeIngreso.Size = new System.Drawing.Size(658, 279);
            this.DGDetalleDeIngreso.TabIndex = 117;
            // 
            // IDIngresos
            // 
            this.IDIngresos.Location = new System.Drawing.Point(626, 35);
            this.IDIngresos.Name = "IDIngresos";
            this.IDIngresos.Size = new System.Drawing.Size(19, 21);
            this.IDIngresos.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Proveedor";
            // 
            // TBStockInicial
            // 
            this.TBStockInicial.Location = new System.Drawing.Point(337, 118);
            this.TBStockInicial.Name = "TBStockInicial";
            this.TBStockInicial.Size = new System.Drawing.Size(122, 21);
            this.TBStockInicial.TabIndex = 109;
            this.TBStockInicial.Enter += new System.EventHandler(this.TBStockInicial_Enter);
            this.TBStockInicial.Leave += new System.EventHandler(this.TBStockInicial_Leave);
            // 
            // TBNu_Comprobante
            // 
            this.TBNu_Comprobante.Location = new System.Drawing.Point(110, 64);
            this.TBNu_Comprobante.Name = "TBNu_Comprobante";
            this.TBNu_Comprobante.Size = new System.Drawing.Size(231, 21);
            this.TBNu_Comprobante.TabIndex = 103;
            this.TBNu_Comprobante.Enter += new System.EventHandler(this.TBNu_Comprobante_Enter);
            this.TBNu_Comprobante.Leave += new System.EventHandler(this.TBNu_Comprobante_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 110;
            this.label8.Text = "V. Compra";
            // 
            // TBValorDeCompra
            // 
            this.TBValorDeCompra.Location = new System.Drawing.Point(91, 118);
            this.TBValorDeCompra.Name = "TBValorDeCompra";
            this.TBValorDeCompra.Size = new System.Drawing.Size(162, 21);
            this.TBValorDeCompra.TabIndex = 111;
            this.TBValorDeCompra.Enter += new System.EventHandler(this.TBValorDeCompra_Enter);
            this.TBValorDeCompra.Leave += new System.EventHandler(this.TBValorDeCompra_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "Cod. Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 108;
            this.label7.Text = "Stock Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 102;
            this.label4.Text = "Nº Comprobante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "Fecha de Ingreso a Bodega";
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(337, 91);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(329, 21);
            this.TBProducto.TabIndex = 107;
            this.TBProducto.Enter += new System.EventHandler(this.TBProducto_Enter);
            this.TBProducto.Leave += new System.EventHandler(this.TBProducto_Leave);
            // 
            // TBIdproducto
            // 
            this.TBIdproducto.Location = new System.Drawing.Point(651, 35);
            this.TBIdproducto.Name = "TBIdproducto";
            this.TBIdproducto.Size = new System.Drawing.Size(15, 21);
            this.TBIdproducto.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "Comprobante";
            // 
            // CBComprobante
            // 
            this.CBComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBComprobante.FormattingEnabled = true;
            this.CBComprobante.Items.AddRange(new object[] {
            "Seleccione"});
            this.CBComprobante.Location = new System.Drawing.Point(91, 35);
            this.CBComprobante.Name = "CBComprobante";
            this.CBComprobante.Size = new System.Drawing.Size(250, 23);
            this.CBComprobante.TabIndex = 101;
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(91, 91);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(162, 21);
            this.TBCodigo.TabIndex = 105;
            this.TBCodigo.Enter += new System.EventHandler(this.TBCodigo_Enter);
            this.TBCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCodigo_KeyUp);
            this.TBCodigo.Leave += new System.EventHandler(this.TBCodigo_Leave);
            // 
            // DTAIAFechaDeIngreso
            // 
            this.DTAIAFechaDeIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTAIAFechaDeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTAIAFechaDeIngreso.Location = new System.Drawing.Point(511, 6);
            this.DTAIAFechaDeIngreso.Name = "DTAIAFechaDeIngreso";
            this.DTAIAFechaDeIngreso.Size = new System.Drawing.Size(155, 21);
            this.DTAIAFechaDeIngreso.TabIndex = 99;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGResultados);
            this.tabPage2.Controls.Add(this.TBBuscar);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de Ingreso";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(9, 33);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(657, 391);
            this.DGResultados.TabIndex = 2;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(125, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(541, 21);
            this.TBBuscar.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ingreso a Consultar";
            // 
            // frmBodega_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBodega_Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodega - Ingresos de Bodega";
            this.Load += new System.EventHandler(this.frmBodega_Ingresos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleDeIngreso)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGDetalleDeIngreso;
        public System.Windows.Forms.TextBox IDIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBStockInicial;
        private System.Windows.Forms.TextBox TBNu_Comprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBValorDeCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBProducto;
        public System.Windows.Forms.TextBox TBIdproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBComprobante;
        public System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.DateTimePicker DTAIAFechaDeIngreso;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBStockActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label12;
    }
}