namespace Presentacion
{
    partial class frmBodega
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
            this.TCPrincipal = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBodega = new System.Windows.Forms.TextBox();
            this.CBSucurzal = new System.Windows.Forms.ComboBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBMovil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBDirector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TPDatosAuxiliares = new System.Windows.Forms.TabPage();
            this.TBDiaDespacho = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBDireccion01 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBDireccion02 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TBMedidas = new System.Windows.Forms.TextBox();
            this.TBRecepcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TBDespacho = new System.Windows.Forms.TextBox();
            this.TBDiadepagos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TBFinalHorarioLaboral = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBInicioLaboral = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TPEquiposElectronicos = new System.Windows.Forms.TabPage();
            this.TBMontaCarga = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.TBBalanzaDigital = new System.Windows.Forms.TextBox();
            this.TBBalanzaManual = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TBMarquilladora = new System.Windows.Forms.TextBox();
            this.TBImpresoraTickets = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TBImpresoraCartucho = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TBPcportatiles = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBPcdemeza = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBCelulares = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TBImpresoraLaser = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.TBIdbodega = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.TCPrincipal.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPDatosAuxiliares.SuspendLayout();
            this.TPEquiposElectronicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TCPrincipal);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.TBIdbodega);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Bodegas";
            // 
            // TCPrincipal
            // 
            this.TCPrincipal.Controls.Add(this.TPDatosBasicos);
            this.TCPrincipal.Controls.Add(this.TPDatosAuxiliares);
            this.TCPrincipal.Controls.Add(this.TPEquiposElectronicos);
            this.TCPrincipal.Location = new System.Drawing.Point(10, 23);
            this.TCPrincipal.Name = "TCPrincipal";
            this.TCPrincipal.SelectedIndex = 0;
            this.TCPrincipal.Size = new System.Drawing.Size(409, 313);
            this.TCPrincipal.TabIndex = 42;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.label10);
            this.TPDatosBasicos.Controls.Add(this.TBDescripcion);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Controls.Add(this.TBBodega);
            this.TPDatosBasicos.Controls.Add(this.CBSucurzal);
            this.TPDatosBasicos.Controls.Add(this.TBCorreo);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.TBCiudad);
            this.TPDatosBasicos.Controls.Add(this.label6);
            this.TPDatosBasicos.Controls.Add(this.TBMovil);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.TBDirector);
            this.TPDatosBasicos.Controls.Add(this.label5);
            this.TPDatosBasicos.Controls.Add(this.TBTelefono);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(401, 285);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sucurzal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descripcion";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(84, 65);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(300, 21);
            this.TBDescripcion.TabIndex = 14;
            this.TBDescripcion.Enter += new System.EventHandler(this.TBDescripcion_Enter);
            this.TBDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescripcion_KeyUp);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega";
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(84, 38);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(300, 21);
            this.TBBodega.TabIndex = 1;
            this.TBBodega.Enter += new System.EventHandler(this.TBBodega_Enter);
            this.TBBodega.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBodega_KeyUp);
            this.TBBodega.Leave += new System.EventHandler(this.TBBodega_Leave);
            // 
            // CBSucurzal
            // 
            this.CBSucurzal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSucurzal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSucurzal.FormattingEnabled = true;
            this.CBSucurzal.Location = new System.Drawing.Point(84, 9);
            this.CBSucurzal.Name = "CBSucurzal";
            this.CBSucurzal.Size = new System.Drawing.Size(300, 23);
            this.CBSucurzal.Sorted = true;
            this.CBSucurzal.TabIndex = 3;
            this.CBSucurzal.SelectedIndexChanged += new System.EventHandler(this.CBSucurzal_SelectedIndexChanged);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(84, 200);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(300, 21);
            this.TBCorreo.TabIndex = 13;
            this.TBCorreo.Enter += new System.EventHandler(this.TBCorreo_Enter);
            this.TBCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCorreo_KeyUp);
            this.TBCorreo.Leave += new System.EventHandler(this.TBCorreo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(84, 119);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(300, 21);
            this.TBCiudad.TabIndex = 5;
            this.TBCiudad.Enter += new System.EventHandler(this.TBCiudad_Enter);
            this.TBCiudad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCiudad_KeyUp);
            this.TBCiudad.Leave += new System.EventHandler(this.TBCiudad_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Director";
            // 
            // TBMovil
            // 
            this.TBMovil.Location = new System.Drawing.Point(84, 146);
            this.TBMovil.Name = "TBMovil";
            this.TBMovil.Size = new System.Drawing.Size(300, 21);
            this.TBMovil.TabIndex = 8;
            this.TBMovil.Enter += new System.EventHandler(this.TBMovil_Enter);
            this.TBMovil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMovil_KeyUp);
            this.TBMovil.Leave += new System.EventHandler(this.TBMovil_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // TBDirector
            // 
            this.TBDirector.Location = new System.Drawing.Point(84, 92);
            this.TBDirector.Name = "TBDirector";
            this.TBDirector.Size = new System.Drawing.Size(300, 21);
            this.TBDirector.TabIndex = 10;
            this.TBDirector.Enter += new System.EventHandler(this.TBDirector_Enter);
            this.TBDirector.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDirector_KeyUp);
            this.TBDirector.Leave += new System.EventHandler(this.TBDirector_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movil";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(84, 173);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(300, 21);
            this.TBTelefono.TabIndex = 7;
            this.TBTelefono.Enter += new System.EventHandler(this.TBTelefono_Enter);
            this.TBTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBTelefono_KeyUp);
            this.TBTelefono.Leave += new System.EventHandler(this.TBTelefono_Leave);
            // 
            // TPDatosAuxiliares
            // 
            this.TPDatosAuxiliares.Controls.Add(this.TBDiaDespacho);
            this.TPDatosAuxiliares.Controls.Add(this.label28);
            this.TPDatosAuxiliares.Controls.Add(this.label11);
            this.TPDatosAuxiliares.Controls.Add(this.TBDireccion01);
            this.TPDatosAuxiliares.Controls.Add(this.label12);
            this.TPDatosAuxiliares.Controls.Add(this.TBDireccion02);
            this.TPDatosAuxiliares.Controls.Add(this.label22);
            this.TPDatosAuxiliares.Controls.Add(this.TBMedidas);
            this.TPDatosAuxiliares.Controls.Add(this.TBRecepcion);
            this.TPDatosAuxiliares.Controls.Add(this.label8);
            this.TPDatosAuxiliares.Controls.Add(this.label20);
            this.TPDatosAuxiliares.Controls.Add(this.TBDespacho);
            this.TPDatosAuxiliares.Controls.Add(this.TBDiadepagos);
            this.TPDatosAuxiliares.Controls.Add(this.label19);
            this.TPDatosAuxiliares.Controls.Add(this.TBFinalHorarioLaboral);
            this.TPDatosAuxiliares.Controls.Add(this.label9);
            this.TPDatosAuxiliares.Controls.Add(this.TBInicioLaboral);
            this.TPDatosAuxiliares.Controls.Add(this.label17);
            this.TPDatosAuxiliares.Location = new System.Drawing.Point(4, 24);
            this.TPDatosAuxiliares.Name = "TPDatosAuxiliares";
            this.TPDatosAuxiliares.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosAuxiliares.Size = new System.Drawing.Size(401, 285);
            this.TPDatosAuxiliares.TabIndex = 1;
            this.TPDatosAuxiliares.Text = "Datos Auxiliares";
            this.TPDatosAuxiliares.UseVisualStyleBackColor = true;
            // 
            // TBDiaDespacho
            // 
            this.TBDiaDespacho.Location = new System.Drawing.Point(120, 171);
            this.TBDiaDespacho.Name = "TBDiaDespacho";
            this.TBDiaDespacho.Size = new System.Drawing.Size(272, 21);
            this.TBDiaDespacho.TabIndex = 47;
            this.TBDiaDespacho.Enter += new System.EventHandler(this.TBDiaDespacho_Enter);
            this.TBDiaDespacho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDiaDespacho_KeyUp);
            this.TBDiaDespacho.Leave += new System.EventHandler(this.TBDiaDespacho_Leave);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 174);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(108, 15);
            this.label28.TabIndex = 46;
            this.label28.Text = "Dia de Despachos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Direccion 01";
            // 
            // TBDireccion01
            // 
            this.TBDireccion01.Location = new System.Drawing.Point(92, 198);
            this.TBDireccion01.Name = "TBDireccion01";
            this.TBDireccion01.Size = new System.Drawing.Size(300, 21);
            this.TBDireccion01.TabIndex = 44;
            this.TBDireccion01.Enter += new System.EventHandler(this.TBDireccion01_Enter);
            this.TBDireccion01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion01_KeyUp_1);
            this.TBDireccion01.Leave += new System.EventHandler(this.TBDireccion01_Leave_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "Direccion 02";
            // 
            // TBDireccion02
            // 
            this.TBDireccion02.Location = new System.Drawing.Point(92, 225);
            this.TBDireccion02.Name = "TBDireccion02";
            this.TBDireccion02.Size = new System.Drawing.Size(300, 21);
            this.TBDireccion02.TabIndex = 43;
            this.TBDireccion02.Enter += new System.EventHandler(this.TBDireccion02_Enter);
            this.TBDireccion02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion02_KeyUp_1);
            this.TBDireccion02.Leave += new System.EventHandler(this.TBDireccion02_Leave_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 15);
            this.label22.TabIndex = 21;
            this.label22.Text = "Recepcion";
            // 
            // TBMedidas
            // 
            this.TBMedidas.Location = new System.Drawing.Point(92, 117);
            this.TBMedidas.Name = "TBMedidas";
            this.TBMedidas.Size = new System.Drawing.Size(300, 21);
            this.TBMedidas.TabIndex = 41;
            this.TBMedidas.Enter += new System.EventHandler(this.TBMedidas_Enter);
            this.TBMedidas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMedidas_KeyUp);
            this.TBMedidas.Leave += new System.EventHandler(this.TBMedidas_Leave);
            // 
            // TBRecepcion
            // 
            this.TBRecepcion.Location = new System.Drawing.Point(92, 9);
            this.TBRecepcion.Name = "TBRecepcion";
            this.TBRecepcion.Size = new System.Drawing.Size(300, 21);
            this.TBRecepcion.TabIndex = 22;
            this.TBRecepcion.Enter += new System.EventHandler(this.TBRecepcion_Enter);
            this.TBRecepcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBRecepcion_KeyUp);
            this.TBRecepcion.Leave += new System.EventHandler(this.TBRecepcion_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Despacho";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 15);
            this.label20.TabIndex = 40;
            this.label20.Text = "Dimensiones";
            // 
            // TBDespacho
            // 
            this.TBDespacho.Location = new System.Drawing.Point(92, 36);
            this.TBDespacho.Name = "TBDespacho";
            this.TBDespacho.Size = new System.Drawing.Size(300, 21);
            this.TBDespacho.TabIndex = 24;
            this.TBDespacho.Enter += new System.EventHandler(this.TBDespacho_Enter);
            this.TBDespacho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDespacho_KeyUp);
            this.TBDespacho.Leave += new System.EventHandler(this.TBDespacho_Leave);
            // 
            // TBDiadepagos
            // 
            this.TBDiadepagos.Location = new System.Drawing.Point(92, 144);
            this.TBDiadepagos.Name = "TBDiadepagos";
            this.TBDiadepagos.Size = new System.Drawing.Size(300, 21);
            this.TBDiadepagos.TabIndex = 39;
            this.TBDiadepagos.Enter += new System.EventHandler(this.TBDiadepagos_Enter);
            this.TBDiadepagos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDiadepagos_KeyUp);
            this.TBDiadepagos.Leave += new System.EventHandler(this.TBDiadepagos_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "Dia de Pagos";
            // 
            // TBFinalHorarioLaboral
            // 
            this.TBFinalHorarioLaboral.Location = new System.Drawing.Point(92, 90);
            this.TBFinalHorarioLaboral.Name = "TBFinalHorarioLaboral";
            this.TBFinalHorarioLaboral.Size = new System.Drawing.Size(300, 21);
            this.TBFinalHorarioLaboral.TabIndex = 37;
            this.TBFinalHorarioLaboral.Enter += new System.EventHandler(this.TBFinalHorarioLaboral_Enter);
            this.TBFinalHorarioLaboral.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBFinalHorarioLaboral_KeyUp);
            this.TBFinalHorarioLaboral.Leave += new System.EventHandler(this.TBFinalHorarioLaboral_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fin Horario";
            // 
            // TBInicioLaboral
            // 
            this.TBInicioLaboral.Location = new System.Drawing.Point(92, 63);
            this.TBInicioLaboral.Name = "TBInicioLaboral";
            this.TBInicioLaboral.Size = new System.Drawing.Size(300, 21);
            this.TBInicioLaboral.TabIndex = 35;
            this.TBInicioLaboral.Enter += new System.EventHandler(this.TBInicioLaboral_Enter);
            this.TBInicioLaboral.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBInicioLaboral_KeyUp);
            this.TBInicioLaboral.Leave += new System.EventHandler(this.TBInicioLaboral_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Inicio Horario";
            // 
            // TPEquiposElectronicos
            // 
            this.TPEquiposElectronicos.Controls.Add(this.TBMontaCarga);
            this.TPEquiposElectronicos.Controls.Add(this.label27);
            this.TPEquiposElectronicos.Controls.Add(this.label26);
            this.TPEquiposElectronicos.Controls.Add(this.TBBalanzaDigital);
            this.TPEquiposElectronicos.Controls.Add(this.TBBalanzaManual);
            this.TPEquiposElectronicos.Controls.Add(this.label18);
            this.TPEquiposElectronicos.Controls.Add(this.label25);
            this.TPEquiposElectronicos.Controls.Add(this.TBMarquilladora);
            this.TPEquiposElectronicos.Controls.Add(this.TBImpresoraTickets);
            this.TPEquiposElectronicos.Controls.Add(this.label24);
            this.TPEquiposElectronicos.Controls.Add(this.label23);
            this.TPEquiposElectronicos.Controls.Add(this.TBImpresoraCartucho);
            this.TPEquiposElectronicos.Controls.Add(this.label13);
            this.TPEquiposElectronicos.Controls.Add(this.TBPcportatiles);
            this.TPEquiposElectronicos.Controls.Add(this.label14);
            this.TPEquiposElectronicos.Controls.Add(this.TBPcdemeza);
            this.TPEquiposElectronicos.Controls.Add(this.label15);
            this.TPEquiposElectronicos.Controls.Add(this.TBCelulares);
            this.TPEquiposElectronicos.Controls.Add(this.label16);
            this.TPEquiposElectronicos.Controls.Add(this.TBImpresoraLaser);
            this.TPEquiposElectronicos.Location = new System.Drawing.Point(4, 24);
            this.TPEquiposElectronicos.Name = "TPEquiposElectronicos";
            this.TPEquiposElectronicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPEquiposElectronicos.Size = new System.Drawing.Size(401, 285);
            this.TPEquiposElectronicos.TabIndex = 2;
            this.TPEquiposElectronicos.Text = "Equipos Electronicos";
            this.TPEquiposElectronicos.UseVisualStyleBackColor = true;
            // 
            // TBMontaCarga
            // 
            this.TBMontaCarga.Location = new System.Drawing.Point(121, 249);
            this.TBMontaCarga.Name = "TBMontaCarga";
            this.TBMontaCarga.Size = new System.Drawing.Size(274, 21);
            this.TBMontaCarga.TabIndex = 65;
            this.TBMontaCarga.Enter += new System.EventHandler(this.TBMontaCarga_Enter);
            this.TBMontaCarga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMontaCarga_KeyUp);
            this.TBMontaCarga.Leave += new System.EventHandler(this.TBMontaCarga_Leave);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 252);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 15);
            this.label27.TabIndex = 64;
            this.label27.Text = "Monta Carga";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 198);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 15);
            this.label26.TabIndex = 63;
            this.label26.Text = "Balanzas Digitales";
            // 
            // TBBalanzaDigital
            // 
            this.TBBalanzaDigital.Location = new System.Drawing.Point(121, 195);
            this.TBBalanzaDigital.Name = "TBBalanzaDigital";
            this.TBBalanzaDigital.Size = new System.Drawing.Size(274, 21);
            this.TBBalanzaDigital.TabIndex = 62;
            this.TBBalanzaDigital.Enter += new System.EventHandler(this.TBBalanzaDigital_Enter);
            this.TBBalanzaDigital.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBalanzaDigital_KeyUp);
            this.TBBalanzaDigital.Leave += new System.EventHandler(this.TBBalanzaDigital_Leave);
            // 
            // TBBalanzaManual
            // 
            this.TBBalanzaManual.Location = new System.Drawing.Point(121, 222);
            this.TBBalanzaManual.Name = "TBBalanzaManual";
            this.TBBalanzaManual.Size = new System.Drawing.Size(274, 21);
            this.TBBalanzaManual.TabIndex = 60;
            this.TBBalanzaManual.Enter += new System.EventHandler(this.TBBalanzaManual_Enter);
            this.TBBalanzaManual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBalanzaManual_KeyUp);
            this.TBBalanzaManual.Leave += new System.EventHandler(this.TBBalanzaManual_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 15);
            this.label18.TabIndex = 61;
            this.label18.Text = "Balanza Manual";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 144);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 15);
            this.label25.TabIndex = 49;
            this.label25.Text = "Marquilladora";
            // 
            // TBMarquilladora
            // 
            this.TBMarquilladora.Location = new System.Drawing.Point(121, 141);
            this.TBMarquilladora.Name = "TBMarquilladora";
            this.TBMarquilladora.Size = new System.Drawing.Size(274, 21);
            this.TBMarquilladora.TabIndex = 48;
            this.TBMarquilladora.Enter += new System.EventHandler(this.TBMarquilladora_Enter);
            this.TBMarquilladora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMarquilladora_KeyUp);
            this.TBMarquilladora.Leave += new System.EventHandler(this.TBMarquilladora_Leave);
            // 
            // TBImpresoraTickets
            // 
            this.TBImpresoraTickets.Location = new System.Drawing.Point(121, 114);
            this.TBImpresoraTickets.Name = "TBImpresoraTickets";
            this.TBImpresoraTickets.Size = new System.Drawing.Size(274, 21);
            this.TBImpresoraTickets.TabIndex = 47;
            this.TBImpresoraTickets.Enter += new System.EventHandler(this.TBImpresoraTickets_Enter);
            this.TBImpresoraTickets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBImpresoraTickets_KeyUp);
            this.TBImpresoraTickets.Leave += new System.EventHandler(this.TBImpresoraTickets_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 15);
            this.label24.TabIndex = 46;
            this.label24.Text = "Impr. de Ticketes";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 15);
            this.label23.TabIndex = 45;
            this.label23.Text = "Impr. de Cartucho";
            // 
            // TBImpresoraCartucho
            // 
            this.TBImpresoraCartucho.Location = new System.Drawing.Point(121, 87);
            this.TBImpresoraCartucho.Name = "TBImpresoraCartucho";
            this.TBImpresoraCartucho.Size = new System.Drawing.Size(274, 21);
            this.TBImpresoraCartucho.TabIndex = 44;
            this.TBImpresoraCartucho.Enter += new System.EventHandler(this.TBImpresoraCartucho_Enter);
            this.TBImpresoraCartucho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBImpresoraCartucho_KeyUp);
            this.TBImpresoraCartucho.Leave += new System.EventHandler(this.TBImpresoraCartucho_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 43;
            this.label13.Text = "PC Portatil";
            // 
            // TBPcportatiles
            // 
            this.TBPcportatiles.Location = new System.Drawing.Point(121, 33);
            this.TBPcportatiles.Name = "TBPcportatiles";
            this.TBPcportatiles.Size = new System.Drawing.Size(274, 21);
            this.TBPcportatiles.TabIndex = 42;
            this.TBPcportatiles.Enter += new System.EventHandler(this.TBPcportatiles_Enter);
            this.TBPcportatiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBPcportatiles_KeyUp);
            this.TBPcportatiles.Leave += new System.EventHandler(this.TBPcportatiles_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "PC de Meza";
            // 
            // TBPcdemeza
            // 
            this.TBPcdemeza.Location = new System.Drawing.Point(121, 6);
            this.TBPcdemeza.Name = "TBPcdemeza";
            this.TBPcdemeza.Size = new System.Drawing.Size(274, 21);
            this.TBPcdemeza.TabIndex = 35;
            this.TBPcdemeza.Enter += new System.EventHandler(this.TBPcdemeza_Enter);
            this.TBPcdemeza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBPcdemeza_KeyUp);
            this.TBPcdemeza.Leave += new System.EventHandler(this.TBPcdemeza_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Celulares";
            // 
            // TBCelulares
            // 
            this.TBCelulares.Location = new System.Drawing.Point(121, 168);
            this.TBCelulares.Name = "TBCelulares";
            this.TBCelulares.Size = new System.Drawing.Size(274, 21);
            this.TBCelulares.TabIndex = 37;
            this.TBCelulares.Enter += new System.EventHandler(this.TBCelulares_Enter);
            this.TBCelulares.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCelulares_KeyUp);
            this.TBCelulares.Leave += new System.EventHandler(this.TBCelulares_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Impresora Laser";
            // 
            // TBImpresoraLaser
            // 
            this.TBImpresoraLaser.Location = new System.Drawing.Point(121, 60);
            this.TBImpresoraLaser.Name = "TBImpresoraLaser";
            this.TBImpresoraLaser.Size = new System.Drawing.Size(274, 21);
            this.TBImpresoraLaser.TabIndex = 39;
            this.TBImpresoraLaser.Enter += new System.EventHandler(this.TBImpresoraLaser_Enter);
            this.TBImpresoraLaser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBImpresoraLaser_KeyUp);
            this.TBImpresoraLaser.Leave += new System.EventHandler(this.TBImpresoraLaser_Leave);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(339, 342);
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
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(257, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(6, 342);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.BV_Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(88, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // TBIdbodega
            // 
            this.TBIdbodega.Location = new System.Drawing.Point(170, 345);
            this.TBIdbodega.Name = "TBIdbodega";
            this.TBIdbodega.Size = new System.Drawing.Size(29, 21);
            this.TBIdbodega.TabIndex = 31;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 348);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "------";
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 47);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(500, 298);
            this.DGResultados.TabIndex = 2;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(127, 20);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(379, 21);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            this.TBBuscar.Enter += new System.EventHandler(this.TBBuscar_Enter);
            this.TBBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscar_KeyUp);
            this.TBBuscar.Leave += new System.EventHandler(this.TBBuscar_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Bodega a Consultar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.DGResultados);
            this.groupBox2.Controls.Add(this.TBBuscar);
            this.groupBox2.Location = new System.Drawing.Point(444, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 374);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leal Enterprise - Consulta de Bodegas Registrados";
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen - Bodega";
            this.Load += new System.EventHandler(this.frmBodega_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TCPrincipal.ResumeLayout(false);
            this.TPDatosBasicos.ResumeLayout(false);
            this.TPDatosBasicos.PerformLayout();
            this.TPDatosAuxiliares.ResumeLayout(false);
            this.TPDatosAuxiliares.PerformLayout();
            this.TPEquiposElectronicos.ResumeLayout(false);
            this.TPEquiposElectronicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBSucurzal;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBDirector;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBMovil;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBDespacho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBRecepcion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TBMedidas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TBDiadepagos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TBFinalHorarioLaboral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBInicioLaboral;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TBIdbodega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl TCPrincipal;
        private System.Windows.Forms.TabPage TPDatosBasicos;
        private System.Windows.Forms.TabPage TPDatosAuxiliares;
        private System.Windows.Forms.TabPage TPEquiposElectronicos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBPcdemeza;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBCelulares;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TBImpresoraLaser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBDireccion02;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBDireccion01;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBPcportatiles;
        private System.Windows.Forms.TextBox TBImpresoraTickets;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TBImpresoraCartucho;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TBMarquilladora;
        private System.Windows.Forms.TextBox TBMontaCarga;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TBBalanzaDigital;
        private System.Windows.Forms.TextBox TBBalanzaManual;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBDiaDespacho;
        private System.Windows.Forms.Label label28;
    }
}