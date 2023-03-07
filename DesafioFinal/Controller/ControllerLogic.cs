using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal.Controller
{
    class ControllerLogic
    {

        //variables de asignacion de tienda
        private string nombreT = "Tienda La Vecindad";
        private string direccionT = "Centro Comercial";
        private string nombreV = "John";
        private string apellidoV = "Diaz";
        private int codigoV = 1208;
        private int identificacionV = 1098789392;
        private string fechaDeCotizacion;
        private string horaDeCotizacion;

        //variables de asignacion de prendas
        private bool mangaCorta;
        private bool cuelloMao;
        private bool standard;
        private bool premium;
        private int precioUnitario;
        private int cantidad;
        private float precioFinal;
        private float cantidadStock;
        private bool chopin;
        private string desc;
        private string descV;



        //getters y setters
        public string NombreT { get => nombreT; set => nombreT = value; }
        public string DireccionT { get => direccionT; set => direccionT = value; }
        public string NombreV { get => nombreV; set => nombreV = value; }
        public string ApellidoV { get => apellidoV; set => apellidoV = value; }
        public int CodigoV { get => codigoV; set => codigoV = value; }
        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }
        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }
        public bool Standard { get => standard; set => standard = value; }
        public bool Premium { get => premium; set => premium = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public float CantidadStock { get => cantidadStock; set => cantidadStock = value; }
        public bool Chopin { get => chopin; set => chopin = value; }
        public string Desc { get => desc; set => desc = value; }
        public int IdentificacionV { get => identificacionV; set => identificacionV = value; }
        public string FechaDeCotizacion { get => fechaDeCotizacion; set => fechaDeCotizacion = value; }
        public string HoraDeCotizacion { get => horaDeCotizacion; set => horaDeCotizacion = value; }
        public string DescV { get => descV; set => descV = value; }

        //objetos necesarios para la logica
        Tienda ti = new Tienda();
        Vendedor ve = new Vendedor();
        


        //constructor que agrege las variables a los objetos
        public ControllerLogic()
        {
            //asignacion de valores al objeto tienda
            ti.Nombre = nombreT;
            ti.Direccion = direccionT;

            //asignacion de valores al objeto vendedor
            ve.NombreV = nombreV;
            ve.Apellido = apellidoV;
            ve.Codigo = codigoV;
            ve.NumIdentificacion = IdentificacionV;
            //ve.fechaDeCotizacion = FechaDeCotizacion;
            //ve.horaDeCotizacion = HoraDeCotizacion;

        }

      

        public void AsignacionCamisa(bool standard, bool premium, int precioUnitario, int cantidad, bool cuelloMao, bool mangaCorta)
        {
            Camisa cam = new Camisa(standard, premium, precioUnitario, cantidad);
            cam.MangaCorta = mangaCorta;
            cam.CuelloMao = cuelloMao;
            PrecioFinal = cam.CalcularPrecioFinal();
            CantidadStock = cam.CantidadStock;
            if (PrecioFinal != 0)
            {
                ti.DatosPrendas.Add(cam);

            }
            Vendedor ve1 = new Vendedor();
            ve1.NombreV = NombreV;
            ve1.Apellido = ApellidoV;
            ve1.FechaDeCotizacion = DateTime.UtcNow.ToString("MM-dd-yyyy");
            ve1.HoraDeCotizacion = DateTime.Now.ToString("hh:mm:ss");
            ti.DatosVendedor.Add(ve1);
        }
        public void AsignacionPantalon(bool standard, bool premium, int precioUnitario, int cantidad, bool chopin)
        {
  
            Pantalon pan = new Pantalon(standard, premium, precioUnitario, cantidad);
            pan.Chupines = chopin;
            precioFinal = pan.CalcularPrecioFinal();
            cantidadStock = pan.CantidadStock;
            if (precioFinal != 0)
            {
                ti.DatosPrendas.Add(pan);

            }
            Vendedor ve1 = new Vendedor();
            ve1.NombreV = NombreV;
            ve1.Apellido = ApellidoV;
            ve1.FechaDeCotizacion = DateTime.UtcNow.ToString("MM-dd-yyyy");
            ve1.HoraDeCotizacion = DateTime.Now.ToString("hh:mm:ss");
            ti.DatosVendedor.Add(ve1);
        }
        

        public string mostrarListaPrendas() {


            Desc = "";
            

            foreach (Prendas pre in ti.DatosPrendas)
            {
                Desc += "Descripcion: " + pre.Descripcion + "\n"
                    + "Precio total: " + pre.PrecioFinal.ToString() + "\n" 
                    + "--------------------------------------------------------------------------------" + "\n";
              
            }
            

          
            return Desc;
        }
        public string mostrarListaVendedor()
        {
            DescV = "";
            
            foreach (Vendedor ven in ti.DatosVendedor)
            {
                DescV += "Cotizado por : " + ven.NombreV + " " + ven.Apellido + "\n"
                    +"Fecha de cotizacion : "+ ven.FechaDeCotizacion  + "\n"
                    +"Hora de cotizacion : " + ven.HoraDeCotizacion+ "\n"+
                    "---------------------------------------------------" + "\n" ;

            }

            return DescV;

        }
        
    }
}
