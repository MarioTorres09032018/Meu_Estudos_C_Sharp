using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_App_Teste
{
    public partial class Form1 : Form
    {
        public Form1()

            /*
             * 
             */
        {
            InitializeComponent();
        }

        private void BtnValor_Click(object sender, EventArgs e)
        {
            string Carro;
            MessageBox.Show("VEJA NOSSOS VALORES MAIS ACESSÍVEIS AO SEU BOLSO");  //CARROS de R$ 16.000,00 a R$ 22.000,00
            Carro = ("Celta 1.0  (CARROS de R$ 16.000,00 a R$ 22.000,00)");
            label1.Text = (Carro);
            MessageBox.Show("R$ 16.000,00");

            string Carro2;
            Carro2 = ("Palio 1.6 (CARROS de R$ 16.000,00 a R$ 22.000,00)");
            label1.Text = (Carro2);
            MessageBox.Show("R$ 18.250,00");

            string Carro3;
            Carro3 = ("Renault Clio (CARROS de R$ 16.000,00 a R$ 22.000,00)");
            label1.Text = (Carro3);
            MessageBox.Show("R$ 20.770,00");

            string Carro4;
            Carro4 = ("Agile 1.3 (CARROS de R$ 16.000,00 a R$ 22.000,00)");
            label1.Text = (Carro4);
            MessageBox.Show("R$ 22.000,00");
            label1.Text = ("");


            string Carro5;
            MessageBox.Show("VEJA NOSSOS VALORES PARA CARROS COMPLETOS E A PREÇO BOM");  //CARROS de R$ 25.000,00 a R$ 35.000,00
            Carro5 = ("Polo SportLine 2.0 (CARROS de R$ 25.000,00 a R$ 35.000,00)");
            label1.Text = (Carro5);
            MessageBox.Show("R$ 28.660,00");

            string Carro6;
            Carro6 = ("Nissan Sentra 2.0 (CARROS de R$ 25.000,00 a R$ 35.000,00)");
            label1.Text = (Carro6);
            MessageBox.Show("R$ 33.250,00");

            string Carro7;
            Carro7 = ("Chevrolet Cobalt 1.8 (CARROS de R$ 25.000,00 a R$ 35.000,00)");
            label1.Text = (Carro7);
            MessageBox.Show("R$ 33.900,00");

            string Carro8;
            Carro8 = ("Ford Ka 1.5 (CARROS de R$ 25.000,00 a R$ 35.000,00)");
            label1.Text = (Carro8);
            MessageBox.Show("R$ 35.000,00");
            label1.Text = ("");

            string Carro9;
            MessageBox.Show("CARROS PARA CLIENTES EXIGENTES!");                         //CARROS de R$ 40.000,00 a R$ 60.000,00
            Carro9 = ("Citroen C3 1.6 (CARROS de R$ 40.000,00 a R$ 60.000,00)");
            label1.Text = (Carro9);
            MessageBox.Show("R$ 42.900,00");

            string Carro10;
            Carro10 = ("Peugeot 208 (CARROS de R$ 40.000,00 a R$ 60.000,00)");
            label1.Text = (Carro10);
            MessageBox.Show("R$ 40.880,00");

            string Carro11;
            Carro11 = ("Chevrolet Prisma 1.4  (CARROS de R$ 40.000,00 a R$ 60.000,00)");
            label1.Text = (Carro11);
            MessageBox.Show("R$ 40.150,00");

            string Carro12;
            Carro12 = ("Fiat Argo 1.3 (CARROS de R$ 40.000,00 a R$ 60.000,00)");
            label1.Text = (Carro12);
            MessageBox.Show("R$ 41.900,00");
            label1.Text = ("");

            string Carro13;
            MessageBox.Show("CARROS PARA CLIENTES VIP!");                       //CARROS de R$ 65.000,00 a R$ 80.000,00
            Carro13 = ("Toyota Yaris Sedan 1.5 (CARROS de R$ 65.000,00 a R$ 80.000,00)");
            label1.Text = (Carro13);
            MessageBox.Show("R$ 66.700,00");

            string Carro14;
            Carro14 = ("Jac T40 1.5 (CARROS de R$ 65.000,00 a R$ 80.000,00)");
            label1.Text = (Carro14);
            MessageBox.Show("R$ 69.250,00");

            string Carro15;
            Carro15 = ("Lifan X60 1.8 (CARROS de R$ 65.000,00 a R$ 80.000,00)");
            label1.Text = (Carro15);
            MessageBox.Show("R$ 72.360,00");

            string Carro16;
            Carro16 = ("Suzuki Jimmy 1.3 (CARROS de R$ 65.000,00 a R$ 80.000,00)");
            label1.Text = (Carro16);
            MessageBox.Show("R$ 75.800,00");
            label1.Text = ("");

            string Carro17;
            MessageBox.Show("CARROS PARA CLIENTES DE CLASSE!");                       //CARROS de R$ 82.000,00 a R$ 100.000,00
            Carro17 = ("Citroen C4 Cactus (CARROS de R$ 82.000,00 a R$ 100.000,00)");
            label1.Text = (Carro17);
            MessageBox.Show("R$ 83.700,00");

            string Carro18;
            Carro18 = ("Volkswagen Polo GTS (CARROS de R$ 82.000,00 a R$ 100.000,00)");
            label1.Text = (Carro18);
            MessageBox.Show("R$ 69.250,00");

            string Carro19;
            Carro19 = ("Mercedes Benz A200(CARROS de R$ 82.000,00 a R$ 100.000,00)");
            label1.Text = (Carro19);
            MessageBox.Show("R$ 100.360,00");

            string Carro20;
            Carro20 = ("Chevrolet Tracker 1.2 (CARROS de R$ 82.000,00 a R$ 100.000,00)");
            label1.Text = (Carro20);
            MessageBox.Show("R$ 86.800,00");
            label1.Text = ("");

            string Carro21;
            MessageBox.Show("CARROS PARA CLIENTES DE LUXO!");                       //CARROS de R$ 150.000,00 a R$ 200.000,00
            Carro21 = ("Audi A5 (CARROS de R$ 150.000,00 a R$ 200.000,00)");
            label1.Text = (Carro21);
            MessageBox.Show("R$ 199.000,00");

            string Carro22;
            Carro22 = ("Audi A3 2020 (CARROS de R$ 150.000,00 a R$ 200.000,00)");
            label1.Text = (Carro22);
            MessageBox.Show("R$ 152.300,00");

            string Carro23;
            Carro23 = ("Lexus CT 200h (CARROS de R$ 150.000,00 a R$ 200.000,00)");
            label1.Text = (Carro23);
            MessageBox.Show("R$ 164.360,00");

            string Carro24;
            Carro24 = ("BMW 118i Sport GP (CARROS de R$ 150.000,00 a R$ 200.000,00)");
            label1.Text = (Carro24);
            MessageBox.Show("R$ 197.950,00");

            Close();
        }
        }
                }
            
        
    
