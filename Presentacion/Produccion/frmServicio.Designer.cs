namespace Presentacion
{
    partial class frmServicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TCPrincipal = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.TBIdservicio = new System.Windows.Forms.TextBox();
            this.CBImpuesto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.CBVentas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBValor03 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBValor02 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBValor01 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBRetencion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBComision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBClase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TPConsulta = new System.Windows.Forms.TabPage();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.TCPrincipal.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.TCPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Servicios Ofrecidos";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(278, 389);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseDown);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseMove);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(196, 389);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.BV_Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(94, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(12, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // TCPrincipal
            // 
            this.TCPrincipal.Controls.Add(this.TPDatosBasicos);
            this.TCPrincipal.Controls.Add(this.TPConsulta);
            this.TCPrincipal.Location = new System.Drawing.Point(6, 20);
            this.TCPrincipal.Name = "TCPrincipal";
            this.TCPrincipal.SelectedIndex = 0;
            this.TCPrincipal.Size = new System.Drawing.Size(352, 363);
            this.TCPrincipal.TabIndex = 0;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBIdservicio);
            this.TPDatosBasicos.Controls.Add(this.CBImpuesto);
            this.TPDatosBasicos.Controls.Add(this.label14);
            this.TPDatosBasicos.Controls.Add(this.TBCodigo);
            this.TPDatosBasicos.Controls.Add(this.CBVentas);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.TBValor03);
            this.TPDatosBasicos.Controls.Add(this.label12);
            this.TPDatosBasicos.Controls.Add(this.TBValor02);
            this.TPDatosBasicos.Controls.Add(this.label11);
            this.TPDatosBasicos.Controls.Add(this.TBValor01);
            this.TPDatosBasicos.Controls.Add(this.label10);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.TBRetencion);
            this.TPDatosBasicos.Controls.Add(this.label8);
            this.TPDatosBasicos.Controls.Add(this.TBComision);
            this.TPDatosBasicos.Controls.Add(this.label9);
            this.TPDatosBasicos.Controls.Add(this.TBCosto);
            this.TPDatosBasicos.Controls.Add(this.label5);
            this.TPDatosBasicos.Controls.Add(this.TBClase);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.TBDescripcion);
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.TBServicio);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(344, 335);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBIdservicio
            // 
            this.TBIdservicio.Location = new System.Drawing.Point(50, 141);
            this.TBIdservicio.Name = "TBIdservicio";
            this.TBIdservicio.Size = new System.Drawing.Size(26, 21);
            this.TBIdservicio.TabIndex = 30;
            // 
            // CBImpuesto
            // 
            this.CBImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImpuesto.FormattingEnabled = true;
            this.CBImpuesto.Location = new System.Drawing.Point(84, 305);
            this.CBImpuesto.Name = "CBImpuesto";
            this.CBImpuesto.Size = new System.Drawing.Size(250, 23);
            this.CBImpuesto.Sorted = true;
            this.CBImpuesto.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Codigo";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(84, 6);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(250, 21);
            this.TBCodigo.TabIndex = 27;
            this.TBCodigo.Enter += new System.EventHandler(this.TBCodigo_Enter);
            this.TBCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCodigo_KeyUp);
            this.TBCodigo.Leave += new System.EventHandler(this.TBCodigo_Leave);
            // 
            // CBVentas
            // 
            this.CBVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVentas.FormattingEnabled = true;
            this.CBVentas.Items.AddRange(new object[] {
            "-",
            "Valor 01",
            "Valor 02",
            "Valor 03"});
            this.CBVentas.Location = new System.Drawing.Point(84, 276);
            this.CBVentas.Name = "CBVentas";
            this.CBVentas.Size = new System.Drawing.Size(250, 23);
            this.CBVentas.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Impuesto";
            // 
            // TBValor03
            // 
            this.TBValor03.Location = new System.Drawing.Point(84, 222);
            this.TBValor03.Name = "TBValor03";
            this.TBValor03.Size = new System.Drawing.Size(250, 21);
            this.TBValor03.TabIndex = 23;
            this.TBValor03.Enter += new System.EventHandler(this.TBValor03_Enter);
            this.TBValor03.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBValor03_KeyUp);
            this.TBValor03.Leave += new System.EventHandler(this.TBValor03_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Valor 03";
            // 
            // TBValor02
            // 
            this.TBValor02.Location = new System.Drawing.Point(84, 195);
            this.TBValor02.Name = "TBValor02";
            this.TBValor02.Size = new System.Drawing.Size(250, 21);
            this.TBValor02.TabIndex = 21;
            this.TBValor02.Enter += new System.EventHandler(this.TBValor02_Enter);
            this.TBValor02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBValor02_KeyUp);
            this.TBValor02.Leave += new System.EventHandler(this.TBValor02_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Valor 02";
            // 
            // TBValor01
            // 
            this.TBValor01.Location = new System.Drawing.Point(84, 168);
            this.TBValor01.Name = "TBValor01";
            this.TBValor01.Size = new System.Drawing.Size(250, 21);
            this.TBValor01.TabIndex = 19;
            this.TBValor01.Enter += new System.EventHandler(this.TBValor01_Enter);
            this.TBValor01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBValor01_KeyUp);
            this.TBValor01.Leave += new System.EventHandler(this.TBValor01_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Valor 01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ventas";
            // 
            // TBRetencion
            // 
            this.TBRetencion.Location = new System.Drawing.Point(84, 114);
            this.TBRetencion.Name = "TBRetencion";
            this.TBRetencion.Size = new System.Drawing.Size(250, 21);
            this.TBRetencion.TabIndex = 15;
            this.TBRetencion.Enter += new System.EventHandler(this.TBRetencion_Enter);
            this.TBRetencion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBRetencion_KeyUp);
            this.TBRetencion.Leave += new System.EventHandler(this.TBRetencion_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Retencion";
            // 
            // TBComision
            // 
            this.TBComision.Location = new System.Drawing.Point(84, 249);
            this.TBComision.Name = "TBComision";
            this.TBComision.Size = new System.Drawing.Size(250, 21);
            this.TBComision.TabIndex = 13;
            this.TBComision.Enter += new System.EventHandler(this.TBComision_Enter);
            this.TBComision.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBComision_KeyUp);
            this.TBComision.Leave += new System.EventHandler(this.TBComision_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Comision";
            // 
            // TBCosto
            // 
            this.TBCosto.Location = new System.Drawing.Point(84, 141);
            this.TBCosto.Name = "TBCosto";
            this.TBCosto.Size = new System.Drawing.Size(250, 21);
            this.TBCosto.TabIndex = 9;
            this.TBCosto.Enter += new System.EventHandler(this.TBCosto_Enter);
            this.TBCosto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCosto_KeyUp);
            this.TBCosto.Leave += new System.EventHandler(this.TBCosto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo";
            // 
            // TBClase
            // 
            this.TBClase.Location = new System.Drawing.Point(84, 87);
            this.TBClase.Name = "TBClase";
            this.TBClase.Size = new System.Drawing.Size(250, 21);
            this.TBClase.TabIndex = 5;
            this.TBClase.Enter += new System.EventHandler(this.TBClase_Enter);
            this.TBClase.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBClase_KeyUp);
            this.TBClase.Leave += new System.EventHandler(this.TBClase_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clase";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(84, 60);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 21);
            this.TBDescripcion.TabIndex = 3;
            this.TBDescripcion.Enter += new System.EventHandler(this.TBDescripcion_Enter);
            this.TBDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescripcion_KeyUp);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // TBServicio
            // 
            this.TBServicio.Location = new System.Drawing.Point(84, 33);
            this.TBServicio.Name = "TBServicio";
            this.TBServicio.Size = new System.Drawing.Size(250, 21);
            this.TBServicio.TabIndex = 1;
            this.TBServicio.Enter += new System.EventHandler(this.TBServicio_Enter);
            this.TBServicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBServicio_KeyUp);
            this.TBServicio.Leave += new System.EventHandler(this.TBServicio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // TPConsulta
            // 
            this.TPConsulta.Controls.Add(this.TBBuscar);
            this.TPConsulta.Controls.Add(this.label15);
            this.TPConsulta.Controls.Add(this.lblTotal);
            this.TPConsulta.Controls.Add(this.DGResultados);
            this.TPConsulta.Location = new System.Drawing.Point(4, 24);
            this.TPConsulta.Name = "TPConsulta";
            this.TPConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TPConsulta.Size = new System.Drawing.Size(344, 335);
            this.TPConsulta.TabIndex = 1;
            this.TPConsulta.Text = "Consultas";
            this.TPConsulta.UseVisualStyleBackColor = true;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(127, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(211, 21);
            this.TBBuscar.TabIndex = 3;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Servicio a Consultar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "------";
            // 
            // DGResultados
            // 
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 33);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(332, 281);
            this.DGResultados.TabIndex = 0;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 445);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion - Servicio";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.TCPrincipal.ResumeLayout(false);
            this.TPDatosBasicos.ResumeLayout(false);
            this.TPDatosBasicos.PerformLayout();
            this.TPConsulta.ResumeLayout(false);
            this.TPConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TCPrincipal;
        private System.Windows.Forms.TabPage TPDatosBasicos;
        private System.Windows.Forms.TabPage TPConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBRetencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBComision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBClase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBValor03;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBValor02;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBValor01;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBVentas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.ComboBox CBImpuesto;
        private System.Windows.Forms.TextBox TBIdservicio;
    }
}