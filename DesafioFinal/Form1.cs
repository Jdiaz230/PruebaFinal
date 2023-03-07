using DesafioFinal.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class Form1 : Form
    {
        ControllerLogic co = new ControllerLogic();

        public Form1()
        {
            InitializeComponent();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //asignacion o inicializacion de check box y text
            checkBoxMangaCorta.Visible = false;
            checkBoxMao.Visible = false;
            checkBoxChupin.Visible = false;
            mensajeStock.Visible = false;
            pruebaCantidad.Visible = false;
            NombreTienda.Text = co.NombreT;
            direccionTienda.Text = co.DireccionT;
            NombreApellido.Text = co.NombreV + " " + co.ApellidoV;
            codigoVendedor.Text = "Codigo: " + co.CodigoV.ToString();
            
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            //variables incializadas
            bool checkCamisa = checkBoxCamisa.Checked;
            bool checkPantalon = checkBoxPantalon.Checked;
            bool mangaCorta = checkBoxMangaCorta.Checked;
            bool cuelloMao= checkBoxMao.Checked;
            bool chupin = checkBoxChupin.Checked;
            int precioUnitario=0;
            int cantidad=0 ;
            bool standard = CheckBoxStandard.Checked;
            bool premium = CheckBoxPremium.Checked;
            pruebaCantidad.Visible = false;
            


            try {
                precioUnitario = int.Parse(textBoxPrecioUnitario.Text);
                cantidad = int.Parse(textBoxCantidad.Text);
            }
            catch (FormatException) { 
                pruebaCantidad.Visible = true;
                totalCotizacion.Text = "0";
            }

            //validacion para que agregue cantidad de prenda
            if (cantidad > 0 && precioUnitario > 0)
            {

                //condicionales para los check box

                if (checkCamisa)
                {
                    //inicio metodo de camisa
                    co.AsignacionCamisa(standard, premium, precioUnitario, cantidad, cuelloMao, mangaCorta);

                    //inicia cotizacion calcular precio final y asignacion de cantidad disponible
                    totalCotizacion.Text = co.PrecioFinal.ToString();
                    unidadesDisponibles.Text = co.CantidadStock.ToString();
                    
                    //comparativa de unidades en stock
                    if (int.Parse(unidadesDisponibles.Text) < int.Parse(textBoxCantidad.Text))
                    {
                        mensajeStock.Visible = true;
                        totalCotizacion.Text = "0";
                        
                    }
                    else
                    {
                        mensajeStock.Visible = false;
                    }
                   
                }
                if (checkPantalon)
                {
                    //Inicio metodo de pantalon
                    co.AsignacionPantalon(standard, premium, precioUnitario, cantidad, chupin);


                    //cotizacion
                    totalCotizacion.Text = co.PrecioFinal.ToString();
                    unidadesDisponibles.Text = co.CantidadStock.ToString();
                   
                    
                    //comparativa de stock
                    if (int.Parse(unidadesDisponibles.Text) < int.Parse(textBoxCantidad.Text))
                    {
                        mensajeStock.Visible = true;
                        totalCotizacion.Text = "0";
                        
                    }
                    else
                    {
                        mensajeStock.Visible = false;
                    }
                    
                }
            }
            else { pruebaCantidad.Visible = true; }

        }

        //parte visual de windowsform
        private void checkBoxCamisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPantalon.Visible = !checkBoxCamisa.Checked;
            checkBoxMangaCorta.Visible = checkBoxCamisa.Checked;
            checkBoxMao.Visible = checkBoxCamisa.Checked;
            
        }

        private void checkBoxPantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCamisa.Visible = !checkBoxPantalon.Checked;
            checkBoxChupin.Visible = checkBoxPantalon.Checked;

        }

        private void CheckBoxPremium_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxStandard.Visible = !CheckBoxPremium.Checked;
        }

        private void CheckBoxStandard_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxPremium.Visible = !CheckBoxStandard.Checked;
        }

        private void linkLabelHistorialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = co.mostrarListaPrendas();
            form2.label2.Text = co.mostrarListaVendedor();
            form2.Show();
 
        }

        
    } 
}
