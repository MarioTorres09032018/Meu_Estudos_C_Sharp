using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            // FOR (PARA) - LAÇO DE REPETIÇAO, LOOP, ESTRUTURA DE REPETIÇÃO, DIRETIVA FOR

            // for (inicializador ; condição/filtro ; atualização)


            for (int mes = 1 ; mes <= 12 ; mes = mes + 1) //mes = 1 (inicializador, onde começa o "for"); mes <= 12 (condição/filtro - enquanto o mes for menor igual a 12, 
                MessageBox.Show(mes.ToString());          //imprime no MessageBox) ; mes = mes +1 (incrementador "mes++").
             

               
            
            // MESES NA ORDEM DECRESCENTE                 
            {
            for (int mes = 12 ; mes >= 1 ; mes = mes - 1) //mes = 12 (inicializador, onde começa o "for"); mes >= 1 (condição/filtro - enquanto o mes na ordem 
                MessageBox.Show(mes.ToString());          //decrescente for maior igual a 1, imprime no MessageBox) ; mes = mes - 1 (incrementador "mes--").
            {
                MessageBox.Show("URSINHOS CARINHOSOS!");// QUE BOSTA! KKKKK
            }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();                    
        }
    }
}
