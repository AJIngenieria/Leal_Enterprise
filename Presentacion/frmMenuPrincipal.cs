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
    public partial class frmMenuPrincipal : Form
    {
        //Parametros Basicos
        public string Idempleado = "";
        public string Empleado = "";
        public string UsuarioLogueado = "";
        public string Idusuario = "";

        //Menu Principal
        public string Menu_Almacen = "";
        public string Menu_GestionHumana = "";
        public string Menu_Productos = "";
        public string Menu_Reportes = "";
        public string Menu_Sistema = "";
        public string Menu_Ventas = "";

        //Permisos de Operacion Que Vienen de la Base de Datos

        public string SQL_Guardar = "";
        public string SQL_Editar = "";
        public string SQL_Eliminar = "";
        public string SQL_Consultar = "";
        public string SQL_Imprimir = "";

        //
        public string Cede = "";

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.TSEmpleado.Text = Empleado;
            this.TSUsuario.Text = UsuarioLogueado;
        }
       
        private void datosBasicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();

            frmEmpleados.Guardar = Convert.ToString(this.SQL_Guardar);
            frmEmpleados.Editar = Convert.ToString(this.SQL_Editar);
            frmEmpleados.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmEmpleados.Consultar = Convert.ToString(this.SQL_Consultar);
            frmEmpleados.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento frmDepartamento = new frmDepartamento();
            frmDepartamento.MdiParent = this;
            frmDepartamento.Show();

            frmDepartamento.Guardar = Convert.ToString(this.SQL_Guardar);
            frmDepartamento.Editar = Convert.ToString(this.SQL_Editar);
            frmDepartamento.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmDepartamento.Consultar = Convert.ToString(this.SQL_Consultar);
            frmDepartamento.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void datosBasicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpuesto frmImpuesto = new frmImpuesto();
            frmImpuesto.MdiParent = this;
            frmImpuesto.Show();

            frmImpuesto.Guardar = Convert.ToString(this.SQL_Guardar);
            frmImpuesto.Editar = Convert.ToString(this.SQL_Editar);
            frmImpuesto.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmImpuesto.Consultar = Convert.ToString(this.SQL_Consultar);
            frmImpuesto.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio frmServicio = new frmServicio();
            frmServicio.MdiParent = this;
            frmServicio.Show();

            frmServicio.Guardar = Convert.ToString(this.SQL_Guardar);
            frmServicio.Editar = Convert.ToString(this.SQL_Editar);
            frmServicio.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmServicio.Consultar = Convert.ToString(this.SQL_Consultar);
            frmServicio.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Escape))
                {
                    DialogResult result = MessageBox.Show("¿Desea Salir del Sistema?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();

                    }
                    else
                    {
                        this.Refresh();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBodega frmBodega = new frmBodega();
            frmBodega.MdiParent = this;
            frmBodega.Show();

            frmBodega.Guardar = Convert.ToString(this.SQL_Guardar);
            frmBodega.Editar = Convert.ToString(this.SQL_Editar);
            frmBodega.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmBodega.Consultar = Convert.ToString(this.SQL_Consultar);
            frmBodega.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void sucurzalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucurzal frmSucurzal = new frmSucurzal();
            frmSucurzal.MdiParent = this;
            frmSucurzal.Show();

            frmSucurzal.Guardar = Convert.ToString(this.SQL_Guardar);
            frmSucurzal.Editar = Convert.ToString(this.SQL_Editar);
            frmSucurzal.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmSucurzal.Consultar = Convert.ToString(this.SQL_Consultar);
            frmSucurzal.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }
    }
}
