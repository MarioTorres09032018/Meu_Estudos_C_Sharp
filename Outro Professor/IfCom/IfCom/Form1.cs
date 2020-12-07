using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ? = ENTÃO       
            // : = SENÃO

            //VERIFICAÇÃO, VERDADEIRO , FALSO;
            //SEXO = "M" ? "MASCULINO" : "FEMININO";

            string letraSexo = "M";
            string sexo = letraSexo == "M" ? "Masculino" : "Feminino";

            MessageBox.Show(sexo);

            // COM NUMEROS INTEIROS

            int idade = 60;

            string resultado = idade >= 60 ? "Idoso" : "Não é Idoso";
            MessageBox.Show(resultado);  
            
            

        }
    }
}
