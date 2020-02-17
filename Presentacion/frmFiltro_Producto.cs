using System;
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
    public partial class frmFiltro_Producto : Form
    {
        private DataTable DtDetalle = new DataTable();

        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;
        public bool Filtro = true;
        //private string Campo = "Campo Obligatorio - Leal Enterprise";

        //Variable para Captura el Empleado Logueado
        public int Idempleado;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        public frmFiltro_Producto()
        {
            InitializeComponent();
        }

        private void frmFiltro_Producto_Load(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TBBuscar.Text != "")
                {
                    this.DGResultados.DataSource = fProductos.Buscar(this.TBBuscar.Text, 4);
                    //this.DGResultadoss.Columns[1].Visible = false;

                    lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
                    this.DGResultados.Enabled = true;
                }
                else
                {

                    //Se Limpian las Filas y Columnas de la tabla
                    this.DGResultados.DataSource = null;
                    this.DGResultados.Enabled = false;
                    this.lblTotal.Text = "Datos Registrados: 0";

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
                //frmBodega_Ingresos frmBI = new frmBodega_Ingresos();

                //int codigo;
                //string producto, precio;

                //codigo = Convert.ToInt32(DGResultados.CurrentRow.Cells["Codigo"].Value);
                //producto = Convert.ToString(DGResultados.CurrentRow.Cells["Producto"].Value);

                //frmBI.Agregar_Detalle(codigo, producto);

                frmBodega_Ingresos frmBI = new frmBodega_Ingresos();

                frmBI.Agregar_Detalle
                        (
                            Convert.ToInt32(DGResultados.CurrentRow.Cells["Codigo"].Value),
                            Convert.ToString(DGResultados.CurrentRow.Cells["Producto"].Value),
                            Convert.ToString(DGResultados.CurrentRow.Cells["Precio"].Value)
                        //Convert.ToInt32(Tabla.Rows[0][3]),
                        //Convert.ToInt32(Tabla.Rows[0][4])
                        );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.Azure;
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }
    }
}
