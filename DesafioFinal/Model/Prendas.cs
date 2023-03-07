using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    abstract class Prendas : Tienda
    {
        protected bool standard;
        protected bool premium;
        protected int precio;
        private int cantidadStock;
        private int cantidad;
        private int precioFinal;
        private string descripcion;

        public int PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }

        public abstract float CalcularPrecio();
        public float CalcularPrecioFinal()
        {
            if(premium || standard) {

                CalcularPrecio();
                if (premium)
                {
                    PrecioFinal += (PrecioFinal * 30) / 100;
                    precioFinal *= Cantidad;
                    CantidadStock /= 2;
                    Descripcion += "\nCalidad Premium";
                }
                else {
                    CantidadStock /= 2;
                    precioFinal *= Cantidad;
                    Descripcion += "\nCalidad Standard"; }
                
            }
            return PrecioFinal;
        }
       
       
    }
}
