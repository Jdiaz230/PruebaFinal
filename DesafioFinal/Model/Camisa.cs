using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    class Camisa:Prendas
    {
        private bool mangaCorta;

        private bool cuelloMao;

        public Camisa(bool standard, bool premium, int precio, int cantidad
           )
        {
            this.standard = standard;
            this.premium = premium;
            this.precio = precio;
            this.Cantidad = cantidad;
        }

        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }
        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }

        public override float CalcularPrecio()
        {
            if (MangaCorta) 
            {

                precio -= (precio * 10) / 100;

                if (CuelloMao)
                {   //manga corta cuello mao 200 
                    precio += (precio * 3) / 100;
                    
                    CantidadStock = 200;
                    Descripcion += " Camisa manga corta,cuello mao";
                }
                else if (!CuelloMao)
                {
                    //manga corta cuello comun 300
                    CantidadStock = 300;
                    
                    Descripcion += " Camisa manga corta,cuello común";
                }
            }
            //si es manga larga
            else if (!mangaCorta) {

                if (CuelloMao)
                {   // manga larga cuello mao 150 
                    precio += (precio * 3) / 100;
                    
                    CantidadStock = 150;
                    Descripcion += "  Camisa manga larga, cuello mao";
                }
                else if (!CuelloMao)
                {
                    //manga larga cuello comun 350
                    CantidadStock = 350;
                    
                    Descripcion += "  Camisa manga larga,cuello común";
                }
            }

            
            this.PrecioFinal += precio;
            return PrecioFinal;
        }
    }
}
