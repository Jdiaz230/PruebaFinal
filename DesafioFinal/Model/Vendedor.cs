using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{   
                            
    class Vendedor:Tienda
    {
        private string nombreV;
        private string apellido;
        private int codigo;
        private int numIdentificacion;
        private string horaDeCotizacion;
        private string fechaDeCotizacion;

        public string NombreV { get => nombreV; set => nombreV = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int NumIdentificacion { get => numIdentificacion; set => numIdentificacion = value; }
        public string HoraDeCotizacion { get => horaDeCotizacion; set => horaDeCotizacion = value; }
        public string FechaDeCotizacion { get => fechaDeCotizacion; set => fechaDeCotizacion = value; }
    }
}
