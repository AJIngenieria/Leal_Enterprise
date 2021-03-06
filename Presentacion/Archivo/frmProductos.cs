﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;

namespace Presentacion
{
    public partial class frmProductos : Form
    {
        //Instancia para el Filtro de los productos 
        private static frmProductos _Instancia;

        public static frmProductos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProductos();
            }
            return _Instancia;
        }

        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar, Eliminar
        private bool Digitar = true;
        public bool Filtro = true;
        public bool Examinar = true;

        //Variable para Agregar los Detalles a la Base de Datos
        private DataTable DtDetalle_Lote = new DataTable();
        private DataTable DtDetalle_Impuesto = new DataTable();
        private DataTable DtDetalle_Igualdad = new DataTable();
        private DataTable DtDetalle_Ubicacion = new DataTable();
        private DataTable DtDetalle_Proveedor = new DataTable();
        private DataTable DtDetalle_CodigoDeBarra = new DataTable();

        //Variables de Validaciones
        public int Idempleado; //Variable para Captura el Empleado Logueado
        private string Campo = "Campo Obligatorio";

        //********** Variables para la Validacion de los checkbox en el Pane Datos Basicos

        private string Checkbox_Vencimiento, Checkbox_Ofertable, Checkbox_Impuesto, Checkbox_Importado = "";
        private string Checkbox_Comision, Checkbox_Exportado = "";

        //********** Variables para AutoComplementar Combobox y Chexboxt segun la Consulta en SQL **********

        //Panel Datos Basicos
        private string Bodega_SQL, Empaque_SQL, Grupo_SQL, Marca_SQL, Tipo_SQL = "";
        private string Vencimiento_SQL, Impuesto_SQL, Importado_SQL, Exportado_SQL, Ofertable_SQL, VentaImpuesto_SQL, Comision_SQL = "";

        //********** Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar *************************

        public string Guardar, Editar, Consultar, Eliminar, Imprimir = "";

        //********** Parametros para AutoCompletar los Texboxt **********************************

        //Panel Datos Basicos - Llaves Primarias
        private string Idmarca, Idgrupo, Idtipo, Idempaque, Idbodega, Idproveedor, Idimpuesto = "";

        //Panel Datos Basicos
        private string Codigo, Nombre, Referencia, Descripcion, Presentacion = "";
        private string ManejaVencimiento, Importado, Exportado, ManjenaImpuesto = "";
        private string Ofertable, UnidadDeVenta, ComisionEmpleado = "";

        //Panel - Valores
        private string Valor_Promedio, Valor_Final, Valor_Excento, Valor_NoExcento, Valor_Mayorista, Comision, Valor_Comision, Minimo_Cliente, Maximo_Cliente, Minimo_Mayorista, Maximo_Mayorista = "";

        //Panel - Ubicacion
        private string Ubicacion, Estante, Nivel, Stock_Disponible, Imagen = "";

        //Panel - Lote
        private string Lote, Valor_Lote, Stock_Lote, Fecha_Vencimiento = "";

        //Panel - Codigo de Barra y Datos Auxiliares de Llaves Primarias
        private string CodigoDeBarra, Proveedor, Impuesto = "";

        //********** Parametros para Formatos de Tipo Moneda ***********************************

        private string Mon_Promedio, Mon_Final, Mon_Excento, Mon_NoExcento, Mon_Mayorista, Mon_Comision = "";

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();
            this.AutoCompletar_Combobox();
            this.Diseño_TablasGenerales();

            //Inicio de Texbox y Combobox por default
            this.TBNombre.Select();

            this.TBComision_Valor.Text = "0";
            this.TBComision_Porcentaje.Text = "0";

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
            this.TBIdimpuesto.Visible = false;
            this.TBIdproveedor.Visible = false;

            //Panel - Cantidades - Otros Datos
            this.CBUnidad.SelectedIndex = 0;
            
            //
            this.PB_Imagen.BackgroundImage = Properties.Resources.Logo_Leal_Enterprise;
        }

        private void Habilitar()
        {
                        
            //Panel - Datos Basicos
            this.TBCodigo.ReadOnly = false;
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCodigo.Text = Campo;
            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNombre.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBNombre.Text = Campo;
            this.TBDescripcion01.ReadOnly = false;
            this.TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescripcion01.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBDescripcion01.Text = Campo;
            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPresentacion.ReadOnly = false;
            this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBComision_Porcentaje.Enabled = false;
            this.TBComision_Porcentaje.BackColor = Color.FromArgb(72, 209, 204);
            this.TBComision_Valor.Enabled = false;
            this.TBComision_Valor.BackColor = Color.FromArgb(72, 209, 204);

            //Panel Proveedor
            this.TBBuscar_Proveedor.ReadOnly = false;
            this.TBBuscar_Proveedor.BackColor = Color.FromArgb(72, 209, 204);

            //Panel Impuesto
            this.TBBuscar_Impuesto.ReadOnly = false;
            this.TBBuscar_Impuesto.BackColor = Color.FromArgb(72, 209, 204);

            //Panel - Valores
            this.TBCompraPromedio.ReadOnly = false;
            this.TBCompraPromedio.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCompraFinal.ReadOnly = false;
            this.TBCompraFinal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorVenta_NoExcento.ReadOnly = false;
            this.TBValorVenta_NoExcento.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorVenta_Excento.ReadOnly = false;
            this.TBValorVenta_Excento.BackColor = Color.FromArgb(3, 155, 229);
            this.TBVentaMayorista.ReadOnly = false;
            this.TBVentaMayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCosto_Fabricacion.ReadOnly = false;
            this.TBCosto_Fabricacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCostos_Materiales.ReadOnly = false;
            this.TBCostos_Materiales.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCostos_Exportacion.ReadOnly = false;
            this.TBCostos_Exportacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCostos_Imprtacion.ReadOnly = false;
            this.TBCostos_Imprtacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCostos_Seguridad.ReadOnly = false;
            this.TBCostos_Seguridad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCostos_Adicional.ReadOnly = false;
            this.TBCostos_Adicional.BackColor = Color.FromArgb(3, 155, 229);

            // Panel Cantidades
            this.TBVentaMaxima_Mayorista.ReadOnly = false;
            this.TBVentaMaxima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBVentaMinima_Mayorista.ReadOnly = false;
            this.TBVentaMinima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBVentaMinina_Cliente.ReadOnly = false;
            this.TBVentaMinina_Cliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBVentaMaxima_Cliente.ReadOnly = false;
            this.TBVentaMaxima_Cliente.BackColor = Color.FromArgb(3, 155, 229);

            this.TBCompraMinima_Cliente.ReadOnly = false;
            this.TBCompraMinima_Cliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCompraMinima_Mayorista.ReadOnly = false;
            this.TBCompraMinima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCompraMaxima_Mayorista.ReadOnly = false;
            this.TBCompraMaxima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);

            //Panel Igualdad
            this.TBBuscar_Igualdad.ReadOnly = false;
            this.TBBuscar_Igualdad.BackColor = Color.FromArgb(3, 155, 229);

            //Panel Impuesto
            this.TBBuscar_Impuesto.ReadOnly = false;
            this.TBBuscar_Impuesto.BackColor = Color.FromArgb(3, 155, 229);

            //Panel Proveedor
            this.TBBuscar_Proveedor.ReadOnly = false;
            this.TBBuscar_Proveedor.BackColor = Color.FromArgb(3, 155, 229);

            //Panel Codigo de Barra
            this.TBBuscar_CodigodeBarra.ReadOnly = false;
            this.TBBuscar_CodigodeBarra.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Ubicacion
            this.TBUbicacion.ReadOnly = false;
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBEstante.ReadOnly = false;
            this.TBEstante.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNivel.ReadOnly = false;
            this.TBNivel.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Lote
            this.TBLotedeingreso.ReadOnly = false;
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor_Lote.ReadOnly = false;
            this.TBValor_Lote.BackColor = Color.FromArgb(3, 155, 229);
            this.TBLote_Venta.ReadOnly = false;
            this.TBLote_Venta.BackColor = Color.FromArgb(3, 155, 229);
            this.TBLote_Stock.ReadOnly = false;
            this.TBLote_Stock.BackColor = Color.FromArgb(3, 155, 229);
            this.DTLote_Vencimiento.Enabled = true;
            this.DTLote_Vencimiento.BackColor = Color.FromArgb(3, 155, 229);

            //Panel de Consulta General
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            //Panel - Datos Basicos

            this.TBIdproducto.Clear();

            this.TBCodigo.Clear();
            this.TBNombre.Clear();
            this.TBDescripcion01.Clear();
            this.TBReferencia.Clear();
            this.TBPresentacion.Clear();
            this.TBComision_Porcentaje.Enabled = false;
            this.TBComision_Valor.Enabled = false;

            this.CBMarca.SelectedItem = 0;
            this.CBGrupo.SelectedItem = 0;
            this.CBEmpaque.SelectedItem = 0;
            this.CBTipo.SelectedItem = 0;
            this.CBUnidad.SelectedItem = 0;

            this.CBVencimiento.Checked = false;
            this.CBImpuesto.Checked = false;
            this.CBOfertable.Checked = false;
            this.CBImportado.Checked = false;
            this.CBExportado.Checked = false;
            this.CBManejaComision.Checked = false;

            //Panel Proveedor
            this.TBBuscar_Proveedor.Clear();

            //Panel Impuesto
            this.TBBuscar_Impuesto.Clear();

            //Panel - Valores
            this.TBCompraPromedio.Clear();
            this.TBCompraFinal.Clear();
            this.TBValorVenta_NoExcento.Enabled = false;
            this.TBValorVenta_Excento.Clear();
            this.TBVentaMayorista.Clear();
            this.TBCosto_Fabricacion.Clear();
            this.TBCostos_Materiales.Clear();
            this.TBCostos_Exportacion.Clear();
            this.TBCostos_Imprtacion.Clear();
            this.TBCostos_Seguridad.Clear();
            this.TBCostos_Adicional.Clear();

            // Panel Cantidades
            this.TBVentaMaxima_Mayorista.Clear();
            this.TBVentaMinima_Mayorista.Clear();
            this.TBVentaMinina_Cliente.Clear();
            this.TBVentaMaxima_Cliente.Clear();

            this.TBCompraMinima_Cliente.Clear();
            this.TBCompraMinima_Mayorista.Clear();
            this.TBCompraMaxima_Cliente.Clear();
            this.TBCompraMaxima_Mayorista.Clear();

            //Panel Igualdad
            this.TBBuscar_Igualdad.Clear();
            this.DGDetalle_Igualdad.DataSource = null;

            //Panel Impuesto
            this.TBBuscar_Impuesto.Clear();
            this.DGDetalle_Impuesto.DataSource = null;

            //Panel Proveedor
            this.TBBuscar_Proveedor.Clear();
            this.DGDetalle_Proveedor.DataSource = null;

            //Panel Codigo de Barra
            this.TBBuscar_CodigodeBarra.Clear();
            this.DGDetalle_CodigoDeBarra.DataSource = null;

            //Panel - Ubicacion
            this.CBBodega.SelectedIndex = 0;
            this.TBUbicacion.Clear();
            this.TBEstante.Clear();
            this.TBNivel.Clear();
            this.DGDetalles_Ubicacion.DataSource = null;

            //Panel - Lote
            this.TBLotedeingreso.Clear();
            this.TBValor_Lote.Clear();
            this.TBLote_Stock.Clear();
            this.DTLote_Vencimiento.Enabled = true;
            this.DGDetalles_Lotes.DataSource = null;

            this.PB_Imagen.BackgroundImage = Properties.Resources.Logo_Leal_Enterprise;

            //Se realiza el FOCUS al panel y campo de texto iniciales
            this.TBNombre.Select();
            this.TCPrincipal.SelectedIndex = 0;
        }

        private void Botones()
        {
            if (Digitar)
            {
                this.btnGuardar.Enabled = true;
                this.btnGuardar.Text = "Guardar";

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
            else if (!Digitar)
            {
                this.btnGuardar.Enabled = true;
                this.btnGuardar.Text = "Editar";

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
        }

        private void AutoCompletar_Combobox()
        {
            try
            {
                this.CBEmpaque.DataSource = fEmpaque.Lista();
                this.CBEmpaque.ValueMember = "Codigo";
                this.CBEmpaque.DisplayMember = "Empaque";

                this.CBBodega.DataSource = fBodega.Lista();
                this.CBBodega.ValueMember = "Codigo";
                this.CBBodega.DisplayMember = "Bodega";

                this.CBGrupo.DataSource = fGrupo.Lista();
                this.CBGrupo.ValueMember = "Codigo";
                this.CBGrupo.DisplayMember = "Grupo";

                this.CBMarca.DataSource = fMarca.Lista();
                this.CBMarca.ValueMember = "Codigo";
                this.CBMarca.DisplayMember = "Marca";

                this.CBTipo.DataSource = fTipoDeProducto.Lista();
                this.CBTipo.ValueMember = "Codigo";
                this.CBTipo.DisplayMember = "Tipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void setProveedor(string idproveedor, string proveedor)
        {
            this.TBIdproveedor.Text = idproveedor;
            this.TBBuscar_Proveedor.Text = proveedor;
        }

        public void setImpuesto(string impuesto)
        {
            this.TBBuscar_Impuesto.Text = impuesto;
            this.TBIdimpuesto.Text = impuesto;
        }
                
        private void Validaciones_SQL()
        {
            //Se valida el valor de los checbox que se encuentran en el panel de datos basicos
            //En el cual si este esta seleccionado su valor sera 1 y si no esta seleccionado este seria 0

            if (CBVencimiento.Checked)
            {
                this.Checkbox_Vencimiento = "1";
            }
            else
            {
                this.Checkbox_Vencimiento = "0";
            }

            if (CBImpuesto.Checked)
            {
                this.Checkbox_Impuesto = "1";
            }
            else
            {
                this.Checkbox_Impuesto = "0";
            }

            if (CBImportado.Checked)
            {
                this.Checkbox_Importado = "1";
            }
            else
            {
                this.Checkbox_Importado = "0";
            }

            if (CBExportado.Checked)
            {
                this.Checkbox_Exportado = "1";
            }
            else
            {
                this.Checkbox_Exportado = "0";
            }

            if (CBOfertable.Checked)
            {
                this.Checkbox_Ofertable = "1";
            }
            else
            {
                this.Checkbox_Ofertable = "0";
            }
            
            if (CBManejaComision.Checked)
            {
                this.Checkbox_Comision = "1";
            }
            else
            {
                this.Checkbox_Comision = "0";
            }

            //
            this.Mon_Promedio = TBCompraPromedio.Text;
            this.Mon_Final = TBCompraFinal.Text;
            this.Mon_Excento = TBValorVenta_Excento.Text;
            this.Mon_NoExcento = TBValorVenta_NoExcento.Text;
            this.Mon_Mayorista = TBVentaMayorista.Text;
            this.Mon_Comision = TBComision_Valor.Text;
        }


        private void Diseño_TablasGenerales()
        {
            try
            {
                //Panel Ubicacion
                this.DtDetalle_Ubicacion.Columns.Add("Idbodega", System.Type.GetType("System.Int32"));
                this.DtDetalle_Ubicacion.Columns.Add("Ubicacion", System.Type.GetType("System.String"));
                this.DtDetalle_Ubicacion.Columns.Add("Estante", System.Type.GetType("System.String"));
                this.DtDetalle_Ubicacion.Columns.Add("Nivel", System.Type.GetType("System.String"));

                //Panel Lote
                this.DtDetalle_Lote.Columns.Add("Lote", System.Type.GetType("System.String"));
                this.DtDetalle_Lote.Columns.Add("Stock", System.Type.GetType("System.String"));
                this.DtDetalle_Lote.Columns.Add("Valor de Compra", System.Type.GetType("System.String"));
                this.DtDetalle_Lote.Columns.Add("Valor de Venta", System.Type.GetType("System.String"));
                this.DtDetalle_Lote.Columns.Add("Vencimiento", System.Type.GetType("System.String"));

                //Panel Codigo de Barra
                this.DtDetalle_CodigoDeBarra.Columns.Add("Codigo de Barra", System.Type.GetType("System.String"));

                //Panel Proveedores
                this.DtDetalle_Proveedor.Columns.Add("Idproveedor", System.Type.GetType("System.Int32"));
                this.DtDetalle_Proveedor.Columns.Add("Proveedor", System.Type.GetType("System.String"));
                this.DtDetalle_Proveedor.Columns.Add("Documento", System.Type.GetType("System.String"));

                //Panel Impuesto
                this.DtDetalle_Impuesto.Columns.Add("Idimpuesto", System.Type.GetType("System.Int32"));
                this.DtDetalle_Impuesto.Columns.Add("Impuesto", System.Type.GetType("System.String"));
                this.DtDetalle_Impuesto.Columns.Add("Valor", System.Type.GetType("System.String"));

                //Panel Igualdad
                this.DtDetalle_Igualdad.Columns.Add("Idproducto", System.Type.GetType("System.Int32"));
                this.DtDetalle_Igualdad.Columns.Add("Codigo", System.Type.GetType("System.String"));
                this.DtDetalle_Igualdad.Columns.Add("Producto", System.Type.GetType("System.String"));
                this.DtDetalle_Igualdad.Columns.Add("Marca", System.Type.GetType("System.String"));
                
                //Captura de los Datos en las Tablas
                this.DGDetalles_Lotes.DataSource = this.DtDetalle_Lote;
                this.DGDetalle_Impuesto.DataSource = this.DtDetalle_Impuesto;
                this.DGDetalle_Igualdad.DataSource = this.DtDetalle_Igualdad;
                this.DGDetalle_Proveedor.DataSource = this.DtDetalle_Proveedor;
                this.DGDetalles_Ubicacion.DataSource = this.DtDetalle_Ubicacion;
                this.DGDetalle_CodigoDeBarra.DataSource = this.DtDetalle_CodigoDeBarra;
                

                //Medidas de las Columnas - Codigo de Barra
                this.DGDetalle_CodigoDeBarra.Columns[0].Width = 370;

                this.DGDetalle_Proveedor.Columns[1].Width = 270;
                this.DGDetalle_Proveedor.Columns[2].Width = 100;

                this.DGDetalles_Ubicacion.Columns[1].Width = 220;
                this.DGDetalles_Ubicacion.Columns[2].Width = 75;
                this.DGDetalles_Ubicacion.Columns[3].Width = 75;

                this.DGDetalle_Impuesto.Columns[1].Width = 270;
                this.DGDetalle_Impuesto.Columns[2].Width = 100;

                this.DGDetalle_Igualdad.Columns[1].Width = 115;
                this.DGDetalle_Igualdad.Columns[2].Width = 255;
                this.DGDetalle_Igualdad.Columns[3].Width = 100;

                this.DGDetalles_Lotes.Columns[0].Width = 80;
                this.DGDetalles_Lotes.Columns[1].Width = 80;
                this.DGDetalles_Lotes.Columns[2].Width = 130;
                this.DGDetalles_Lotes.Columns[3].Width = 130;
                this.DGDetalles_Lotes.Columns[4].Width = 130;

                //Formato de Celdas
                //this.DGDetalles_Lotes.Columns[2].DefaultCellStyle.Format = "##,##0.00";

                //************************************* Alineacion de las Celdas *************************************

                //Panel Codigo de Barra
                this.DGDetalle_CodigoDeBarra.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Proveedores
                this.DGDetalle_Proveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Proveedor.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Ubicaciones
                this.DGDetalles_Ubicacion.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Ubicacion.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Ubicacion.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Impuestos
                this.DGDetalle_Impuesto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Impuesto.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Igualdad
                this.DGDetalle_Igualdad.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Igualdad.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Igualdad.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Lotes
                this.DGDetalles_Lotes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



                //************************************* Aliniacion de Emcabezados *************************************

                //Panel Codigo de Barra
                this.DGDetalle_CodigoDeBarra.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Proveedores
                this.DGDetalle_Proveedor.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Proveedor.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Ubicaciones
                this.DGDetalles_Ubicacion.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Ubicacion.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Ubicacion.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Impuestos
                this.DGDetalle_Impuesto.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Impuesto.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Igualdad
                this.DGDetalle_Igualdad.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Igualdad.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalle_Igualdad.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Panel Lotes
                this.DGDetalles_Lotes.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.DGDetalles_Lotes.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //************************************* Ocultacion de Columnas *************************************
                this.DGDetalle_Igualdad.Columns[0].Visible = false;
                this.DGDetalle_Impuesto.Columns[0].Visible = false;
                this.DGDetalle_Proveedor.Columns[0].Visible = false;
                this.DGDetalles_Ubicacion.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void DetalleIgualdad_SQL(int idproducto, string codigo, string producto, string marca)
        {
            try
            {
                bool Agregar = true;
                foreach (DataRow FilaTemporal in DtDetalle_Igualdad.Rows)
                {
                    if (Convert.ToInt32(FilaTemporal["Idproducto"]) == idproducto)
                    {
                        Agregar = false;
                        this.MensajeError("El Producto ya se encuentra agregado en la lista.");
                    }
                }

                if (Agregar)
                {
                    DataRow Fila = DtDetalle_Igualdad.NewRow();
                    Fila["Idproducto"] = idproducto;
                    Fila["Producto"] = producto;
                    Fila["Marca"] = marca;
                    this.DtDetalle_Igualdad.Rows.Add(Fila);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void DetalleImpuesto_SQL(int idimpuesto, string impuesto, string valor)
        {
            try
            {
                bool Agregar = true;
                foreach (DataRow FilaTemporal in DtDetalle_Impuesto.Rows)
                {
                    if (Convert.ToInt32(FilaTemporal["Idimpuesto"]) == idimpuesto)
                    {
                        Agregar = false;
                        this.MensajeError("El Impuesto ya se encuentra agregado en la lista.");
                    }
                }

                if (Agregar)
                {
                    DataRow Fila = DtDetalle_Impuesto.NewRow();
                    Fila["Idimpuesto"] = idimpuesto;
                    Fila["Impuesto"] = impuesto;
                    Fila["Valor"] = valor;
                    this.DtDetalle_Impuesto.Rows.Add(Fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void DetalleProveedor_SQL(int idproveedor, string proveedor, string documento)
        {
            try
            {
                bool Agregar = true;
                foreach (DataRow FilaTemporal in DtDetalle_Proveedor.Rows)
                {
                    if (Convert.ToInt32(FilaTemporal["Idproveedor"]) == idproveedor)
                    {
                        Agregar = false;
                        this.MensajeError("El Proveedor ya se encuentra agregado en la lista.");
                    }
                }

                if (Agregar)
                {
                    DataRow Fila = DtDetalle_Proveedor.NewRow();
                    Fila["Idproveedor"] = idproveedor;
                    Fila["Proveedor"] = proveedor;
                    Fila["Documento"] = documento;
                    this.DtDetalle_Proveedor.Rows.Add(Fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                // <<<<<<------ Panel Datos Basicos ------>>>>>

                if (this.TBNombre.Text == Campo)
                {
                    MensajeError("Ingrese el nombre del Producto a registrar");
                }
                else if (this.TBDescripcion01.Text == Campo)
                {
                    MensajeError("Ingrese la Descripcion del Producto");
                }
                else if (this.TBCodigo.Text == Campo)
                {
                    MensajeError("Ingrese el Codigo del Producto");
                }

                //else if (DGDetalle_Impuesto.DataSource == null)
                //{
                //    MensajeError("Por Favor Cargue el Impuesto del Producto a Registrar");
                //}
                //else if (DGDetalle_Proveedor.DataSource == null)
                //{
                //    MensajeError("Por Favor Cargue el Proveedor que Distribuye el Producto a Registrar");
                //}

                else if (this.CBGrupo.SelectedIndex == 0)
                {
                    MensajeError("Seleccione el Grupo al cual pertenece el Producto");
                }
                else if (this.CBMarca.SelectedIndex == 0)
                {
                    MensajeError("Seleccione la Marca del Producto");
                }

                //else if (this.DGDetalles_Ubicacion.DataSource == null)
                //{
                //    MensajeError("Seleccione la Bodega donde se Ubicara el Producto");
                //    this.TCPrincipal.SelectedIndex = 2;
                //    this.TBUbicacion.Select();
                //}

                else
                {
                    //Parametros para poder guardar la imagen del producto

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] Imagen_Producto = ms.GetBuffer();


                    this.Validaciones_SQL();

                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fProductos.Guardar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBEmpaque.SelectedValue), Convert.ToInt32(this.CBGrupo.SelectedValue), Convert.ToInt32(this.CBTipo.SelectedValue),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBPresentacion.Text,
                                 this.CBUnidad.Text, this.TBComision_Valor.Text, Convert.ToInt32(this.TBComision_Porcentaje.Text),

                                 Convert.ToInt32(Checkbox_Vencimiento), Convert.ToInt32(Checkbox_Impuesto), Convert.ToInt32(Checkbox_Importado),
                                 Convert.ToInt32(Checkbox_Exportado), Convert.ToInt32(Checkbox_Ofertable), Convert.ToInt32(Checkbox_Comision),

                                 //Panel de Valores
                                 this.TBCompraPromedio.Text, this.TBCompraFinal.Text, this.TBValorVenta_Excento.Text, this.TBValorVenta_NoExcento.Text, this.TBVentaMayorista.Text,
                                 this.TBCosto_Fabricacion.Text, this.TBCostos_Materiales.Text, this.TBCostos_Exportacion.Text, this.TBCostos_Imprtacion.Text,
                                 this.TBCostos_Seguridad.Text, this.TBCostos_Adicional.Text,

                                 //Panel Cantidades
                                 this.TBVentaMinina_Cliente.Text, this.TBVentaMaxima_Cliente.Text, this.TBVentaMinima_Mayorista.Text, this.TBVentaMaxima_Mayorista.Text, this.TBCompraMinima_Cliente.Text, this.TBCompraMaxima_Cliente.Text, this.TBCompraMinima_Mayorista.Text, this.TBCompraMaxima_Mayorista.Text,

                                 //Tabla de Detalles - Lote, Impuesto, Igualdad, Proveedor, Ubicacion, Codigo de Barra
                                 this.DtDetalle_Lote, this.DtDetalle_Impuesto, this.DtDetalle_Igualdad, this.DtDetalle_Proveedor, this.DtDetalle_Ubicacion, this.DtDetalle_CodigoDeBarra,

                                 //Panel de Imagen
                                 Imagen_Producto,

                                 //Si es igual a 1 se registraran los datos en la base de datos
                                 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fProductos.Editar_DatosBasicos

                            (
                                 //Llave Primaria
                                 Convert.ToInt32(this.TBIdproducto.Text),

                                 //Datos Auxiliares
                                 Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBEmpaque.SelectedValue), Convert.ToInt32(this.CBGrupo.SelectedValue), Convert.ToInt32(this.CBTipo.SelectedValue),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBPresentacion.Text,
                                 this.CBUnidad.Text, this.TBComision_Valor.Text, Convert.ToInt32(this.TBComision_Porcentaje.Text),

                                 Convert.ToInt32(Checkbox_Vencimiento), Convert.ToInt32(Checkbox_Impuesto), Convert.ToInt32(Checkbox_Importado),
                                 Convert.ToInt32(Checkbox_Exportado), Convert.ToInt32(Checkbox_Ofertable), Convert.ToInt32(Checkbox_Comision),

                                 //Panel de Valores
                                 this.TBCompraPromedio.Text, this.TBCompraFinal.Text, this.TBValorVenta_Excento.Text, this.TBValorVenta_NoExcento.Text, this.TBVentaMayorista.Text,
                                 this.TBCosto_Fabricacion.Text, this.TBCostos_Materiales.Text, this.TBCostos_Exportacion.Text, this.TBCostos_Imprtacion.Text,
                                 this.TBCostos_Seguridad.Text, this.TBCostos_Adicional.Text,

                                 //Panel Cantidades
                                 this.TBVentaMinina_Cliente.Text, this.TBVentaMaxima_Cliente.Text, this.TBVentaMinima_Mayorista.Text, this.TBVentaMaxima_Mayorista.Text, this.TBCompraMinima_Cliente.Text, this.TBCompraMaxima_Cliente.Text, this.TBCompraMinima_Mayorista.Text, this.TBCompraMaxima_Mayorista.Text,

                                 //Tabla de Detalles - Lote, Impuesto, Igualdad, Proveedor, Ubicacion, Codigo de Barra
                                 this.DtDetalle_Lote, this.DtDetalle_Impuesto, this.DtDetalle_Igualdad, this.DtDetalle_Proveedor, this.DtDetalle_Ubicacion, this.DtDetalle_CodigoDeBarra,

                                 //Panel de Imagen
                                 Imagen_Producto,


                                 //Si es igual a 2 se Editaran los datos en la base de datos
                                 2
                            );
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.Digitar)
                        {
                            this.MensajeOk("Registro Exitoso");
                        }

                        else
                        {
                            this.MensajeOk("Registro Actualizado");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    //Llamada de Clase
                    this.Digitar = true;
                    this.Botones();
                    this.Limpiar_Datos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Digitar)
                {
                    if (Guardar == "1")
                    {
                        //Metodo Guardar y editar
                        this.Guardar_SQL();
                    }

                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Guardar Datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Llamada de Clase
                        this.Digitar = true;
                        this.Botones();
                        this.Limpiar_Datos();
                    }
                }

                else
                {
                    if (Editar == "1")
                    {
                        //Metodo Guardar y editar
                        this.Guardar_SQL();
                    }
                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Editar Datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Llamada de Clase
                        this.Digitar = false;
                        this.Limpiar_Datos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Digitar = false;
                this.Limpiar_Datos();
                this.TBBuscar.Clear();

                //Se Limpian las Filas y Columnas de la tabla
                this.DGResultados.DataSource = null;
                this.DGResultados.Enabled = false;
                this.lblTotal.Text = "Datos Registrados: 0";

                //Se restablece la imagen predeterminada del boton
                //this.btnGuardar.Image = Properties.Resources.BV_Guardar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Ubicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CBBodega.SelectedIndex == 0)
                {
                    this.MensajeError("Por favor seleccione la Bodega perteneciente a la Ubicación que desea generar");
                }
                else if (this.TBUbicacion.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique la Ubicación dentro de la Bodega seleccionada");
                    this.TBUbicacion.Select();
                }
                else
                {

                    DataRow fila = this.DtDetalle_Ubicacion.NewRow();
                    fila["Idbodega"] = Convert.ToInt32(this.CBBodega.SelectedValue);
                    fila["Ubicacion"] = this.TBUbicacion.Text;
                    fila["Estante"] = this.TBEstante.Text;
                    fila["Nivel"] = this.TBNivel.Text;
                    this.DtDetalle_Ubicacion.Rows.Add(fila);

                    //
                    this.TBUbicacion.Clear();
                    this.TBEstante.Clear();
                    this.TBNivel.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Ubicacion_Click(object sender, EventArgs e)
        {
            try
            {
                int Fila = this.DGDetalles_Ubicacion.CurrentCell.RowIndex;
                DataRow row = this.DtDetalle_Ubicacion.Rows[Fila];

                //Se remueve la fila
                this.DtDetalle_Ubicacion.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("Por favor seleccione la Ubicacion que desea Remover del registo");
            }
        }

        private void btnAgregar_CodigoDeBarra_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBBuscar_CodigodeBarra.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique el Codigo de Barra que desea agregar");
                    this.TBBuscar_CodigodeBarra.Select();
                }
                
                else
                {
                    bool agregar = true;
                    foreach (DataRow Fila in DtDetalle_CodigoDeBarra.Rows)
                    {
                        if (Convert.ToString(Fila["Codigo de Barra"]) == TBBuscar_CodigodeBarra.Text)
                        {
                            this.MensajeError("El Codigo de Barra que desea agregar ya se encuentra en la lista");
                        }
                    }
                    if (agregar)
                    {
                        DataRow fila = this.DtDetalle_CodigoDeBarra.NewRow();
                        fila["Codigo de Barra"] = this.TBBuscar_CodigodeBarra.Text;
                        this.DtDetalle_CodigoDeBarra.Rows.Add(fila);
                    }

                    //
                    this.TBBuscar_CodigodeBarra.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_CodigosDeBarra_Click(object sender, EventArgs e)
        {
            try
            {
                int Fila = this.DGDetalle_CodigoDeBarra.CurrentCell.RowIndex;
                DataRow row = this.DtDetalle_CodigoDeBarra.Rows[Fila];

                //Se remueve la fila
                this.DtDetalle_CodigoDeBarra.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("Por favor seleccione el Codigo de Barra que desea Remover del registo");
            }
        }
        
        private void btnAgregar_Lotes_Click(object sender, EventArgs e)
        {

        }

        //******************** FOCUS ENTER  DATOS BASICOS ********************

        private void TBCodigo_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCodigo.Text == Campo)
            {
                this.TBCodigo.BackColor = Color.Azure;
                this.TBCodigo.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBCodigo.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCodigo.BackColor = Color.Azure;
                this.TBCodigo.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBNombre_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBNombre.Text == Campo)
            {
                this.TBNombre.BackColor = Color.Azure;
                this.TBNombre.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBNombre.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBNombre.BackColor = Color.Azure;
                this.TBNombre.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBReferencia_Enter(object sender, EventArgs e)
        {
            this.TBReferencia.BackColor = Color.Azure;
        }

        private void TBDescripcion01_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBDescripcion01.Text == Campo)
            {
                this.TBDescripcion01.BackColor = Color.Azure;
                this.TBDescripcion01.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBDescripcion01.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBDescripcion01.BackColor = Color.Azure;
                this.TBDescripcion01.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBPresentacion_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBPresentacion.Text == Campo)
            {
                this.TBPresentacion.BackColor = Color.Azure;
                this.TBPresentacion.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBPresentacion.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBPresentacion.BackColor = Color.Azure;
                this.TBPresentacion.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        //******************** FOCUS ENTER Valores ********************
        
        private void TBValor01_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBValorVenta_NoExcento.BackColor = Color.Azure;
        }

        private void TBCantidadMininaCliente_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBVentaMinina_Cliente.BackColor = Color.Azure;
        }

        private void TBCantidadMaximaCliente_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBVentaMaxima_Cliente.BackColor = Color.Azure;
        }
        
        //******************** FOCUS ENTER UBICACION ********************
        private void TBUbicacion_Enter(object sender, EventArgs e)
        {
            this.TBUbicacion.BackColor = Color.Azure;
        }

        private void TBEstante_Enter(object sender, EventArgs e)
        {
            this.TBEstante.BackColor = Color.Azure;
        }

        private void TBNivel_Enter(object sender, EventArgs e)
        {
            this.TBNivel.BackColor = Color.Azure;
        }

        //******************** FOCUS ENTER PRECIOS ********************

        private void TBCompraPromedio_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCompraPromedio.Text == string.Empty)
            {
                this.TBCompraPromedio.BackColor = Color.Azure;
                this.TBCompraPromedio.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else 
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCompraPromedio.BackColor = Color.Azure;
                this.TBCompraPromedio.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBValorParaComision_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBComision_Valor.BackColor = Color.Azure;
        }

        private void TBValordecompra_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBCompraFinal.BackColor = Color.Azure;
        }
        
        private void TBVentaMayorista_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBVentaMayorista.BackColor = Color.Azure;
        }

        private void TBMinimoMayorista_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBVentaMinima_Mayorista.BackColor = Color.Azure;
        }

        private void TBMaximoMayorista_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBVentaMaxima_Mayorista.BackColor = Color.Azure;
        }

        //******************** FOCUS LEAVE DATOS BASICOS ********************
        private void TBCodigo_Leave(object sender, EventArgs e)
        {
            if (TBCodigo.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
                this.TBCodigo.Text = Campo;
                this.TBCodigo.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBNombre_Leave(object sender, EventArgs e)
        {
            if (TBNombre.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
                this.TBNombre.Text = Campo;
                this.TBNombre.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBReferencia_Leave(object sender, EventArgs e)
        {
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDescripcion01_Leave(object sender, EventArgs e)
        {
            if (TBDescripcion01.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
                this.TBDescripcion01.Text = Campo;
                this.TBDescripcion01.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBPresentacion_Leave(object sender, EventArgs e)
        {
            if (TBPresentacion.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);
                this.TBPresentacion.Text = Campo;
                this.TBPresentacion.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        //************************ SALTO DE LINEAS - PANEL DATOS BASICOS ************************

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNombre.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCodigo.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCodigo.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBReferencia.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNombre.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNombre.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBReferencia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDescripcion01.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion01.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDescripcion01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBPresentacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion01.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBPresentacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    if (CBManejaComision.Checked)
                    {
                        this.TBComision_Porcentaje.Select();
                    }
                    else
                    {
                        this.TBNombre.Select();
                    }                    
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBPresentacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBPresentacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //************************ SALTO DE LINEAS - PANEL VALORES ************************

        private void TBCompraPromedio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente
                    this.TBCompraFinal.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraPromedio.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraPromedio.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void TBValorVenta_SinImpuesto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    if (CBImpuesto.Checked)
                    {
                        this.TBValorVenta_NoExcento.Select();
                    }
                    else
                    {
                        this.TBVentaMayorista.Select();
                    }
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorVenta_Excento.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorVenta_Excento.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorFinal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorVenta_Excento.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraFinal.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraFinal.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void TBValorVenta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBVentaMayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorVenta_NoExcento.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorVenta_NoExcento.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCantidadMininaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBVentaMaxima_Cliente.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinina_Cliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinina_Cliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCantidadMaximaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBVentaMinima_Mayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Cliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Cliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBOtrosGastos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCompraFinal.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            //this.TBOtrosGastos.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            //this.TBOtrosGastos.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //************************ SALTO DE LINEAS - PANEL UBICACIONES ************************

        private void TBUbicacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBEstante.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBUbicacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBUbicacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBEstante_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNivel.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBEstante.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBEstante.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNivel_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNivel.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNivel.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //************************ SALTO DE LINEAS - PANEL LOTES ************************

        private void TBLotedeingreso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValor_Lote.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLotedeingreso.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLotedeingreso.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValor_Lote_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBLote_Venta.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor_Lote.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor_Lote.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBVencimiento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CBImpuesto.Checked)
            {
                this.TBValorVenta_NoExcento.Enabled = true;
            }
            else
            {
                this.TBValorVenta_NoExcento.Enabled = false;
            }
        }

        private void TBValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBLote_Venta_Enter(object sender, EventArgs e)
        {
            this.TBLote_Venta.BackColor = Color.Azure;
        }

        private void TBLote_Stock_Enter(object sender, EventArgs e)
        {
            this.TBLote_Stock.BackColor = Color.Azure;
        }

        private void TBLote_Venta_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBLote_Venta.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBLote_Stock_Leave(object sender, EventArgs e)
        {
            this.TBLote_Stock.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBuscar_Proveedor_Enter(object sender, EventArgs e)
        {
            this.TBBuscar_Proveedor.BackColor = Color.Azure;
        }

        private void TBBuscar_Proveedor_Leave(object sender, EventArgs e)
        {
            this.TBBuscar_Proveedor.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBuscar_Impuesto_Enter(object sender, EventArgs e)
        {
            this.TBBuscar_Impuesto.BackColor = Color.Azure;
        }

        private void TBBuscar_Impuesto_Leave(object sender, EventArgs e)
        {
            this.TBBuscar_Impuesto.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBuscar_Igualdad_Enter(object sender, EventArgs e)
        {
            this.TBBuscar_Igualdad.BackColor = Color.Azure;
        }

        private void TBBuscar_Igualdad_Leave(object sender, EventArgs e)
        {
            this.TBBuscar_Igualdad.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void btnAgregar_Igualdad_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBBuscar_Igualdad.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique el Producto o Servicio de Igualdad que desea Agregar");
                    this.TBBuscar_Igualdad.Select();
                }
                else
                {
                    bool agregar = true;
                    foreach (DataRow Fila in DtDetalle_Igualdad.Rows)
                    {
                        if (Convert.ToString(Fila["Codigo"]) == TBBuscar_Igualdad.Text)
                        {
                            this.MensajeError("El producto o servicio que desea agregar ya se encuentra en la lista");
                        }
                        else if(Convert.ToString(Fila["Producto"]) == TBBuscar_Igualdad.Text)
                        {
                            this.MensajeError("El producto o servicio que desea agregar ya se encuentra en la lista");
                        }
                    }
                    if (agregar)
                    {
                        DataRow fila = this.DtDetalle_Igualdad.NewRow();
                        fila["Idproducto"] = Convert.ToInt32(this.TBIdproducto.Text);
                        fila["Codigo"] = this.TBUbicacion.Text;
                        fila["Producto"] = this.TBEstante.Text;
                        fila["Marca"] = this.TBNivel.Text;
                        this.DtDetalle_Igualdad.Rows.Add(fila);
                    }

                    //
                    this.TBBuscar_Igualdad.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Impuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Proveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBBuscar_Proveedor.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique el Proveedor que desea Agregar");
                    this.TBBuscar_Proveedor.Select();
                }
                else
                {
                    bool agregar = true;
                    foreach (DataRow Fila in DtDetalle_Proveedor.Rows)
                    {
                        if (Convert.ToString(Fila["Codigo"]) == TBBuscar_Igualdad.Text)
                        {
                            this.MensajeError("El producto o servicio que desea agregar ya se encuentra en la lista");
                        }
                        else if (Convert.ToString(Fila["Producto"]) == TBBuscar_Igualdad.Text)
                        {
                            this.MensajeError("El producto o servicio que desea agregar ya se encuentra en la lista");
                        }
                    }
                    if (agregar)
                    {
                        DataRow fila = this.DtDetalle_Proveedor.NewRow();
                        fila["Idproveedor"] = Convert.ToInt32(this.TBIdproveedor.Text);
                        fila["Proveedor"] = this.TBBuscar_Proveedor.Text;
                        fila["Documento"] = this.TBEstante.Text;
                        this.DtDetalle_Proveedor.Rows.Add(fila);
                    }

                    //
                    this.TBBuscar_Proveedor.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Lote_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBLotedeingreso.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique el numero de Lote que desea agregar");
                    this.TBLotedeingreso.Select();
                }
                else if (this.TBValor_Lote.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique el valor de compra del Lote que desea agregar");
                    this.TBValor_Lote.Select();
                }
                else if (this.TBLote_Venta.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique el valor de venta del Lote que desea agregar");
                    this.TBLote_Venta.Select();
                }
                else if (this.TBLote_Stock.Text == String.Empty)
                {
                    this.MensajeError("Por favor Especifique la Cantidad de Productos que ingresaran con el Lote que desea agregar");
                    this.TBLote_Stock.Select();
                }
                else
                {
                    bool agregar = true;
                    foreach (DataRow Fila in DtDetalle_Lote.Rows)
                    {
                        if (Convert.ToString(Fila["Lote"]) == TBLotedeingreso.Text)
                        {
                            this.MensajeError("El Nº de Lote que desea agregar ya se encuentra en la lista");
                        }
                    }
                    if (agregar)
                    {
                        DataRow fila = this.DtDetalle_Lote.NewRow();
                        fila["Lote"] = this.TBLotedeingreso.Text;
                        fila["Valor de Compra"] = this.TBValor_Lote.Text;
                        fila["Valor de Venta"] = this.TBLote_Venta.Text;
                        fila["Stock"] = this.TBLote_Stock.Text;
                        fila["Vencimiento"] = this.DTLote_Vencimiento.Value.ToString("dd/MM/yyyy");
                        this.DtDetalle_Lote.Rows.Add(fila);
                    }

                    //
                    this.TBBuscar_Proveedor.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Lote_Click(object sender, EventArgs e)
        {
            try
            {
                int Fila = this.DGDetalles_Lotes.CurrentCell.RowIndex;
                DataRow row = this.DtDetalle_Lote.Rows[Fila];

                //Se remueve la fila
                this.DtDetalle_Lote.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("Por favor seleccione el Nº de Lote que desea Remover del registo");
            }
        }

        private void btnImprimir_Igualdad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Igualdad_Click(object sender, EventArgs e)
        {
            try
            {
                int Fila = this.DGDetalle_Igualdad.CurrentCell.RowIndex;
                DataRow row = this.DtDetalle_Igualdad.Rows[Fila];

                //Se remueve la fila
                this.DtDetalle_Igualdad.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("Por favor seleccione la Igualdad que desea Remover del registo");
            }
        }

        private void TBBuscar_Igualdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Tabla = new DataTable();
                    Tabla = fProductos.Buscar_Igualdad(this.TBBuscar_Igualdad.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("El producto el cual desea agregar no se encuentra registrado en su Base de Datos");
                    }
                    else
                    {
                        this.DetalleIgualdad_SQL
                            (
                                Convert.ToInt32(Tabla.Rows[0][0]),
                                Convert.ToString(Tabla.Rows[0][1]),
                                Convert.ToString(Tabla.Rows[0][2]),
                                Convert.ToString(Tabla.Rows[0][3])
                            );

                        lblTotalIgualdad.Text = "Productos Agregados: " + Convert.ToString(DGDetalle_Igualdad.Rows.Count);

                        //Se procede a limpiar los campos de texto utilizados para el Filtro

                        this.TBBuscar_Igualdad.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TBBuscar_Impuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Tabla = new DataTable();
                    Tabla = fImpuesto.BuscarExistencia_SQL(this.TBIdimpuesto.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("El Impuesto el cual desea agregar no se encuentra registrado en su Base de Datos");
                    }
                    else
                    {
                        this.DetalleImpuesto_SQL
                            (
                                Convert.ToInt32(Tabla.Rows[0][0]),
                                Convert.ToString(Tabla.Rows[0][1]),
                                Convert.ToString(Tabla.Rows[0][2])
                            );

                        lblTotalImpuesto.Text = "Impuestos Agregados: " + Convert.ToString(DGDetalle_Impuesto.Rows.Count);

                        //Se procede a limpiar los campos de texto utilizados para el Filtro

                        this.TBBuscar_Impuesto.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TBBuscar_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Tabla = new DataTable();
                    Tabla = fProveedor.BuscarExistencia_SQL(this.TBBuscar_Proveedor.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("El producto el cual desea agregar no se encuentra registrado en su Base de Datos");
                    }
                    else
                    {
                        this.DetalleProveedor_SQL
                            (
                                Convert.ToInt32(Tabla.Rows[0][0]),
                                Convert.ToString(Tabla.Rows[0][1]),
                                Convert.ToString(Tabla.Rows[0][2])
                            );

                        lblTotalProveedor.Text = "Proveedores Agregados: " + Convert.ToString(DGDetalle_Proveedor.Rows.Count);

                        //Se procede a limpiar los campos de texto utilizados para el Filtro

                        this.TBBuscar_Proveedor.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Impuesto_Click(object sender, EventArgs e)
        {
            try
            {
                int Fila = this.DGDetalle_Impuesto.CurrentCell.RowIndex;
                DataRow row = this.DtDetalle_Impuesto.Rows[Fila];

                //Se remueve la fila
                this.DtDetalle_Impuesto.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("Por favor seleccione el Impuesto que desea Remover del registo");
            }
        }

        private void btnEliminar_Proveedor_Click(object sender, EventArgs e)
        {
            try
            {
                int Fila = this.DGDetalle_Proveedor.CurrentCell.RowIndex;
                DataRow row = this.DtDetalle_Proveedor.Rows[Fila];

                //Se remueve la fila
                this.DtDetalle_Impuesto.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("Por favor seleccione el Proveedor que desea Remover del registo");
            }
        }

        private void TBCosto_Fabricacion_Enter(object sender, EventArgs e)
        {
            this.TBCosto_Fabricacion.BackColor = Color.Azure;
        }

        private void TBCostos_Materiales_Enter(object sender, EventArgs e)
        {
            this.TBCostos_Materiales.BackColor = Color.Azure;
        }

        private void TBCostos_Exportacion_Enter(object sender, EventArgs e)
        {
            this.TBCostos_Exportacion.BackColor = Color.Azure;
        }

        private void TBCostos_Imprtacion_Enter(object sender, EventArgs e)
        {
            this.TBCostos_Imprtacion.BackColor = Color.Azure;
        }

        private void TBCostos_Seguridad_Enter(object sender, EventArgs e)
        {
            this.TBCostos_Seguridad.BackColor = Color.Azure;
        }

        private void TBCostos_Adicional_Enter(object sender, EventArgs e)
        {
            this.TBCostos_Adicional.BackColor = Color.Azure;
        }

        private void TBCosto_Fabricacion_Leave(object sender, EventArgs e)
        {
            this.TBCosto_Fabricacion.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCostos_Materiales_Leave(object sender, EventArgs e)
        {
            this.TBCostos_Materiales.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCostos_Exportacion_Leave(object sender, EventArgs e)
        {
            this.TBCostos_Exportacion.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCostos_Imprtacion_Leave(object sender, EventArgs e)
        {
            this.TBCostos_Imprtacion.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCostos_Seguridad_Leave(object sender, EventArgs e)
        {
            this.TBCostos_Seguridad.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCostos_Adicional_Leave(object sender, EventArgs e)
        {
            this.TBCostos_Adicional.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCosto_Fabricacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCostos_Materiales_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCostos_Exportacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCostos_Imprtacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCostos_Seguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCostos_Adicional_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCosto_Fabricacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCostos_Materiales.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCosto_Fabricacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCosto_Fabricacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCostos_Exportacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCostos_Imprtacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Exportacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Exportacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCostos_Imprtacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCostos_Seguridad.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Imprtacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Imprtacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCostos_Seguridad_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCostos_Adicional.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Seguridad.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Seguridad.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCostos_Materiales_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCostos_Exportacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Materiales.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Materiales.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCostos_Adicional_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCompraPromedio.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Adicional.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCostos_Adicional.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnExaminar_Igualdad_Click(object sender, EventArgs e)
        {
            frmFiltro_Producto frmFiltro_Producto = new frmFiltro_Producto();
            frmFiltro_Producto.ShowDialog();
        }

        private void TBValor_Lote_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBLote_Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBLote_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBLote_Venta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBLote_Stock.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLote_Venta.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLote_Venta.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBLote_Stock_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBLotedeingreso.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLote_Stock.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLote_Stock.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBComision_Valor_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
            {
                //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                this.TBNombre.Select();
            }
        }

        private void TBComision_Porcentaje_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
            {
                //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                if (CBManejaComision.Checked)
                {
                    this.TBComision_Valor.Select();
                }
                else
                {
                    this.TBNombre.Select();
                }
            }
        }

        private void TBComision_Porcentaje_Enter(object sender, EventArgs e)
        {
            this.TBComision_Porcentaje.BackColor = Color.Azure;
        }

        private void TBComision_Valor_Enter(object sender, EventArgs e)
        {
            this.TBComision_Valor.BackColor = Color.Azure;
        }

        private void TBComision_Porcentaje_Leave(object sender, EventArgs e)
        {
            this.TBComision_Porcentaje.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBComision_Valor_Leave(object sender, EventArgs e)
        {
            this.TBComision_Valor.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBVentaMinina_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBVentaMaxima_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBVentaMinima_Mayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBVentaMaxima_Mayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCompraMinima_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCompraMaxima_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCompraMinima_Mayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCompraMaxima_Mayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBVentaMinina_Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBVentaMaxima_Cliente.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinina_Cliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinina_Cliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBVentaMaxima_Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBVentaMinima_Mayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Cliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Cliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBVentaMinima_Mayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBVentaMaxima_Mayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinima_Mayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinima_Mayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBVentaMaxima_Mayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCompraMinima_Cliente.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Mayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Mayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCompraMinima_Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCompraMaxima_Cliente.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMinima_Cliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMinima_Cliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCompraMaxima_Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCompraMinima_Mayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMaxima_Cliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMaxima_Cliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCompraMinima_Mayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCompraMaxima_Mayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMinima_Mayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMinima_Mayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCompraMaxima_Mayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBVentaMinina_Cliente.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMaxima_Mayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCompraMaxima_Mayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBVentaMinina_Cliente_Enter(object sender, EventArgs e)
        {
            this.TBVentaMinina_Cliente.BackColor = Color.Azure;
        }

        private void TBVentaMaxima_Cliente_Enter(object sender, EventArgs e)
        {
            this.TBVentaMaxima_Cliente.BackColor = Color.Azure;
        }

        private void TBVentaMinima_Mayorista_Enter(object sender, EventArgs e)
        {
            this.TBVentaMinima_Mayorista.BackColor = Color.Azure;
        }

        private void TBVentaMaxima_Mayorista_Enter(object sender, EventArgs e)
        {
            this.TBVentaMaxima_Mayorista.BackColor = Color.Azure;
        }

        private void TBCompraMinima_Cliente_Enter(object sender, EventArgs e)
        {
            this.TBCompraMinima_Cliente.BackColor = Color.Azure;
        }

        private void TBCompraMaxima_Cliente_Enter(object sender, EventArgs e)
        {
            this.TBCompraMaxima_Cliente.BackColor = Color.Azure;
        }

        private void TBCompraMinima_Mayorista_Enter(object sender, EventArgs e)
        {
            this.TBCompraMinima_Mayorista.BackColor = Color.Azure;
        }

        private void TBCompraMaxima_Mayorista_Enter(object sender, EventArgs e)
        {
            this.TBCompraMaxima_Mayorista.BackColor = Color.Azure;
        }

        private void TBVentaMinina_Cliente_Leave(object sender, EventArgs e)
        {
            this.TBVentaMinina_Cliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBVentaMaxima_Cliente_Leave(object sender, EventArgs e)
        {
            this.TBVentaMaxima_Cliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBVentaMinima_Mayorista_Leave(object sender, EventArgs e)
        {
            this.TBVentaMinima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBVentaMaxima_Mayorista_Leave(object sender, EventArgs e)
        {
            this.TBVentaMaxima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCompraMinima_Cliente_Leave(object sender, EventArgs e)
        {
            this.TBCompraMinima_Cliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCompraMaxima_Cliente_Leave(object sender, EventArgs e)
        {
            this.TBCompraMaxima_Cliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCompraMinima_Mayorista_Leave(object sender, EventArgs e)
        {
            this.TBCompraMinima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCompraMaxima_Mayorista_Leave(object sender, EventArgs e)
        {
            this.TBCompraMaxima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {
            frmFiltro_Proveedor frmFiltro_Proveedor = new frmFiltro_Proveedor();
            frmFiltro_Proveedor.ShowDialog();
        }

        private void btnExaminar_Impuesto_Click(object sender, EventArgs e)
        {
            frmFiltro_Impuestos frmFiltro_Impuestos = new frmFiltro_Impuestos();
            frmFiltro_Impuestos.ShowDialog();
        }

        private void TBValorVenta_SinImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBVentaMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBGastodeEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorParaComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCantidadMininaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCantidadMaximaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBMinimoMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBMaximoMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorComisionar_Leave(object sender, EventArgs e)
        {
            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCompraPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void CBProductosOfertable_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void CBImportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBExportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBManejaComision_CheckedChanged(object sender, EventArgs e)
        {
            if (CBManejaComision.Checked)
            {
                this.TBComision_Porcentaje.Enabled = true;
                this.TBComision_Porcentaje.BackColor = Color.FromArgb(3, 155, 229);
                
                this.TBComision_Valor.Enabled = true;
                this.TBComision_Valor.BackColor = Color.FromArgb(3, 155, 229);

                this.TBComision_Valor.Text = "0";
                this.TBComision_Porcentaje.Text = "0";
            }
            else
            {
                this.TBComision_Porcentaje.Enabled = false;
                this.TBComision_Porcentaje.BackColor = Color.FromArgb(72, 209, 204);

                this.TBComision_Valor.Enabled = false;
                this.TBComision_Valor.BackColor = Color.FromArgb(72, 209, 204);

                this.TBComision_Valor.Text = "0";
                this.TBComision_Porcentaje.Text = "0";
            }
        }

        private void TBValorGeneral_Lote_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBMinimoMayorista_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCompraPromedio_Leave(object sender, EventArgs e)
        {
            if (TBCompraPromedio.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCompraPromedio.BackColor = Color.FromArgb(3, 155, 229);
            }
            else
            {
                this.TBCompraPromedio.BackColor = Color.FromArgb(3, 155, 229);
                               
                // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
                TextBox tb = (TextBox)sender;

                // Primero verificamos si el valor se puede convertir a Decimal.
                double numero = default(double);
                bool bln = double.TryParse(tb.Text, out numero);

                if ((!(bln)))
                {
                    // No es un valor decimal válido; limpiamos el control.
                    //tb.Clear();
                    return;
                }

                // En la propiedad Tag guardamos el valor con todos los decimales.
                //
                tb.Tag = numero;

                // Y acto seguido formateamos el valor
                // a monetario con dos decimales.
                //
                tb.Text = string.Format("{0:N2}", numero);
            }
           
        }

        private void TBVentaMayorista_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBVentaMayorista.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBComision_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBComision_Porcentaje.BackColor = Color.Azure;
        }

        private void TBComision_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBComision_Porcentaje.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBVentaMayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.TBCosto_Fabricacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBComision_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    if (CBManejaComision.Checked)
                    {
                        //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente
                        this.TBComision_Valor.Select();
                    }
                    else
                    {
                        this.TBVentaMinina_Cliente.Select();
                    }
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBComision_Porcentaje.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBComision_Porcentaje.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorParaComision_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBVentaMinina_Cliente.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBComision_Valor.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBComision_Valor.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBMinimoMayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBVentaMaxima_Mayorista.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinima_Mayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMinima_Mayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBMaximoMayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCompraPromedio.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Mayorista.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBVentaMaxima_Mayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorParaComision_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBComision_Valor.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCantidadMininaCliente_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBVentaMinina_Cliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCantidadMaximaCliente_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBVentaMaxima_Cliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBMinimoMayorista_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBVentaMinima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBMaximoMayorista_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBVentaMaxima_Mayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigodeBarra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    if (TBBuscar_CodigodeBarra.Text==string.Empty)
                    {
                        MensajeError("Por favor digite el Codigo de Barra que desea registrar");
                        this.TBBuscar_CodigodeBarra.Focus();
                    }
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLotedeingreso.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLotedeingreso.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //******************** FOCUS LEAVE VALORES ********************

        private void TBValordecompra_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCompraFinal.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBValorVenta_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValorVenta_NoExcento.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBLotedeingreso_Enter(object sender, EventArgs e)
        {
            this.TBLotedeingreso.BackColor = Color.Azure;
        }

        private void TBValor_Lote_Enter(object sender, EventArgs e)
        {
            this.TBValor_Lote.BackColor = Color.Azure;
        }

        private void TBLotedeingreso_Leave(object sender, EventArgs e)
        {
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBValor_Lote_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValor_Lote.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCodigodeBarra_Enter(object sender, EventArgs e)
        {
            this.TBBuscar_CodigodeBarra.BackColor = Color.Azure;
        }

        private void TBCodigodeBarra_Leave(object sender, EventArgs e)
        {
            this.TBBuscar_CodigodeBarra.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void TBValorVenta_SinImpuesto_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBValorVenta_Excento.BackColor = Color.Azure;
        }

        private void TBValorVenta_SinImpuesto_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValorVenta_Excento.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }
     
        //******************** FOCUS LEAVE UBICACION ********************
        private void TBUbicacion_Leave(object sender, EventArgs e)
        {
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBEstante_Leave(object sender, EventArgs e)
        {
            this.TBEstante.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBNivel_Leave(object sender, EventArgs e)
        {
            this.TBNivel.BackColor = Color.FromArgb(3, 155, 229);
        }

        //******************** FOCUS LEAVE CANTIDADES ********************

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.Azure;
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void CBBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBodega.SelectedIndex != 0)
            {
                this.TBUbicacion.Select();
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fProductos.Buscar(this.TBBuscar.Text, 1);
                        this.DGResultados.Columns[0].Visible = false;

                        lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

                        this.btnEliminar.Enabled = true;
                        this.btnImprimir.Enabled = true;
                    }
                    else
                    {
                        //this.Limpiar_Datos();

                        //Se Limpian las Filas y Columnas de la tabla
                        this.DGResultados.DataSource = null;
                        this.DGResultados.Enabled = false;
                        this.lblTotal.Text = "Datos Registrados: 0";

                        this.btnEliminar.Enabled = false;
                        this.btnImprimir.Enabled = false;
                    }
                }

                else
                {
                    MessageBox.Show(" El Usuario Iniciado no Contiene Permisos Para Realizar Consultas", "Leal Enterprise - 'Acceso Denegado' ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void TBIdproducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Datos = Negocio.fProductos.Buscar(this.TBIdproducto.Text, 2);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("Actualmente no se encuentran registros en la Base de Datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Captura de Valores en la Base de Datos

                    //Panel Datos Basicos - Llaves Primarias
                    Idmarca = Datos.Rows[0][0].ToString();
                    Idgrupo = Datos.Rows[0][1].ToString();
                    Idtipo = Datos.Rows[0][2].ToString();
                    Idempaque = Datos.Rows[0][3].ToString();
                    Idbodega = Datos.Rows[0][4].ToString();
                    Idproveedor = Datos.Rows[0][5].ToString();
                    Idimpuesto = Datos.Rows[0][6].ToString();

                    //Panel Datos Basicos
                    Codigo = Datos.Rows[0][7].ToString();
                    Nombre = Datos.Rows[0][8].ToString();
                    Referencia = Datos.Rows[0][9].ToString();
                    Descripcion = Datos.Rows[0][10].ToString();
                    Presentacion = Datos.Rows[0][11].ToString();
                    Proveedor = Datos.Rows[0][12].ToString();
                    Impuesto = Datos.Rows[0][13].ToString();
                    //Impuesto_Valor = Datos.Rows[0][14].ToString();
                    UnidadDeVenta = Datos.Rows[0][15].ToString();
                    //ValorUnidad = Datos.Rows[0][16].ToString();
                    ManejaVencimiento = Datos.Rows[0][17].ToString();
                    ManjenaImpuesto = Datos.Rows[0][18].ToString();
                    Importado = Datos.Rows[0][19].ToString();
                    Exportado = Datos.Rows[0][20].ToString();
                    Ofertable = Datos.Rows[0][21].ToString();
                    //VentaImpuesto = Datos.Rows[0][22].ToString();
                    ComisionEmpleado = Datos.Rows[0][23].ToString();

                    //Panel - Valores
                    Valor_Promedio = Datos.Rows[0][24].ToString();
                    Valor_Final = Datos.Rows[0][25].ToString();
                    Valor_Excento = Datos.Rows[0][26].ToString();
                    Valor_NoExcento = Datos.Rows[0][27].ToString();
                    Valor_Mayorista = Datos.Rows[0][28].ToString();
                    Comision = Datos.Rows[0][29].ToString();
                    Valor_Comision = Datos.Rows[0][30].ToString();
                    Minimo_Cliente = Datos.Rows[0][31].ToString();
                    Maximo_Cliente = Datos.Rows[0][32].ToString();
                    Minimo_Mayorista = Datos.Rows[0][33].ToString();
                    Maximo_Mayorista = Datos.Rows[0][34].ToString();

                    //
                    Ubicacion = Datos.Rows[0][35].ToString();
                    Estante = Datos.Rows[0][36].ToString();
                    Nivel = Datos.Rows[0][37].ToString();
                    Imagen = Datos.Rows[0][38].ToString();

                    //
                    Lote = Datos.Rows[0][39].ToString();
                    Valor_Lote = Datos.Rows[0][40].ToString();
                    Fecha_Vencimiento = Datos.Rows[0][41].ToString();
                    
                    //
                    CodigoDeBarra = Datos.Rows[0][42].ToString();
                    

                    //Se procede a completar los campos de texto segun las consulta
                    //Realizada anteriormente en la base de datos

                    this.Marca_SQL = Idmarca;
                    this.CBMarca.SelectedValue = Marca_SQL;
                    
                    this.Grupo_SQL = Idgrupo;
                    this.CBGrupo.SelectedValue = Grupo_SQL;

                    this.Tipo_SQL = Idtipo;
                    this.CBTipo.SelectedValue = Tipo_SQL;

                    this.Empaque_SQL = Idempaque;
                    this.CBEmpaque.SelectedValue = Empaque_SQL;

                    this.Bodega_SQL = Idbodega;
                    this.CBBodega.SelectedValue = Bodega_SQL;

                    //Panel Datos Basicos
                    this.TBCodigo.Text = Codigo;
                    this.TBIdproveedor.Text = Idproveedor;
                    this.TBIdimpuesto.Text = Idimpuesto;

                    //Panel Datos Basicos
                    this.TBCodigo.Text = Codigo;
                    this.TBNombre.Text = Nombre;
                    this.TBReferencia.Text = Referencia;
                    this.TBDescripcion01.Text = Descripcion;
                    this.TBPresentacion.Text = Presentacion;
                    this.CBUnidad.Text = UnidadDeVenta;
                    
                    //Panel - Valores
                    this.TBCompraPromedio.Text = Valor_Promedio;
                    this.TBCompraFinal.Text = Valor_Final;
                    this.TBValorVenta_Excento.Text = Valor_Excento;
                    this.TBValorVenta_NoExcento.Text = Valor_NoExcento;
                    this.TBVentaMayorista.Text = Valor_Mayorista;
                    this.TBComision_Porcentaje.Text = Comision;
                    this.TBComision_Valor.Text = Valor_Comision;
                    this.TBVentaMinina_Cliente.Text = Minimo_Cliente;
                    this.TBVentaMaxima_Cliente.Text = Maximo_Cliente;
                    this.TBVentaMinima_Mayorista.Text = Minimo_Mayorista;
                    this.TBVentaMaxima_Mayorista.Text = Maximo_Mayorista;

                    //
                    this.TBUbicacion.Text = Ubicacion;
                    this.TBEstante.Text = Estante;
                    this.TBNivel.Text = Nivel;
                    //this.PB_Imagen.Image = Imagen;

                    //
                    this.TBLotedeingreso.Text = Lote;
                    this.TBValor_Lote.Text = Valor_Lote;
                    this.DTLote_Vencimiento.Text = Fecha_Vencimiento;

                    //
                    this.TBBuscar_CodigodeBarra.Text = CodigoDeBarra;
                    this.TBBuscar_Proveedor.Text = Proveedor;
                    this.TBBuscar_Impuesto.Text = Impuesto;

                    //Se proceden a Validar los Chexboxt si estan activos o no

                    if (ManejaVencimiento == "0")
                    {
                        this.CBVencimiento.Checked = false;
                    }
                    else
                    {
                        this.CBVencimiento.Checked = true;
                    }

                    if (Importado == "0")
                    {
                        this.CBImportado.Checked = false;
                    }
                    else
                    {
                        this.CBImportado.Checked = true;
                    }

                    if (Exportado == "0")
                    {
                        this.CBExportado.Checked = false;
                    }
                    else
                    {
                        this.CBExportado.Checked = true;
                    }

                    if (ManjenaImpuesto == "0")
                    {
                        this.CBImpuesto.Checked = false;
                    }
                    else
                    {
                        this.CBImpuesto.Checked = true;
                    }

                    if (Ofertable == "0")
                    {
                        this.CBOfertable.Checked = false;
                    }
                    else
                    {
                        this.CBOfertable.Checked = true;
                    }

                    if (ComisionEmpleado == "0")
                    {
                        this.CBManejaComision.Checked = false;
                    }
                    else
                    {
                        this.CBManejaComision.Checked = true;
                    }

                    //Se realizan las consultas para llenar los DataGriview donde se mostrarian las ubicaciones, codigos de barra.

                    //this.DGResultados.DataSource = fProductos.Buscar(this.TBBuscar.Text, 1);
                    //this.DGResultados.Columns[0].Visible = false;

                    //lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Digitar = false;

                if (Editar == "1")
                {
                    this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                    this.TBNombre.Select();

                    //
                    this.Botones();
                }
                else
                {
                    MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Actualizar Datos en el Sistema", "Leal Enterprise - 'Acceso Denegado' ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    this.Digitar = false;

                    if (Editar == "1")
                    {
                        //
                        this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                        this.TBNombre.Select();

                        //Se procede Habilitar los campos de Textos y Botones
                        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        this.Habilitar();
                        this.btnGuardar.Enabled = true;
                        this.btnCancelar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Actualizar Datos", "Leal Enterprise - 'Acceso Denegado' ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PB_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.PB_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PB_Imagen.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
