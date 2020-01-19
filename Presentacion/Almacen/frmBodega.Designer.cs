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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.TCPrincipal = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.TBMedidas = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TBDiadepagos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TBFinalHorarioLaboral = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBInicioLaboral = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TBOtrosEquipos = new System.Windows.Forms.TextBox();
            this.TBNumeroImpresora = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TBNumeroCelular = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBNumeroPC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBDespacho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBRecepcion = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TBDireccion02 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBDireccion01 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSucurzal = new System.Windows.Forms.ComboBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBDirector = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBMovil = new System.Windows.Forms.TextBox();
            this.TPConsulta = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.TBIdbodega = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.TCPrincipal);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.TBIdbodega);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Bodegas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(571, 377);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseDown);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseMove);
            // 
            // TCPrincipal
            // 
            this.TCPrincipal.Controls.Add(this.TPDatosBasicos);
            this.TCPrincipal.Controls.Add(this.TPConsulta);
            this.TCPrincipal.Location = new System.Drawing.Point(6, 20);
            this.TCPrincipal.Name = "TCPrincipal";
            this.TCPrincipal.SelectedIndex = 0;
            this.TCPrincipal.Size = new System.Drawing.Size(651, 351);
            this.TCPrincipal.TabIndex = 2;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBMedidas);
            this.TPDatosBasicos.Controls.Add(this.label20);
            this.TPDatosBasicos.Controls.Add(this.TBDiadepagos);
            this.TPDatosBasicos.Controls.Add(this.label19);
            this.TPDatosBasicos.Controls.Add(this.TBFinalHorarioLaboral);
            this.TPDatosBasicos.Controls.Add(this.label9);
            this.TPDatosBasicos.Controls.Add(this.TBInicioLaboral);
            this.TPDatosBasicos.Controls.Add(this.label17);
            this.TPDatosBasicos.Controls.Add(this.label18);
            this.TPDatosBasicos.Controls.Add(this.TBOtrosEquipos);
            this.TPDatosBasicos.Controls.Add(this.TBNumeroImpresora);
            this.TPDatosBasicos.Controls.Add(this.label16);
            this.TPDatosBasicos.Controls.Add(this.TBNumeroCelular);
            this.TPDatosBasicos.Controls.Add(this.label15);
            this.TPDatosBasicos.Controls.Add(this.TBNumeroPC);
            this.TPDatosBasicos.Controls.Add(this.label14);
            this.TPDatosBasicos.Controls.Add(this.TBDespacho);
            this.TPDatosBasicos.Controls.Add(this.label8);
            this.TPDatosBasicos.Controls.Add(this.TBRecepcion);
            this.TPDatosBasicos.Controls.Add(this.label22);
            this.TPDatosBasicos.Controls.Add(this.label13);
            this.TPDatosBasicos.Controls.Add(this.TBDireccion02);
            this.TPDatosBasicos.Controls.Add(this.label12);
            this.TPDatosBasicos.Controls.Add(this.label11);
            this.TPDatosBasicos.Controls.Add(this.TBDireccion01);
            this.TPDatosBasicos.Controls.Add(this.label10);
            this.TPDatosBasicos.Controls.Add(this.TBDescripcion);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Controls.Add(this.TBBodega);
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.CBSucurzal);
            this.TPDatosBasicos.Controls.Add(this.TBCorreo);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.TBCiudad);
            this.TPDatosBasicos.Controls.Add(this.label6);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.TBDirector);
            this.TPDatosBasicos.Controls.Add(this.TBTelefono);
            this.TPDatosBasicos.Controls.Add(this.label5);
            this.TPDatosBasicos.Controls.Add(this.TBMovil);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(643, 323);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBMedidas
            // 
            this.TBMedidas.Location = new System.Drawing.Point(439, 293);
            this.TBMedidas.Name = "TBMedidas";
            this.TBMedidas.Size = new System.Drawing.Size(196, 21);
            this.TBMedidas.TabIndex = 41;
            this.TBMedidas.Enter += new System.EventHandler(this.TBMedidas_Enter);
            this.TBMedidas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMedidas_KeyUp);
            this.TBMedidas.Leave += new System.EventHandler(this.TBMedidas_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 296);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 15);
            this.label20.TabIndex = 40;
            this.label20.Text = "Medidas Generales";
            // 
            // TBDiadepagos
            // 
            this.TBDiadepagos.Location = new System.Drawing.Point(134, 293);
            this.TBDiadepagos.Name = "TBDiadepagos";
            this.TBDiadepagos.Size = new System.Drawing.Size(184, 21);
            this.TBDiadepagos.TabIndex = 39;
            this.TBDiadepagos.Enter += new System.EventHandler(this.TBDiadepagos_Enter);
            this.TBDiadepagos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDiadepagos_KeyUp);
            this.TBDiadepagos.Leave += new System.EventHandler(this.TBDiadepagos_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 296);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "Dia de Pagos";
            // 
            // TBFinalHorarioLaboral
            // 
            this.TBFinalHorarioLaboral.Location = new System.Drawing.Point(439, 266);
            this.TBFinalHorarioLaboral.Name = "TBFinalHorarioLaboral";
            this.TBFinalHorarioLaboral.Size = new System.Drawing.Size(196, 21);
            this.TBFinalHorarioLaboral.TabIndex = 37;
            this.TBFinalHorarioLaboral.Enter += new System.EventHandler(this.TBFinalHorarioLaboral_Enter);
            this.TBFinalHorarioLaboral.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBFinalHorarioLaboral_KeyUp);
            this.TBFinalHorarioLaboral.Leave += new System.EventHandler(this.TBFinalHorarioLaboral_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fin del Horario";
            // 
            // TBInicioLaboral
            // 
            this.TBInicioLaboral.Location = new System.Drawing.Point(134, 266);
            this.TBInicioLaboral.Name = "TBInicioLaboral";
            this.TBInicioLaboral.Size = new System.Drawing.Size(184, 21);
            this.TBInicioLaboral.TabIndex = 35;
            this.TBInicioLaboral.Enter += new System.EventHandler(this.TBInicioLaboral_Enter);
            this.TBInicioLaboral.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBInicioLaboral_KeyUp);
            this.TBInicioLaboral.Leave += new System.EventHandler(this.TBInicioLaboral_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Inicio Horario Laboral";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(325, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 15);
            this.label18.TabIndex = 33;
            this.label18.Text = "Otros Equipos";
            // 
            // TBOtrosEquipos
            // 
            this.TBOtrosEquipos.Location = new System.Drawing.Point(439, 239);
            this.TBOtrosEquipos.Name = "TBOtrosEquipos";
            this.TBOtrosEquipos.Size = new System.Drawing.Size(196, 21);
            this.TBOtrosEquipos.TabIndex = 32;
            this.TBOtrosEquipos.Enter += new System.EventHandler(this.TBOtrosEquipos_Enter);
            this.TBOtrosEquipos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBOtrosEquipos_KeyUp);
            this.TBOtrosEquipos.Leave += new System.EventHandler(this.TBOtrosEquipos_Leave);
            // 
            // TBNumeroImpresora
            // 
            this.TBNumeroImpresora.Location = new System.Drawing.Point(134, 239);
            this.TBNumeroImpresora.Name = "TBNumeroImpresora";
            this.TBNumeroImpresora.Size = new System.Drawing.Size(184, 21);
            this.TBNumeroImpresora.TabIndex = 30;
            this.TBNumeroImpresora.Enter += new System.EventHandler(this.TBNumeroImpresora_Enter);
            this.TBNumeroImpresora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNumeroImpresora_KeyUp);
            this.TBNumeroImpresora.Leave += new System.EventHandler(this.TBNumeroImpresora_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 15);
            this.label16.TabIndex = 29;
            this.label16.Text = "Num. de Impresoras";
            // 
            // TBNumeroCelular
            // 
            this.TBNumeroCelular.Location = new System.Drawing.Point(439, 212);
            this.TBNumeroCelular.Name = "TBNumeroCelular";
            this.TBNumeroCelular.Size = new System.Drawing.Size(196, 21);
            this.TBNumeroCelular.TabIndex = 28;
            this.TBNumeroCelular.Enter += new System.EventHandler(this.TBNumeroCelular_Enter);
            this.TBNumeroCelular.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNumeroCelular_KeyUp);
            this.TBNumeroCelular.Leave += new System.EventHandler(this.TBNumeroCelular_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(324, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Num. de Celulares";
            // 
            // TBNumeroPC
            // 
            this.TBNumeroPC.Location = new System.Drawing.Point(88, 212);
            this.TBNumeroPC.Name = "TBNumeroPC";
            this.TBNumeroPC.Size = new System.Drawing.Size(230, 21);
            this.TBNumeroPC.TabIndex = 26;
            this.TBNumeroPC.Enter += new System.EventHandler(this.TBNumeroPC_Enter);
            this.TBNumeroPC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNumeroPC_KeyUp);
            this.TBNumeroPC.Leave += new System.EventHandler(this.TBNumeroPC_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Num. de PC";
            // 
            // TBDespacho
            // 
            this.TBDespacho.Location = new System.Drawing.Point(385, 185);
            this.TBDespacho.Name = "TBDespacho";
            this.TBDespacho.Size = new System.Drawing.Size(250, 21);
            this.TBDespacho.TabIndex = 24;
            this.TBDespacho.Enter += new System.EventHandler(this.TBDespacho_Enter);
            this.TBDespacho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDespacho_KeyUp);
            this.TBDespacho.Leave += new System.EventHandler(this.TBDespacho_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Despacho";
            // 
            // TBRecepcion
            // 
            this.TBRecepcion.Location = new System.Drawing.Point(88, 185);
            this.TBRecepcion.Name = "TBRecepcion";
            this.TBRecepcion.Size = new System.Drawing.Size(230, 21);
            this.TBRecepcion.TabIndex = 22;
            this.TBRecepcion.Enter += new System.EventHandler(this.TBRecepcion_Enter);
            this.TBRecepcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBRecepcion_KeyUp);
            this.TBRecepcion.Leave += new System.EventHandler(this.TBRecepcion_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 188);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 15);
            this.label22.TabIndex = 21;
            this.label22.Text = "Recepcion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(631, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------------";
            // 
            // TBDireccion02
            // 
            this.TBDireccion02.Location = new System.Drawing.Point(88, 143);
            this.TBDireccion02.Name = "TBDireccion02";
            this.TBDireccion02.Size = new System.Drawing.Size(547, 21);
            this.TBDireccion02.TabIndex = 19;
            this.TBDireccion02.Enter += new System.EventHandler(this.TBDireccion02_Enter);
            this.TBDireccion02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion02_KeyUp);
            this.TBDireccion02.Leave += new System.EventHandler(this.TBDireccion02_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Direccion 02";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Direccion 01";
            // 
            // TBDireccion01
            // 
            this.TBDireccion01.Location = new System.Drawing.Point(88, 116);
            this.TBDireccion01.Name = "TBDireccion01";
            this.TBDireccion01.Size = new System.Drawing.Size(547, 21);
            this.TBDireccion01.TabIndex = 16;
            this.TBDireccion01.Enter += new System.EventHandler(this.TBDireccion01_Enter);
            this.TBDireccion01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion01_KeyUp);
            this.TBDireccion01.Leave += new System.EventHandler(this.TBDireccion01_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Descrip.";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(68, 35);
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
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega";
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(385, 9);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(250, 21);
            this.TBBodega.TabIndex = 1;
            this.TBBodega.Enter += new System.EventHandler(this.TBBodega_Enter);
            this.TBBodega.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBodega_KeyUp);
            this.TBBodega.Leave += new System.EventHandler(this.TBBodega_Leave);
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
            // CBSucurzal
            // 
            this.CBSucurzal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSucurzal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSucurzal.FormattingEnabled = true;
            this.CBSucurzal.Location = new System.Drawing.Point(68, 6);
            this.CBSucurzal.Name = "CBSucurzal";
            this.CBSucurzal.Size = new System.Drawing.Size(250, 23);
            this.CBSucurzal.Sorted = true;
            this.CBSucurzal.TabIndex = 3;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(385, 89);
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
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(68, 62);
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
            this.label6.Location = new System.Drawing.Point(324, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // TBDirector
            // 
            this.TBDirector.Location = new System.Drawing.Point(385, 35);
            this.TBDirector.Name = "TBDirector";
            this.TBDirector.Size = new System.Drawing.Size(250, 21);
            this.TBDirector.TabIndex = 10;
            this.TBDirector.Enter += new System.EventHandler(this.TBDirector_Enter);
            this.TBDirector.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDirector_KeyUp);
            this.TBDirector.Leave += new System.EventHandler(this.TBDirector_Leave);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(68, 89);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(250, 21);
            this.TBTelefono.TabIndex = 7;
            this.TBTelefono.Enter += new System.EventHandler(this.TBTelefono_Enter);
            this.TBTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBTelefono_KeyUp);
            this.TBTelefono.Leave += new System.EventHandler(this.TBTelefono_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movil";
            // 
            // TBMovil
            // 
            this.TBMovil.Location = new System.Drawing.Point(385, 62);
            this.TBMovil.Name = "TBMovil";
            this.TBMovil.Size = new System.Drawing.Size(250, 21);
            this.TBMovil.TabIndex = 8;
            this.TBMovil.Enter += new System.EventHandler(this.TBMovil_Enter);
            this.TBMovil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMovil_KeyUp);
            this.TBMovil.Leave += new System.EventHandler(this.TBMovil_Leave);
            // 
            // TPConsulta
            // 
            this.TPConsulta.Controls.Add(this.lblTotal);
            this.TPConsulta.Controls.Add(this.DGResultados);
            this.TPConsulta.Controls.Add(this.TBBuscar);
            this.TPConsulta.Controls.Add(this.label21);
            this.TPConsulta.Location = new System.Drawing.Point(4, 24);
            this.TPConsulta.Name = "TPConsulta";
            this.TPConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TPConsulta.Size = new System.Drawing.Size(643, 323);
            this.TPConsulta.TabIndex = 2;
            this.TPConsulta.Text = "Consulta";
            this.TPConsulta.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 305);
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
            this.DGResultados.Location = new System.Drawing.Point(6, 33);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(630, 269);
            this.DGResultados.TabIndex = 2;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(127, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(509, 21);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            this.TBBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscar_KeyUp);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Bodega a Consultar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(489, 377);
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
            this.btnGuardar.Location = new System.Drawing.Point(6, 377);
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
            this.btnCancelar.Location = new System.Drawing.Point(88, 377);
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
            this.TBIdbodega.Location = new System.Drawing.Point(380, 380);
            this.TBIdbodega.Name = "TBIdbodega";
            this.TBIdbodega.Size = new System.Drawing.Size(29, 21);
            this.TBIdbodega.TabIndex = 31;
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 436);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBodega";
            this.Text = "Almacen - Bodega";
            this.Load += new System.EventHandler(this.frmBodega_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox TBDireccion02;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBDireccion01;
        private System.Windows.Forms.TabPage TPConsulta;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBNumeroImpresora;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TBNumeroCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBNumeroPC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBDespacho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBRecepcion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBMedidas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TBDiadepagos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TBFinalHorarioLaboral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBInicioLaboral;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBOtrosEquipos;
        private System.Windows.Forms.TextBox TBIdbodega;
    }
}