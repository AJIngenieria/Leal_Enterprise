namespace Presentacion
{
    partial class frmSucurzal
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
            this.TBSucurzal = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPConsulta = new System.Windows.Forms.TabPage();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBGerente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TBNit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TBIdsucurzal = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Sucurzales";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(274, 278);
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
            this.btnEliminar.Location = new System.Drawing.Point(192, 278);
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
            this.btnCancelar.Location = new System.Drawing.Point(88, 278);
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
            this.btnGuardar.Location = new System.Drawing.Point(6, 278);
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
            this.TCPrincipal.Size = new System.Drawing.Size(348, 252);
            this.TCPrincipal.TabIndex = 0;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBIdsucurzal);
            this.TPDatosBasicos.Controls.Add(this.TBNit);
            this.TPDatosBasicos.Controls.Add(this.label8);
            this.TPDatosBasicos.Controls.Add(this.TBGerente);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.TBDireccion);
            this.TPDatosBasicos.Controls.Add(this.TBCiudad);
            this.TPDatosBasicos.Controls.Add(this.label6);
            this.TPDatosBasicos.Controls.Add(this.label5);
            this.TPDatosBasicos.Controls.Add(this.TBPais);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.TBDescripcion);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.TBSucurzal);
            this.TPDatosBasicos.Controls.Add(this.TBCodigo);
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(340, 224);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBSucurzal
            // 
            this.TBSucurzal.Location = new System.Drawing.Point(84, 33);
            this.TBSucurzal.Name = "TBSucurzal";
            this.TBSucurzal.Size = new System.Drawing.Size(250, 21);
            this.TBSucurzal.TabIndex = 3;
            this.TBSucurzal.Enter += new System.EventHandler(this.TBSucurzal_Enter);
            this.TBSucurzal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBSucurzal_KeyUp);
            this.TBSucurzal.Leave += new System.EventHandler(this.TBSucurzal_Leave);
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(84, 6);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(250, 21);
            this.TBCodigo.TabIndex = 2;
            this.TBCodigo.Enter += new System.EventHandler(this.TBCodigo_Enter);
            this.TBCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCodigo_KeyUp);
            this.TBCodigo.Leave += new System.EventHandler(this.TBCodigo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sucurzal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // TPConsulta
            // 
            this.TPConsulta.Controls.Add(this.lblTotal);
            this.TPConsulta.Controls.Add(this.label9);
            this.TPConsulta.Controls.Add(this.DGResultados);
            this.TPConsulta.Controls.Add(this.TBBuscar);
            this.TPConsulta.Location = new System.Drawing.Point(4, 24);
            this.TPConsulta.Name = "TPConsulta";
            this.TPConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TPConsulta.Size = new System.Drawing.Size(340, 224);
            this.TPConsulta.TabIndex = 1;
            this.TPConsulta.Text = "Consulta";
            this.TPConsulta.UseVisualStyleBackColor = true;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(132, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(206, 21);
            this.TBBuscar.TabIndex = 0;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(84, 87);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 21);
            this.TBDescripcion.TabIndex = 5;
            this.TBDescripcion.Enter += new System.EventHandler(this.TBDescripcion_Enter);
            this.TBDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescripcion_KeyUp);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pais";
            // 
            // TBPais
            // 
            this.TBPais.Location = new System.Drawing.Point(84, 141);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(250, 21);
            this.TBPais.TabIndex = 7;
            this.TBPais.Enter += new System.EventHandler(this.TBPais_Enter);
            this.TBPais.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBPais_KeyUp);
            this.TBPais.Leave += new System.EventHandler(this.TBPais_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Direccion";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(84, 168);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(250, 21);
            this.TBCiudad.TabIndex = 10;
            this.TBCiudad.Enter += new System.EventHandler(this.TBCiudad_Enter);
            this.TBCiudad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCiudad_KeyUp);
            this.TBCiudad.Leave += new System.EventHandler(this.TBCiudad_Leave);
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(84, 195);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion.TabIndex = 11;
            this.TBDireccion.Enter += new System.EventHandler(this.TBDireccion_Enter);
            this.TBDireccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion_KeyUp);
            this.TBDireccion.Leave += new System.EventHandler(this.TBDireccion_Leave);
            // 
            // TBGerente
            // 
            this.TBGerente.Location = new System.Drawing.Point(84, 114);
            this.TBGerente.Name = "TBGerente";
            this.TBGerente.Size = new System.Drawing.Size(250, 21);
            this.TBGerente.TabIndex = 13;
            this.TBGerente.Enter += new System.EventHandler(this.TBGerente_Enter);
            this.TBGerente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBGerente_KeyUp);
            this.TBGerente.Leave += new System.EventHandler(this.TBGerente_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gerente";
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
            this.DGResultados.Size = new System.Drawing.Size(332, 170);
            this.DGResultados.TabIndex = 1;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nit";
            // 
            // TBNit
            // 
            this.TBNit.Location = new System.Drawing.Point(84, 60);
            this.TBNit.Name = "TBNit";
            this.TBNit.Size = new System.Drawing.Size(250, 21);
            this.TBNit.TabIndex = 15;
            this.TBNit.Enter += new System.EventHandler(this.TBNit_Enter);
            this.TBNit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNit_KeyUp);
            this.TBNit.Leave += new System.EventHandler(this.TBNit_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sucurzal a Consultar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "------";
            // 
            // TBIdsucurzal
            // 
            this.TBIdsucurzal.Location = new System.Drawing.Point(47, 141);
            this.TBIdsucurzal.Name = "TBIdsucurzal";
            this.TBIdsucurzal.Size = new System.Drawing.Size(18, 21);
            this.TBIdsucurzal.TabIndex = 16;
            // 
            // frmSucurzal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 337);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSucurzal";
            this.Text = "Sistema - Sucurzal";
            this.Load += new System.EventHandler(this.frmSucurzal_Load);
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
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TBSucurzal;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBGerente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBNit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBIdsucurzal;
    }
}