using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prendas> datosPrendas = new List<Prendas>();
        private List<Vendedor> datosVendedor = new List<Vendedor>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prendas> DatosPrendas { get => datosPrendas; set => datosPrendas = value; }
        internal List<Vendedor> DatosVendedor { get => datosVendedor; set => datosVendedor = value; }
    }
}
