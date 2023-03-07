using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    class Pantalon:Prendas
    {
       
       private bool chupines;

        public Pantalon(bool standard,bool premium,int precio, int cantidad
            ) {
            this.standard = standard;
            this.premium = premium;
            this.precio = precio;
            this.Cantidad = cantidad;
        }

        
        public bool Chupines { get => chupines; set => chupines = value; }

        public override float CalcularPrecio()
        {

            if (Chupines)
            {
                //1500 chupines 
                precio -= (precio * 12) / 100;
                CantidadStock = 1500;
                Descripcion += " Pantalon, Chupín";

            }
            else
            {
                //500 comunes
                CantidadStock = 500;
                Descripcion += " Pantalon, Común";
            }
           this.PrecioFinal += precio; 
            return PrecioFinal;
            
                           
        }

       
    }
}
