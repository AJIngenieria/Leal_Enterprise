namespace Presentacion
{
    partial class frmImpuesto
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
            this.TBIdimpuesto = new System.Windows.Forms.TextBox();
            this.TBImpuesto = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBValor = new System.Windows.Forms.TextBox();
            this.TPConsulta = new System.Windows.Forms.TabPage();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(453, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Impuestos";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(365, 208);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 10;
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
            this.btnEliminar.Location = new System.Drawing.Point(283, 208);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 9;
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
            this.btnCancelar.Location = new System.Drawing.Point(92, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 8;
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
            this.btnGuardar.Location = new System.Drawing.Point(10, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 7;
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
            this.TCPrincipal.Size = new System.Drawing.Size(439, 182);
            this.TCPrincipal.TabIndex = 6;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBIdimpuesto);
            this.TPDatosBasicos.Controls.Add(this.TBImpuesto);
            this.TPDatosBasicos.Controls.Add(this.TBDescripcion);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.TBValor);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(431, 154);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBIdimpuesto
            // 
            this.TBIdimpuesto.Location = new System.Drawing.Point(175, 121);
            this.TBIdimpuesto.Name = "TBIdimpuesto";
            this.TBIdimpuesto.Size = new System.Drawing.Size(100, 21);
            this.TBIdimpuesto.TabIndex = 6;
            // 
            // TBImpuesto
            // 
            this.TBImpuesto.Location = new System.Drawing.Point(121, 40);
            this.TBImpuesto.Name = "TBImpuesto";
            this.TBImpuesto.Size = new System.Drawing.Size(250, 21);
            this.TBImpuesto.TabIndex = 2;
            this.TBImpuesto.Enter += new System.EventHandler(this.TBImpuesto_Enter);
            this.TBImpuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBImpuesto_KeyUp);
            this.TBImpuesto.Leave += new System.EventHandler(this.TBImpuesto_Leave);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(121, 94);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 21);
            this.TBDescripcion.TabIndex = 5;
            this.TBDescripcion.Enter += new System.EventHandler(this.TBDescripcion_Enter);
            this.TBDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescripcion_KeyUp);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // TBValor
            // 
            this.TBValor.Location = new System.Drawing.Point(121, 67);
            this.TBValor.Name = "TBValor";
            this.TBValor.Size = new System.Drawing.Size(250, 21);
            this.TBValor.TabIndex = 3;
            this.TBValor.Enter += new System.EventHandler(this.TBValor_Enter);
            this.TBValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBValor_KeyUp);
            this.TBValor.Leave += new System.EventHandler(this.TBValor_Leave);
            // 
            // TPConsulta
            // 
            this.TPConsulta.Controls.Add(this.DGResultados);
            this.TPConsulta.Controls.Add(this.lblTotal);
            this.TPConsulta.Controls.Add(this.TBBuscar);
            this.TPConsulta.Controls.Add(this.label4);
            this.TPConsulta.Location = new System.Drawing.Point(4, 24);
            this.TPConsulta.Name = "TPConsulta";
            this.TPConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TPConsulta.Size = new System.Drawing.Size(431, 154);
            this.TPConsulta.TabIndex = 1;
            this.TPConsulta.Text = "Consulta";
            this.TPConsulta.UseVisualStyleBackColor = true;
            // 
            // DGResultados
            // 
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 33);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(419, 100);
            this.DGResultados.TabIndex = 3;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(3, 136);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 15);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "------";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(135, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(290, 21);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Impuesto a Consultar";
            // 
            // frmImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 264);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financiera - Impuesto";
            this.Load += new System.EventHandler(this.frmImpuesto_Load);
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
        private System.Windows.Forms.TextBox TBImpuesto;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBValor;
        private System.Windows.Forms.TabPage TPConsulta;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TBIdimpuesto;
    }
}