namespace Presentacion
{
    partial class frmEmpleados
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
            this.TBIdempleado = new System.Windows.Forms.TextBox();
            this.TCPrincipal = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.TBDireccion02 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBDireccion01 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBEmpleado = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBFijo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBMovil = new System.Windows.Forms.TextBox();
            this.TPDatosFinancieros = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCargo = new System.Windows.Forms.TextBox();
            this.TBProfesion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CBDepartamento = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TBCuentaAuxiliar = new System.Windows.Forms.TextBox();
            this.CBBancoAuxiliar = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CBBancoPrincipal = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TBDescuento = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TBComision = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBCuentaPrincipal = new System.Windows.Forms.TextBox();
            this.TPConsulta = new System.Windows.Forms.TabPage();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TCPrincipal.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPDatosFinancieros.SuspendLayout();
            this.TPConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.TBIdempleado);
            this.groupBox1.Controls.Add(this.TCPrincipal);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Empleados";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(318, 334);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseDown);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseMove);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(236, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // TBIdempleado
            // 
            this.TBIdempleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBIdempleado.Location = new System.Drawing.Point(175, 337);
            this.TBIdempleado.Name = "TBIdempleado";
            this.TBIdempleado.Size = new System.Drawing.Size(53, 21);
            this.TBIdempleado.TabIndex = 19;
            // 
            // TCPrincipal
            // 
            this.TCPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCPrincipal.Controls.Add(this.TPDatosBasicos);
            this.TCPrincipal.Controls.Add(this.TPDatosFinancieros);
            this.TCPrincipal.Controls.Add(this.TPConsulta);
            this.TCPrincipal.Location = new System.Drawing.Point(6, 20);
            this.TCPrincipal.Name = "TCPrincipal";
            this.TCPrincipal.SelectedIndex = 0;
            this.TCPrincipal.Size = new System.Drawing.Size(391, 308);
            this.TCPrincipal.TabIndex = 2;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBDireccion02);
            this.TPDatosBasicos.Controls.Add(this.label12);
            this.TPDatosBasicos.Controls.Add(this.label11);
            this.TPDatosBasicos.Controls.Add(this.TBDireccion01);
            this.TPDatosBasicos.Controls.Add(this.label18);
            this.TPDatosBasicos.Controls.Add(this.TBPais);
            this.TPDatosBasicos.Controls.Add(this.label10);
            this.TPDatosBasicos.Controls.Add(this.TBDocumento);
            this.TPDatosBasicos.Controls.Add(this.TBCodigo);
            this.TPDatosBasicos.Controls.Add(this.label8);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Controls.Add(this.TBEmpleado);
            this.TPDatosBasicos.Controls.Add(this.TBCorreo);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.TBCiudad);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.TBFijo);
            this.TPDatosBasicos.Controls.Add(this.label5);
            this.TPDatosBasicos.Controls.Add(this.TBMovil);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(383, 280);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBDireccion02
            // 
            this.TBDireccion02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDireccion02.Location = new System.Drawing.Point(124, 249);
            this.TBDireccion02.Name = "TBDireccion02";
            this.TBDireccion02.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion02.TabIndex = 27;
            this.TBDireccion02.Enter += new System.EventHandler(this.TBDireccion02_Enter);
            this.TBDireccion02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion02_KeyUp);
            this.TBDireccion02.Leave += new System.EventHandler(this.TBDireccion02_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Direccion 02";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Direccion 01";
            // 
            // TBDireccion01
            // 
            this.TBDireccion01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDireccion01.Location = new System.Drawing.Point(124, 222);
            this.TBDireccion01.Name = "TBDireccion01";
            this.TBDireccion01.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion01.TabIndex = 24;
            this.TBDireccion01.Enter += new System.EventHandler(this.TBDireccion01_Enter);
            this.TBDireccion01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion01_KeyUp);
            this.TBDireccion01.Leave += new System.EventHandler(this.TBDireccion01_Leave);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 15);
            this.label18.TabIndex = 21;
            this.label18.Text = "Pais de Residencia";
            // 
            // TBPais
            // 
            this.TBPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPais.Location = new System.Drawing.Point(124, 87);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(250, 21);
            this.TBPais.TabIndex = 20;
            this.TBPais.Enter += new System.EventHandler(this.TBPais_Enter);
            this.TBPais.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBPais_KeyUp);
            this.TBPais.Leave += new System.EventHandler(this.TBPais_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Documento";
            // 
            // TBDocumento
            // 
            this.TBDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDocumento.Location = new System.Drawing.Point(124, 60);
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(250, 21);
            this.TBDocumento.TabIndex = 18;
            this.TBDocumento.Enter += new System.EventHandler(this.TBDocumento_Enter);
            this.TBDocumento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDocumento_KeyUp);
            this.TBDocumento.Leave += new System.EventHandler(this.TBDocumento_Leave);
            // 
            // TBCodigo
            // 
            this.TBCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCodigo.Location = new System.Drawing.Point(124, 6);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(250, 21);
            this.TBCodigo.TabIndex = 17;
            this.TBCodigo.Enter += new System.EventHandler(this.TBCodigo_Enter);
            this.TBCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCodigo_KeyUp);
            this.TBCodigo.Leave += new System.EventHandler(this.TBCodigo_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Codigo ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // TBEmpleado
            // 
            this.TBEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBEmpleado.Location = new System.Drawing.Point(124, 33);
            this.TBEmpleado.Name = "TBEmpleado";
            this.TBEmpleado.Size = new System.Drawing.Size(250, 21);
            this.TBEmpleado.TabIndex = 1;
            this.TBEmpleado.Enter += new System.EventHandler(this.TBEmpleado_Enter);
            this.TBEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBEmpleado_KeyUp);
            this.TBEmpleado.Leave += new System.EventHandler(this.TBEmpleado_Leave);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCorreo.Location = new System.Drawing.Point(124, 195);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(250, 21);
            this.TBCorreo.TabIndex = 13;
            this.TBCorreo.Enter += new System.EventHandler(this.TBCorreo_Enter);
            this.TBCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCorreo_KeyUp);
            this.TBCorreo.Leave += new System.EventHandler(this.TBCorreo_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad de Resid.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo Electronico";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCiudad.Location = new System.Drawing.Point(124, 114);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(250, 21);
            this.TBCiudad.TabIndex = 5;
            this.TBCiudad.Enter += new System.EventHandler(this.TBCiudad_Enter);
            this.TBCiudad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCiudad_KeyUp);
            this.TBCiudad.Leave += new System.EventHandler(this.TBCiudad_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fijo Principal";
            // 
            // TBFijo
            // 
            this.TBFijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBFijo.Location = new System.Drawing.Point(124, 141);
            this.TBFijo.Name = "TBFijo";
            this.TBFijo.Size = new System.Drawing.Size(250, 21);
            this.TBFijo.TabIndex = 7;
            this.TBFijo.Enter += new System.EventHandler(this.TBFijo_Enter);
            this.TBFijo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBFijo_KeyUp);
            this.TBFijo.Leave += new System.EventHandler(this.TBFijo_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movil Principal";
            // 
            // TBMovil
            // 
            this.TBMovil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBMovil.Location = new System.Drawing.Point(124, 168);
            this.TBMovil.Name = "TBMovil";
            this.TBMovil.Size = new System.Drawing.Size(250, 21);
            this.TBMovil.TabIndex = 8;
            this.TBMovil.Enter += new System.EventHandler(this.TBMovil_Enter);
            this.TBMovil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMovil_KeyUp);
            this.TBMovil.Leave += new System.EventHandler(this.TBMovil_Leave);
            // 
            // TPDatosFinancieros
            // 
            this.TPDatosFinancieros.Controls.Add(this.label6);
            this.TPDatosFinancieros.Controls.Add(this.TBCargo);
            this.TPDatosFinancieros.Controls.Add(this.TBProfesion);
            this.TPDatosFinancieros.Controls.Add(this.label17);
            this.TPDatosFinancieros.Controls.Add(this.CBDepartamento);
            this.TPDatosFinancieros.Controls.Add(this.label16);
            this.TPDatosFinancieros.Controls.Add(this.label15);
            this.TPDatosFinancieros.Controls.Add(this.TBCuentaAuxiliar);
            this.TPDatosFinancieros.Controls.Add(this.CBBancoAuxiliar);
            this.TPDatosFinancieros.Controls.Add(this.label14);
            this.TPDatosFinancieros.Controls.Add(this.CBBancoPrincipal);
            this.TPDatosFinancieros.Controls.Add(this.label13);
            this.TPDatosFinancieros.Controls.Add(this.TBDescuento);
            this.TPDatosFinancieros.Controls.Add(this.label20);
            this.TPDatosFinancieros.Controls.Add(this.TBComision);
            this.TPDatosFinancieros.Controls.Add(this.label19);
            this.TPDatosFinancieros.Controls.Add(this.label9);
            this.TPDatosFinancieros.Controls.Add(this.TBCuentaPrincipal);
            this.TPDatosFinancieros.Location = new System.Drawing.Point(4, 24);
            this.TPDatosFinancieros.Name = "TPDatosFinancieros";
            this.TPDatosFinancieros.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosFinancieros.Size = new System.Drawing.Size(383, 280);
            this.TPDatosFinancieros.TabIndex = 1;
            this.TPDatosFinancieros.Text = "Datos Financieros - Otros";
            this.TPDatosFinancieros.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cargo a Ejercer";
            // 
            // TBCargo
            // 
            this.TBCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCargo.Location = new System.Drawing.Point(122, 87);
            this.TBCargo.Name = "TBCargo";
            this.TBCargo.Size = new System.Drawing.Size(250, 21);
            this.TBCargo.TabIndex = 30;
            this.TBCargo.Enter += new System.EventHandler(this.TBCargo_Enter);
            this.TBCargo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCargo_KeyUp);
            this.TBCargo.Leave += new System.EventHandler(this.TBCargo_Leave);
            // 
            // TBProfesion
            // 
            this.TBProfesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBProfesion.Location = new System.Drawing.Point(122, 60);
            this.TBProfesion.Name = "TBProfesion";
            this.TBProfesion.Size = new System.Drawing.Size(250, 21);
            this.TBProfesion.TabIndex = 29;
            this.TBProfesion.Enter += new System.EventHandler(this.TBProfesion_Enter);
            this.TBProfesion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBProfesion_KeyUp);
            this.TBProfesion.Leave += new System.EventHandler(this.TBProfesion_Leave);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Profesion";
            // 
            // CBDepartamento
            // 
            this.CBDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBDepartamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDepartamento.FormattingEnabled = true;
            this.CBDepartamento.Location = new System.Drawing.Point(122, 226);
            this.CBDepartamento.Name = "CBDepartamento";
            this.CBDepartamento.Size = new System.Drawing.Size(250, 23);
            this.CBDepartamento.Sorted = true;
            this.CBDepartamento.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Departamento";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Nº de Cuenta Aux.";
            // 
            // TBCuentaAuxiliar
            // 
            this.TBCuentaAuxiliar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCuentaAuxiliar.Location = new System.Drawing.Point(122, 141);
            this.TBCuentaAuxiliar.Name = "TBCuentaAuxiliar";
            this.TBCuentaAuxiliar.Size = new System.Drawing.Size(250, 21);
            this.TBCuentaAuxiliar.TabIndex = 24;
            this.TBCuentaAuxiliar.Enter += new System.EventHandler(this.TBCuentaAuxiliar_Enter);
            this.TBCuentaAuxiliar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCuentaAuxiliar_KeyUp);
            this.TBCuentaAuxiliar.Leave += new System.EventHandler(this.TBCuentaAuxiliar_Leave);
            // 
            // CBBancoAuxiliar
            // 
            this.CBBancoAuxiliar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBBancoAuxiliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBancoAuxiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBancoAuxiliar.FormattingEnabled = true;
            this.CBBancoAuxiliar.Items.AddRange(new object[] {
            "-",
            "Banco Agrario de Colombia",
            "Banco AV Villas",
            "Banco Caja Social",
            "Banco de Bogotá",
            "Banco de Occidente (Colombia)",
            "Banco Popular (Colombia)",
            "Bancóldex",
            "Bancolombia",
            "BBVA Colombia",
            "Citi Colombia",
            "Colpatria",
            "Davivienda",
            "GNB Sudameris"});
            this.CBBancoAuxiliar.Location = new System.Drawing.Point(122, 197);
            this.CBBancoAuxiliar.Name = "CBBancoAuxiliar";
            this.CBBancoAuxiliar.Size = new System.Drawing.Size(250, 23);
            this.CBBancoAuxiliar.Sorted = true;
            this.CBBancoAuxiliar.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Banco Auxiliar";
            // 
            // CBBancoPrincipal
            // 
            this.CBBancoPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBBancoPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBancoPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBancoPrincipal.FormattingEnabled = true;
            this.CBBancoPrincipal.Items.AddRange(new object[] {
            "-",
            "Banco Agrario de Colombia",
            "Banco AV Villas",
            "Banco Caja Social",
            "Banco de Bogotá",
            "Banco de Occidente (Colombia)",
            "Banco Popular (Colombia)",
            "Bancóldex",
            "Bancolombia",
            "BBVA Colombia",
            "Citi Colombia",
            "Colpatria",
            "Davivienda",
            "GNB Sudameris"});
            this.CBBancoPrincipal.Location = new System.Drawing.Point(122, 168);
            this.CBBancoPrincipal.Name = "CBBancoPrincipal";
            this.CBBancoPrincipal.Size = new System.Drawing.Size(250, 23);
            this.CBBancoPrincipal.Sorted = true;
            this.CBBancoPrincipal.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Banco Principal";
            // 
            // TBDescuento
            // 
            this.TBDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDescuento.Location = new System.Drawing.Point(122, 33);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.Size = new System.Drawing.Size(250, 21);
            this.TBDescuento.TabIndex = 19;
            this.TBDescuento.Enter += new System.EventHandler(this.TBDescuento_Enter);
            this.TBDescuento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescuento_KeyUp);
            this.TBDescuento.Leave += new System.EventHandler(this.TBDescuento_Leave);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "Descu. de Compra";
            // 
            // TBComision
            // 
            this.TBComision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBComision.Location = new System.Drawing.Point(122, 6);
            this.TBComision.Name = "TBComision";
            this.TBComision.Size = new System.Drawing.Size(250, 21);
            this.TBComision.TabIndex = 17;
            this.TBComision.Enter += new System.EventHandler(this.TBComision_Enter);
            this.TBComision.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBComision_KeyUp);
            this.TBComision.Leave += new System.EventHandler(this.TBComision_Leave);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "Comision de Venta";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nº de Cuenta Prin.";
            // 
            // TBCuentaPrincipal
            // 
            this.TBCuentaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCuentaPrincipal.Location = new System.Drawing.Point(122, 114);
            this.TBCuentaPrincipal.Name = "TBCuentaPrincipal";
            this.TBCuentaPrincipal.Size = new System.Drawing.Size(250, 21);
            this.TBCuentaPrincipal.TabIndex = 14;
            this.TBCuentaPrincipal.Enter += new System.EventHandler(this.TBCuentaPrincipal_Enter);
            this.TBCuentaPrincipal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCuentaPrincipal_KeyUp);
            this.TBCuentaPrincipal.Leave += new System.EventHandler(this.TBCuentaPrincipal_Leave);
            // 
            // TPConsulta
            // 
            this.TPConsulta.Controls.Add(this.TBBuscar);
            this.TPConsulta.Controls.Add(this.label2);
            this.TPConsulta.Controls.Add(this.lblTotal);
            this.TPConsulta.Controls.Add(this.DGResultados);
            this.TPConsulta.Location = new System.Drawing.Point(4, 24);
            this.TPConsulta.Name = "TPConsulta";
            this.TPConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TPConsulta.Size = new System.Drawing.Size(383, 280);
            this.TPConsulta.TabIndex = 2;
            this.TPConsulta.Text = "Consulta";
            this.TPConsulta.UseVisualStyleBackColor = true;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBBuscar.Location = new System.Drawing.Point(141, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(233, 21);
            this.TBBuscar.TabIndex = 3;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            this.TBBuscar.Enter += new System.EventHandler(this.TBBuscar_Enter);
            this.TBBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscar_KeyUp);
            this.TBBuscar.Leave += new System.EventHandler(this.TBBuscar_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado a Consultar";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 262);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "------";
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 33);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(368, 226);
            this.DGResultados.TabIndex = 0;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.BV_Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(93, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(11, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 392);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Empleados - Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TCPrincipal.ResumeLayout(false);
            this.TPDatosBasicos.ResumeLayout(false);
            this.TPDatosBasicos.PerformLayout();
            this.TPDatosFinancieros.ResumeLayout(false);
            this.TPDatosFinancieros.PerformLayout();
            this.TPConsulta.ResumeLayout(false);
            this.TPConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBIdempleado;
        private System.Windows.Forms.TabControl TCPrincipal;
        private System.Windows.Forms.TabPage TPDatosBasicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBEmpleado;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBFijo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBMovil;
        private System.Windows.Forms.TabPage TPDatosFinancieros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.TabPage TPConsulta;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBCuentaPrincipal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBDireccion02;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBDireccion01;
        private System.Windows.Forms.TextBox TBComision;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TBDescuento;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CBBancoAuxiliar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CBBancoPrincipal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBCuentaAuxiliar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CBDepartamento;
        private System.Windows.Forms.TextBox TBProfesion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBCargo;
    }
}