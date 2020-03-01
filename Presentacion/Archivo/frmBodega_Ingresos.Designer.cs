﻿namespace Presentacion
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBComprobante = new System.Windows.Forms.ComboBox();
            this.CBMoneda = new System.Windows.Forms.ComboBox();
            this.DTFechadeingreso = new System.Windows.Forms.DateTimePicker();
            this.DGDetalleDeIngreso = new System.Windows.Forms.DataGridView();
            this.TBCodigoID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExaminar_Producto = new System.Windows.Forms.Button();
            this.TBCodigo_Producto = new System.Windows.Forms.TextBox();
            this.btnExaminar_Proveedor = new System.Windows.Forms.Button();
            this.btnExaminar_Bodega = new System.Windows.Forms.Button();
            this.TBBodega = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.TBCodigo_Proveedor = new System.Windows.Forms.TextBox();
            this.TBCodigo_Bodega = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IDIngresos = new System.Windows.Forms.TextBox();
            this.TBIdproducto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.IDIngresos);
            this.groupBox1.Controls.Add(this.TBIdproducto);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 519);
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
            this.btnImprimir.Location = new System.Drawing.Point(977, 484);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(895, 484);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.CBComprobante);
            this.tabPage1.Controls.Add(this.CBMoneda);
            this.tabPage1.Controls.Add(this.DTFechadeingreso);
            this.tabPage1.Controls.Add(this.DGDetalleDeIngreso);
            this.tabPage1.Controls.Add(this.TBCodigoID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnExaminar_Producto);
            this.tabPage1.Controls.Add(this.TBCodigo_Producto);
            this.tabPage1.Controls.Add(this.btnExaminar_Proveedor);
            this.tabPage1.Controls.Add(this.btnExaminar_Bodega);
            this.tabPage1.Controls.Add(this.TBBodega);
            this.tabPage1.Controls.Add(this.TBProveedor);
            this.tabPage1.Controls.Add(this.TBCodigo_Proveedor);
            this.tabPage1.Controls.Add(this.TBCodigo_Bodega);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 147;
            this.label8.Text = "Fecha de Ingreso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(761, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 102);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores de Ingreso - Leal Enterprise";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 15);
            this.lblTotal.TabIndex = 118;
            this.lblTotal.Text = "Productos Ingresados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 120;
            this.label9.Text = "Valor del Ingreso: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 140;
            this.label2.Text = "Descuentos:";
            // 
            // CBComprobante
            // 
            this.CBComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBComprobante.FormattingEnabled = true;
            this.CBComprobante.Location = new System.Drawing.Point(598, 33);
            this.CBComprobante.Name = "CBComprobante";
            this.CBComprobante.Size = new System.Drawing.Size(150, 21);
            this.CBComprobante.TabIndex = 145;
            // 
            // CBMoneda
            // 
            this.CBMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMoneda.FormattingEnabled = true;
            this.CBMoneda.Location = new System.Drawing.Point(598, 7);
            this.CBMoneda.Name = "CBMoneda";
            this.CBMoneda.Size = new System.Drawing.Size(150, 21);
            this.CBMoneda.TabIndex = 144;
            // 
            // DTFechadeingreso
            // 
            this.DTFechadeingreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTFechadeingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechadeingreso.Location = new System.Drawing.Point(366, 7);
            this.DTFechadeingreso.Name = "DTFechadeingreso";
            this.DTFechadeingreso.Size = new System.Drawing.Size(139, 21);
            this.DTFechadeingreso.TabIndex = 143;
            // 
            // DGDetalleDeIngreso
            // 
            this.DGDetalleDeIngreso.AllowUserToAddRows = false;
            this.DGDetalleDeIngreso.AllowUserToDeleteRows = false;
            this.DGDetalleDeIngreso.BackgroundColor = System.Drawing.Color.White;
            this.DGDetalleDeIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleDeIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGDetalleDeIngreso.Location = new System.Drawing.Point(9, 114);
            this.DGDetalleDeIngreso.Name = "DGDetalleDeIngreso";
            this.DGDetalleDeIngreso.RowHeadersVisible = false;
            this.DGDetalleDeIngreso.Size = new System.Drawing.Size(1026, 310);
            this.DGDetalleDeIngreso.TabIndex = 141;
            // 
            // TBCodigoID
            // 
            this.TBCodigoID.Location = new System.Drawing.Point(69, 7);
            this.TBCodigoID.Name = "TBCodigoID";
            this.TBCodigoID.Size = new System.Drawing.Size(180, 21);
            this.TBCodigoID.TabIndex = 139;
            this.TBCodigoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigoID.Enter += new System.EventHandler(this.TBCodigoID_Enter);
            this.TBCodigoID.Leave += new System.EventHandler(this.TBCodigoID_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 138;
            this.label7.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 137;
            this.label4.Text = "Moneda";
            // 
            // btnExaminar_Producto
            // 
            this.btnExaminar_Producto.BackgroundImage = global::Presentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Producto.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Producto.Location = new System.Drawing.Point(480, 87);
            this.btnExaminar_Producto.Name = "btnExaminar_Producto";
            this.btnExaminar_Producto.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Producto.TabIndex = 131;
            this.btnExaminar_Producto.UseVisualStyleBackColor = true;
            this.btnExaminar_Producto.Click += new System.EventHandler(this.btnExaminar_Producto_Click);
            // 
            // TBCodigo_Producto
            // 
            this.TBCodigo_Producto.Location = new System.Drawing.Point(68, 87);
            this.TBCodigo_Producto.Name = "TBCodigo_Producto";
            this.TBCodigo_Producto.Size = new System.Drawing.Size(406, 21);
            this.TBCodigo_Producto.TabIndex = 130;
            this.TBCodigo_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo_Producto.Enter += new System.EventHandler(this.TBCodigo_Producto_Enter);
            this.TBCodigo_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_Producto_KeyPress);
            this.TBCodigo_Producto.Leave += new System.EventHandler(this.TBCodigo_Producto_Leave);
            // 
            // btnExaminar_Proveedor
            // 
            this.btnExaminar_Proveedor.BackgroundImage = global::Presentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Proveedor.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Proveedor.Location = new System.Drawing.Point(224, 33);
            this.btnExaminar_Proveedor.Name = "btnExaminar_Proveedor";
            this.btnExaminar_Proveedor.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Proveedor.TabIndex = 129;
            this.btnExaminar_Proveedor.UseVisualStyleBackColor = true;
            this.btnExaminar_Proveedor.Click += new System.EventHandler(this.btnExaminar_Proveedor_Click);
            // 
            // btnExaminar_Bodega
            // 
            this.btnExaminar_Bodega.BackgroundImage = global::Presentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Bodega.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Bodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Bodega.Location = new System.Drawing.Point(224, 60);
            this.btnExaminar_Bodega.Name = "btnExaminar_Bodega";
            this.btnExaminar_Bodega.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Bodega.TabIndex = 128;
            this.btnExaminar_Bodega.UseVisualStyleBackColor = true;
            this.btnExaminar_Bodega.Click += new System.EventHandler(this.btnExaminar_Bodega_Click);
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(255, 60);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(250, 21);
            this.TBBodega.TabIndex = 127;
            this.TBBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBodega.Enter += new System.EventHandler(this.TBBodega_Enter);
            this.TBBodega.Leave += new System.EventHandler(this.TBBodega_Leave);
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(255, 33);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(250, 21);
            this.TBProveedor.TabIndex = 126;
            this.TBProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBProveedor.Enter += new System.EventHandler(this.TBProveedor_Enter);
            this.TBProveedor.Leave += new System.EventHandler(this.TBProveedor_Leave);
            // 
            // TBCodigo_Proveedor
            // 
            this.TBCodigo_Proveedor.Location = new System.Drawing.Point(68, 33);
            this.TBCodigo_Proveedor.Name = "TBCodigo_Proveedor";
            this.TBCodigo_Proveedor.Size = new System.Drawing.Size(150, 21);
            this.TBCodigo_Proveedor.TabIndex = 125;
            this.TBCodigo_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo_Proveedor.Enter += new System.EventHandler(this.TBCodigo_Proveedor_Enter);
            this.TBCodigo_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_Proveedor_KeyPress);
            this.TBCodigo_Proveedor.Leave += new System.EventHandler(this.TBCodigo_Proveedor_Leave);
            // 
            // TBCodigo_Bodega
            // 
            this.TBCodigo_Bodega.Location = new System.Drawing.Point(68, 60);
            this.TBCodigo_Bodega.Name = "TBCodigo_Bodega";
            this.TBCodigo_Bodega.Size = new System.Drawing.Size(150, 21);
            this.TBCodigo_Bodega.TabIndex = 124;
            this.TBCodigo_Bodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo_Bodega.Enter += new System.EventHandler(this.TBCodigo_Bodega_Enter);
            this.TBCodigo_Bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_Bodega_KeyPress);
            this.TBCodigo_Bodega.Leave += new System.EventHandler(this.TBCodigo_Bodega_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 122;
            this.label5.Text = "Bodega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "Comprobante";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGResultados);
            this.tabPage2.Controls.Add(this.TBBuscar);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 430);
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
            this.DGResultados.Size = new System.Drawing.Size(945, 391);
            this.DGResultados.TabIndex = 2;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(125, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(829, 21);
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
            // IDIngresos
            // 
            this.IDIngresos.Location = new System.Drawing.Point(290, 486);
            this.IDIngresos.Name = "IDIngresos";
            this.IDIngresos.Size = new System.Drawing.Size(19, 21);
            this.IDIngresos.TabIndex = 116;
            // 
            // TBIdproducto
            // 
            this.TBIdproducto.Location = new System.Drawing.Point(315, 486);
            this.TBIdproducto.Name = "TBIdproducto";
            this.TBIdproducto.Size = new System.Drawing.Size(15, 21);
            this.TBIdproducto.TabIndex = 115;
            // 
            // frmBodega_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 540);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBodega_Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodega - Ingresos de Bodega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBodega_Ingresos_FormClosing);
            this.Load += new System.EventHandler(this.frmBodega_Ingresos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        public System.Windows.Forms.TextBox IDIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TBIdproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCodigo_Bodega;
        private System.Windows.Forms.TextBox TBCodigo_Proveedor;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.TextBox TBBodega;
        private System.Windows.Forms.Button btnExaminar_Proveedor;
        private System.Windows.Forms.Button btnExaminar_Bodega;
        private System.Windows.Forms.Button btnExaminar_Producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCodigoID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTFechadeingreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBComprobante;
        private System.Windows.Forms.ComboBox CBMoneda;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TBCodigo_Producto;
        public System.Windows.Forms.DataGridView DGDetalleDeIngreso;
    }
}