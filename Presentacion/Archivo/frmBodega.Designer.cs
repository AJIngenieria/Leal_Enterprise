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
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
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
            this.btnEliminar_Ubicacion = new System.Windows.Forms.Button();
            this.btnAgregar_Ubicacion = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TBElectronicos_Descripcion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBElectronicos_Tipo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBElectronicos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DGDetalle_Equipos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TBIdbodega = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.TBIddetalle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.TCPrincipal.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPDatosAuxiliares.SuspendLayout();
            this.TPEquiposElectronicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle_Equipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBIddetalle);
            this.groupBox1.Controls.Add(this.TCPrincipal);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.TBIdbodega);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 403);
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
            this.TCPrincipal.Size = new System.Drawing.Size(348, 338);
            this.TCPrincipal.TabIndex = 42;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBDocumento);
            this.TPDatosBasicos.Controls.Add(this.label29);
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
            this.TPDatosBasicos.Size = new System.Drawing.Size(340, 310);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBDocumento
            // 
            this.TBDocumento.Location = new System.Drawing.Point(85, 63);
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(250, 21);
            this.TBDocumento.TabIndex = 17;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 15);
            this.label29.TabIndex = 16;
            this.label29.Text = "Documento";
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
            this.label10.Location = new System.Drawing.Point(7, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descripcion";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(85, 90);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 21);
            this.TBDescripcion.TabIndex = 14;
            this.TBDescripcion.Enter += new System.EventHandler(this.TBDescripcion_Enter);
            this.TBDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescripcion_KeyUp);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega";
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(84, 36);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(250, 21);
            this.TBBodega.TabIndex = 1;
            this.TBBodega.Enter += new System.EventHandler(this.TBBodega_Enter);
            this.TBBodega.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBodega_KeyUp);
            this.TBBodega.Leave += new System.EventHandler(this.TBBodega_Leave);
            // 
            // CBSucurzal
            // 
            this.CBSucurzal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSucurzal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSucurzal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSucurzal.FormattingEnabled = true;
            this.CBSucurzal.Location = new System.Drawing.Point(84, 9);
            this.CBSucurzal.Name = "CBSucurzal";
            this.CBSucurzal.Size = new System.Drawing.Size(251, 21);
            this.CBSucurzal.Sorted = true;
            this.CBSucurzal.TabIndex = 3;
            this.CBSucurzal.SelectedIndexChanged += new System.EventHandler(this.CBSucurzal_SelectedIndexChanged);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(85, 225);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(250, 21);
            this.TBCorreo.TabIndex = 13;
            this.TBCorreo.Enter += new System.EventHandler(this.TBCorreo_Enter);
            this.TBCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCorreo_KeyUp);
            this.TBCorreo.Leave += new System.EventHandler(this.TBCorreo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(85, 144);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(250, 21);
            this.TBCiudad.TabIndex = 5;
            this.TBCiudad.Enter += new System.EventHandler(this.TBCiudad_Enter);
            this.TBCiudad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCiudad_KeyUp);
            this.TBCiudad.Leave += new System.EventHandler(this.TBCiudad_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Director";
            // 
            // TBMovil
            // 
            this.TBMovil.Location = new System.Drawing.Point(85, 171);
            this.TBMovil.Name = "TBMovil";
            this.TBMovil.Size = new System.Drawing.Size(250, 21);
            this.TBMovil.TabIndex = 8;
            this.TBMovil.Enter += new System.EventHandler(this.TBMovil_Enter);
            this.TBMovil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMovil_KeyUp);
            this.TBMovil.Leave += new System.EventHandler(this.TBMovil_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // TBDirector
            // 
            this.TBDirector.Location = new System.Drawing.Point(85, 117);
            this.TBDirector.Name = "TBDirector";
            this.TBDirector.Size = new System.Drawing.Size(250, 21);
            this.TBDirector.TabIndex = 10;
            this.TBDirector.Enter += new System.EventHandler(this.TBDirector_Enter);
            this.TBDirector.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDirector_KeyUp);
            this.TBDirector.Leave += new System.EventHandler(this.TBDirector_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movil";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(85, 198);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(250, 21);
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
            this.TPDatosAuxiliares.Size = new System.Drawing.Size(340, 310);
            this.TPDatosAuxiliares.TabIndex = 1;
            this.TPDatosAuxiliares.Text = "Datos Auxiliares";
            this.TPDatosAuxiliares.UseVisualStyleBackColor = true;
            // 
            // TBDiaDespacho
            // 
            this.TBDiaDespacho.Location = new System.Drawing.Point(120, 171);
            this.TBDiaDespacho.Name = "TBDiaDespacho";
            this.TBDiaDespacho.Size = new System.Drawing.Size(214, 21);
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
            this.TBDireccion01.Size = new System.Drawing.Size(242, 21);
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
            this.TBDireccion02.Size = new System.Drawing.Size(242, 21);
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
            this.TBMedidas.Size = new System.Drawing.Size(242, 21);
            this.TBMedidas.TabIndex = 41;
            this.TBMedidas.Enter += new System.EventHandler(this.TBMedidas_Enter);
            this.TBMedidas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMedidas_KeyUp);
            this.TBMedidas.Leave += new System.EventHandler(this.TBMedidas_Leave);
            // 
            // TBRecepcion
            // 
            this.TBRecepcion.Location = new System.Drawing.Point(92, 9);
            this.TBRecepcion.Name = "TBRecepcion";
            this.TBRecepcion.Size = new System.Drawing.Size(242, 21);
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
            this.TBDespacho.Size = new System.Drawing.Size(242, 21);
            this.TBDespacho.TabIndex = 24;
            this.TBDespacho.Enter += new System.EventHandler(this.TBDespacho_Enter);
            this.TBDespacho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDespacho_KeyUp);
            this.TBDespacho.Leave += new System.EventHandler(this.TBDespacho_Leave);
            // 
            // TBDiadepagos
            // 
            this.TBDiadepagos.Location = new System.Drawing.Point(92, 144);
            this.TBDiadepagos.Name = "TBDiadepagos";
            this.TBDiadepagos.Size = new System.Drawing.Size(242, 21);
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
            this.TBFinalHorarioLaboral.Size = new System.Drawing.Size(242, 21);
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
            this.TBInicioLaboral.Size = new System.Drawing.Size(242, 21);
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
            this.TPEquiposElectronicos.Controls.Add(this.btnEliminar_Ubicacion);
            this.TPEquiposElectronicos.Controls.Add(this.btnAgregar_Ubicacion);
            this.TPEquiposElectronicos.Controls.Add(this.label16);
            this.TPEquiposElectronicos.Controls.Add(this.TBElectronicos_Descripcion);
            this.TPEquiposElectronicos.Controls.Add(this.label15);
            this.TPEquiposElectronicos.Controls.Add(this.TBElectronicos_Tipo);
            this.TPEquiposElectronicos.Controls.Add(this.label14);
            this.TPEquiposElectronicos.Controls.Add(this.TBElectronicos);
            this.TPEquiposElectronicos.Controls.Add(this.label13);
            this.TPEquiposElectronicos.Controls.Add(this.DGDetalle_Equipos);
            this.TPEquiposElectronicos.Location = new System.Drawing.Point(4, 24);
            this.TPEquiposElectronicos.Name = "TPEquiposElectronicos";
            this.TPEquiposElectronicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPEquiposElectronicos.Size = new System.Drawing.Size(340, 310);
            this.TPEquiposElectronicos.TabIndex = 2;
            this.TPEquiposElectronicos.Text = "Equipos - Herramientas";
            this.TPEquiposElectronicos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar_Ubicacion
            // 
            this.btnEliminar_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar_Ubicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_Ubicacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar_Ubicacion.FlatAppearance.BorderSize = 0;
            this.btnEliminar_Ubicacion.Image = global::Presentacion.Botones.btnEliminar;
            this.btnEliminar_Ubicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar_Ubicacion.Location = new System.Drawing.Point(244, 274);
            this.btnEliminar_Ubicacion.Name = "btnEliminar_Ubicacion";
            this.btnEliminar_Ubicacion.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar_Ubicacion.TabIndex = 60;
            this.btnEliminar_Ubicacion.Text = "Eliminar";
            this.btnEliminar_Ubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar_Ubicacion.UseVisualStyleBackColor = true;
            this.btnEliminar_Ubicacion.Click += new System.EventHandler(this.btnEliminar_Ubicacion_Click);
            // 
            // btnAgregar_Ubicacion
            // 
            this.btnAgregar_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar_Ubicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_Ubicacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar_Ubicacion.FlatAppearance.BorderSize = 0;
            this.btnAgregar_Ubicacion.Image = global::Presentacion.Botones.btnAgregar;
            this.btnAgregar_Ubicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar_Ubicacion.Location = new System.Drawing.Point(148, 274);
            this.btnAgregar_Ubicacion.Name = "btnAgregar_Ubicacion";
            this.btnAgregar_Ubicacion.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar_Ubicacion.TabIndex = 59;
            this.btnAgregar_Ubicacion.Text = "Agregar";
            this.btnAgregar_Ubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar_Ubicacion.UseVisualStyleBackColor = true;
            this.btnAgregar_Ubicacion.Click += new System.EventHandler(this.btnAgregar_Ubicacion_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Datos Registrados";
            // 
            // TBElectronicos_Descripcion
            // 
            this.TBElectronicos_Descripcion.Location = new System.Drawing.Point(84, 60);
            this.TBElectronicos_Descripcion.Name = "TBElectronicos_Descripcion";
            this.TBElectronicos_Descripcion.Size = new System.Drawing.Size(250, 21);
            this.TBElectronicos_Descripcion.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Descripción";
            // 
            // TBElectronicos_Tipo
            // 
            this.TBElectronicos_Tipo.Location = new System.Drawing.Point(84, 33);
            this.TBElectronicos_Tipo.Name = "TBElectronicos_Tipo";
            this.TBElectronicos_Tipo.Size = new System.Drawing.Size(250, 21);
            this.TBElectronicos_Tipo.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Tipo";
            // 
            // TBElectronicos
            // 
            this.TBElectronicos.Location = new System.Drawing.Point(84, 6);
            this.TBElectronicos.Name = "TBElectronicos";
            this.TBElectronicos.Size = new System.Drawing.Size(250, 21);
            this.TBElectronicos.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombre";
            // 
            // DGDetalle_Equipos
            // 
            this.DGDetalle_Equipos.AllowUserToAddRows = false;
            this.DGDetalle_Equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGDetalle_Equipos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGDetalle_Equipos.BackgroundColor = System.Drawing.Color.White;
            this.DGDetalle_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalle_Equipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGDetalle_Equipos.Location = new System.Drawing.Point(6, 87);
            this.DGDetalle_Equipos.Name = "DGDetalle_Equipos";
            this.DGDetalle_Equipos.ReadOnly = true;
            this.DGDetalle_Equipos.Size = new System.Drawing.Size(328, 181);
            this.DGDetalle_Equipos.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Presentacion.Botones.btnCancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(268, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Botones.btnGuardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(10, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TBIdbodega
            // 
            this.TBIdbodega.Location = new System.Drawing.Point(202, 370);
            this.TBIdbodega.Name = "TBIdbodega";
            this.TBIdbodega.Size = new System.Drawing.Size(29, 21);
            this.TBIdbodega.TabIndex = 31;
            this.TBIdbodega.TextChanged += new System.EventHandler(this.TBIdbodega_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 375);
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
            this.DGResultados.Size = new System.Drawing.Size(500, 314);
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
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.DGResultados);
            this.groupBox2.Controls.Add(this.TBBuscar);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 403);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leal Enterprise - Consulta de Bodegas Registrados";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Botones.btnEliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(322, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Presentacion.Botones.btnImprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(418, 367);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 30);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // TBIddetalle
            // 
            this.TBIddetalle.Location = new System.Drawing.Point(106, 369);
            this.TBIddetalle.Name = "TBIddetalle";
            this.TBIddetalle.Size = new System.Drawing.Size(65, 21);
            this.TBIddetalle.TabIndex = 18;
            this.TBIddetalle.TextChanged += new System.EventHandler(this.TBIddetalle_TextChanged);
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 427);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle_Equipos)).EndInit();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBDireccion02;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBDireccion01;
        private System.Windows.Forms.TextBox TBDiaDespacho;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox TBElectronicos_Descripcion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBElectronicos_Tipo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBElectronicos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DGDetalle_Equipos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminar_Ubicacion;
        private System.Windows.Forms.Button btnAgregar_Ubicacion;
        private System.Windows.Forms.TextBox TBIddetalle;
    }
}