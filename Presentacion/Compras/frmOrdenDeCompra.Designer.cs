namespace Presentacion
{
    partial class frmOrdenDeCompra
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
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBIdbodega = new System.Windows.Forms.TextBox();
            this.TBIdproveedor = new System.Windows.Forms.TextBox();
            this.TBIddetalle = new System.Windows.Forms.TextBox();
            this.TBIdproducto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.TBGrupo = new System.Windows.Forms.TextBox();
            this.TBEstante = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBReferencia = new System.Windows.Forms.TextBox();
            this.TBNivel = new System.Windows.Forms.TextBox();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.DGDetalleDeIngreso = new System.Windows.Forms.DataGridView();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBCodigo_Producto = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.TBCodigo_Proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBUbicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.TBCodigo_Bodega = new System.Windows.Forms.TextBox();
            this.TBBodega = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBValorCompra_Final = new System.Windows.Forms.TextBox();
            this.TBValorPromedio_Final = new System.Windows.Forms.TextBox();
            this.TBCreditoDisponible = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExaminar_Proveedor = new System.Windows.Forms.Button();
            this.btnExaminar_Producto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleDeIngreso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(334, 20);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(412, 21);
            this.TBDescripcion.TabIndex = 175;
            this.TBDescripcion.Enter += new System.EventHandler(this.TBDescripcion_Enter);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 174;
            this.label5.Text = "Descripción";
            // 
            // TBIdbodega
            // 
            this.TBIdbodega.Location = new System.Drawing.Point(873, 462);
            this.TBIdbodega.Name = "TBIdbodega";
            this.TBIdbodega.Size = new System.Drawing.Size(10, 21);
            this.TBIdbodega.TabIndex = 118;
            // 
            // TBIdproveedor
            // 
            this.TBIdproveedor.Location = new System.Drawing.Point(921, 462);
            this.TBIdproveedor.Name = "TBIdproveedor";
            this.TBIdproveedor.Size = new System.Drawing.Size(10, 21);
            this.TBIdproveedor.TabIndex = 117;
            // 
            // TBIddetalle
            // 
            this.TBIddetalle.Location = new System.Drawing.Point(905, 462);
            this.TBIddetalle.Name = "TBIddetalle";
            this.TBIddetalle.Size = new System.Drawing.Size(10, 21);
            this.TBIddetalle.TabIndex = 116;
            // 
            // TBIdproducto
            // 
            this.TBIdproducto.Location = new System.Drawing.Point(889, 462);
            this.TBIdproducto.Name = "TBIdproducto";
            this.TBIdproducto.Size = new System.Drawing.Size(10, 21);
            this.TBIdproducto.TabIndex = 115;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(741, 465);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 15);
            this.lblTotal.TabIndex = 118;
            this.lblTotal.Text = "Productos Ingresados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 157;
            this.label2.Text = "Marca";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(260, 435);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 15);
            this.label31.TabIndex = 165;
            this.label31.Text = "Grupo";
            // 
            // TBGrupo
            // 
            this.TBGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGrupo.Location = new System.Drawing.Point(314, 432);
            this.TBGrupo.Name = "TBGrupo";
            this.TBGrupo.Size = new System.Drawing.Size(180, 21);
            this.TBGrupo.TabIndex = 164;
            this.TBGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBEstante
            // 
            this.TBEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEstante.Location = new System.Drawing.Point(314, 459);
            this.TBEstante.Name = "TBEstante";
            this.TBEstante.Size = new System.Drawing.Size(180, 21);
            this.TBEstante.TabIndex = 158;
            this.TBEstante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(500, 462);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 15);
            this.label32.TabIndex = 163;
            this.label32.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 159;
            this.label4.Text = "Estante";
            // 
            // TBReferencia
            // 
            this.TBReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBReferencia.Location = new System.Drawing.Point(546, 432);
            this.TBReferencia.Name = "TBReferencia";
            this.TBReferencia.Size = new System.Drawing.Size(180, 21);
            this.TBReferencia.TabIndex = 162;
            this.TBReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNivel
            // 
            this.TBNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNivel.Location = new System.Drawing.Point(546, 459);
            this.TBNivel.Name = "TBNivel";
            this.TBNivel.Size = new System.Drawing.Size(180, 21);
            this.TBNivel.TabIndex = 161;
            this.TBNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBProducto
            // 
            this.TBProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProducto.Location = new System.Drawing.Point(256, 101);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(458, 21);
            this.TBProducto.TabIndex = 150;
            this.TBProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGDetalleDeIngreso
            // 
            this.DGDetalleDeIngreso.AllowUserToAddRows = false;
            this.DGDetalleDeIngreso.BackgroundColor = System.Drawing.Color.White;
            this.DGDetalleDeIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleDeIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGDetalleDeIngreso.Location = new System.Drawing.Point(6, 128);
            this.DGDetalleDeIngreso.Name = "DGDetalleDeIngreso";
            this.DGDetalleDeIngreso.RowHeadersVisible = false;
            this.DGDetalleDeIngreso.Size = new System.Drawing.Size(1116, 298);
            this.DGDetalleDeIngreso.TabIndex = 141;
            // 
            // TBCodigo
            // 
            this.TBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo.Location = new System.Drawing.Point(69, 20);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(181, 21);
            this.TBCodigo.TabIndex = 139;
            this.TBCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo.Enter += new System.EventHandler(this.TBCodigo_Enter);
            this.TBCodigo.Leave += new System.EventHandler(this.TBCodigo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 138;
            this.label7.Text = "Codigo";
            // 
            // TBCodigo_Producto
            // 
            this.TBCodigo_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo_Producto.Location = new System.Drawing.Point(69, 101);
            this.TBCodigo_Producto.Name = "TBCodigo_Producto";
            this.TBCodigo_Producto.Size = new System.Drawing.Size(181, 21);
            this.TBCodigo_Producto.TabIndex = 130;
            this.TBCodigo_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo_Producto.Enter += new System.EventHandler(this.TBCodigo_Producto_Enter);
            this.TBCodigo_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_Producto_KeyPress);
            this.TBCodigo_Producto.Leave += new System.EventHandler(this.TBCodigo_Producto_Leave);
            // 
            // TBProveedor
            // 
            this.TBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProveedor.Location = new System.Drawing.Point(255, 47);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(458, 21);
            this.TBProveedor.TabIndex = 126;
            this.TBProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCodigo_Proveedor
            // 
            this.TBCodigo_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo_Proveedor.Location = new System.Drawing.Point(69, 47);
            this.TBCodigo_Proveedor.Name = "TBCodigo_Proveedor";
            this.TBCodigo_Proveedor.Size = new System.Drawing.Size(181, 21);
            this.TBCodigo_Proveedor.TabIndex = 125;
            this.TBCodigo_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo_Proveedor.Enter += new System.EventHandler(this.TBCodigo_Proveedor_Enter);
            this.TBCodigo_Proveedor.Leave += new System.EventHandler(this.TBCodigo_Proveedor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBUbicacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.TBIdbodega);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.TBMarca);
            this.groupBox1.Controls.Add(this.TBIdproveedor);
            this.groupBox1.Controls.Add(this.TBGrupo);
            this.groupBox1.Controls.Add(this.TBEstante);
            this.groupBox1.Controls.Add(this.TBIddetalle);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBIdproducto);
            this.groupBox1.Controls.Add(this.TBReferencia);
            this.groupBox1.Controls.Add(this.TBNivel);
            this.groupBox1.Controls.Add(this.TBCodigo_Bodega);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TBBodega);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBCodigo_Proveedor);
            this.groupBox1.Controls.Add(this.TBProveedor);
            this.groupBox1.Controls.Add(this.btnExaminar_Proveedor);
            this.groupBox1.Controls.Add(this.TBCodigo_Producto);
            this.groupBox1.Controls.Add(this.btnExaminar_Producto);
            this.groupBox1.Controls.Add(this.TBDescripcion);
            this.groupBox1.Controls.Add(this.TBCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DGDetalleDeIngreso);
            this.groupBox1.Controls.Add(this.TBProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 490);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Ordenes de Compra - Leal Enterprise";
            // 
            // TBUbicacion
            // 
            this.TBUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUbicacion.Location = new System.Drawing.Point(74, 459);
            this.TBUbicacion.Name = "TBUbicacion";
            this.TBUbicacion.Size = new System.Drawing.Size(180, 21);
            this.TBUbicacion.TabIndex = 199;
            this.TBUbicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 200;
            this.label3.Text = "Ubicacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 198;
            this.label8.Text = "Refer.";
            // 
            // TBMarca
            // 
            this.TBMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMarca.Location = new System.Drawing.Point(74, 432);
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(180, 21);
            this.TBMarca.TabIndex = 156;
            this.TBMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCodigo_Bodega
            // 
            this.TBCodigo_Bodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo_Bodega.Location = new System.Drawing.Point(69, 74);
            this.TBCodigo_Bodega.Name = "TBCodigo_Bodega";
            this.TBCodigo_Bodega.Size = new System.Drawing.Size(181, 21);
            this.TBCodigo_Bodega.TabIndex = 194;
            this.TBCodigo_Bodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCodigo_Bodega.Enter += new System.EventHandler(this.TBCodigo_Bodega_Enter);
            this.TBCodigo_Bodega.Leave += new System.EventHandler(this.TBCodigo_Bodega_Leave);
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(256, 74);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(458, 21);
            this.TBBodega.TabIndex = 189;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 188;
            this.label16.Text = "Bodega";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.btnGuardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(744, 432);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 176;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.btnCancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(840, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 181;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.btnEliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(936, 432);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.TabIndex = 180;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Datos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.btnImprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(1032, 432);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 30);
            this.btnImprimir.TabIndex = 187;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Tablas.Valores___Orden_de_Compra;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.TBValorCompra_Final);
            this.panel1.Controls.Add(this.TBValorPromedio_Final);
            this.panel1.Controls.Add(this.TBCreditoDisponible);
            this.panel1.Location = new System.Drawing.Point(751, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 104);
            this.panel1.TabIndex = 196;
            // 
            // TBValorCompra_Final
            // 
            this.TBValorCompra_Final.BackColor = System.Drawing.Color.Silver;
            this.TBValorCompra_Final.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBValorCompra_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValorCompra_Final.Location = new System.Drawing.Point(143, 82);
            this.TBValorCompra_Final.Name = "TBValorCompra_Final";
            this.TBValorCompra_Final.Size = new System.Drawing.Size(218, 17);
            this.TBValorCompra_Final.TabIndex = 2;
            this.TBValorCompra_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBValorPromedio_Final
            // 
            this.TBValorPromedio_Final.BackColor = System.Drawing.Color.Silver;
            this.TBValorPromedio_Final.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBValorPromedio_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValorPromedio_Final.Location = new System.Drawing.Point(143, 56);
            this.TBValorPromedio_Final.Name = "TBValorPromedio_Final";
            this.TBValorPromedio_Final.Size = new System.Drawing.Size(218, 17);
            this.TBValorPromedio_Final.TabIndex = 1;
            this.TBValorPromedio_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCreditoDisponible
            // 
            this.TBCreditoDisponible.BackColor = System.Drawing.Color.Silver;
            this.TBCreditoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCreditoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCreditoDisponible.Location = new System.Drawing.Point(143, 31);
            this.TBCreditoDisponible.Name = "TBCreditoDisponible";
            this.TBCreditoDisponible.Size = new System.Drawing.Size(218, 17);
            this.TBCreditoDisponible.TabIndex = 0;
            this.TBCreditoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Presentacion.Properties.Resources.btnExaminar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(720, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 190;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExaminar_Proveedor
            // 
            this.btnExaminar_Proveedor.BackgroundImage = global::Presentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Proveedor.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Proveedor.Location = new System.Drawing.Point(720, 47);
            this.btnExaminar_Proveedor.Name = "btnExaminar_Proveedor";
            this.btnExaminar_Proveedor.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Proveedor.TabIndex = 129;
            this.btnExaminar_Proveedor.UseVisualStyleBackColor = true;
            this.btnExaminar_Proveedor.Click += new System.EventHandler(this.btnExaminar_Proveedor_Click);
            // 
            // btnExaminar_Producto
            // 
            this.btnExaminar_Producto.BackgroundImage = global::Presentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Producto.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Producto.Location = new System.Drawing.Point(720, 101);
            this.btnExaminar_Producto.Name = "btnExaminar_Producto";
            this.btnExaminar_Producto.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Producto.TabIndex = 131;
            this.btnExaminar_Producto.UseVisualStyleBackColor = true;
            this.btnExaminar_Producto.Click += new System.EventHandler(this.btnExaminar_Producto_Click);
            // 
            // frmOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 514);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmOrdenDeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras - Orden de Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenDeCompra_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleDeIngreso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TBGrupo;
        private System.Windows.Forms.TextBox TBEstante;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBReferencia;
        private System.Windows.Forms.TextBox TBNivel;
        public System.Windows.Forms.TextBox TBIdbodega;
        public System.Windows.Forms.TextBox TBIdproveedor;
        public System.Windows.Forms.TextBox TBIddetalle;
        public System.Windows.Forms.TextBox TBIdproducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TBProducto;
        public System.Windows.Forms.DataGridView DGDetalleDeIngreso;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExaminar_Producto;
        public System.Windows.Forms.TextBox TBCodigo_Producto;
        private System.Windows.Forms.Button btnExaminar_Proveedor;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.TextBox TBCodigo_Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBBodega;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox TBCodigo_Bodega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBValorCompra_Final;
        private System.Windows.Forms.TextBox TBValorPromedio_Final;
        private System.Windows.Forms.TextBox TBCreditoDisponible;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.TextBox TBUbicacion;
        private System.Windows.Forms.Label label3;
    }
}