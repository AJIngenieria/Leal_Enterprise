using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_Impuesto
    {
        //Llaves primarias       
        private int _Idimpuesto;

        //Datos Basicos
        private string _Impuesto;
        private string _Valor;
        private string _Descripcion;
        private int _Estado;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public string Impuesto { get => _Impuesto; set => _Impuesto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
    }
}
