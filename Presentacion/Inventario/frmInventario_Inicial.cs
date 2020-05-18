using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmInventario_Inicial : Form
    {
        //Instancia para el filtro de los productos 
        private static frmInventario_Inicial _Instancia;

        public static frmInventario_Inicial GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmInventario_Inicial();
            }
            return _Instancia;
        }

        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar, Eliminar
        private bool Digitar = true;
        public bool Filtro = true;
        public bool Examinar = true;

        //
        private DataTable DtDetalle = new DataTable();

        //Variables de Validaciones
        public int Idempleado; //Variable para Captura el Empleado Logueado
        private string Campo_Obligatorio = "Campo Obligatorio";

        //********** Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar *************************

        public string Guardar, Editar, Consultar, Eliminar, Imprimir = "";

        public frmInventario_Inicial()
        {
            InitializeComponent();
        }

        private void frmInventario_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }


        private void frmInventario_Inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
