using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        int minuto = 0;
        int segundos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;                               //PRIMEIRO CONFIGURA O FORM PARA QUE A IMAGEM NÃO FIQUE VISÍVEL QUANDO CARREGAR O FORMULÁRIO
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;    // TODA VEZ QUE O MEU TIMER (BOTÃO "Start") FOR APERTADO, A PICTUREBOX IRÁ SUMIR.
            tempo = Convert.ToInt16(textBox1.Text);           

            if (tempo >= 60)       //SE O TEMPO ULTRAPASSAR 60 SEGUNDOS (>=60), ESTE (TEMPO) SERÁ DIVIDIDO POR 60 QUE É IGUAL A 1 MINUTO. A SOBRA(%), DECAIRÁ PARA SEGUNDOS.
            {
                minuto = tempo / 60;      //EXEMPLO PRATICO DESTA FORMULA: 
                //SE TEMPO É = 6O E MINUTO É = 60, ENTÃO: 60 DIVIDIDO POR 60 = 1 MINUTO (60/60=1).  
                //SE TEMPO FOSSE 120, MINUTO CONTINUARIA SENDO 60. ENTÃO: 120 DIVIDIDO POR 60 = 2 MINUTOS. (120/60=2).

                segundos = tempo % 60;    //ESSA REGRA COM O PORCENTO (%) SIGNIFICA "RESTO DE TEMPO". É O QUE SOBRA DA DIVISÃO ENTRE "TEMPO" POR 60.
                //EXEMPLO PRÁTICO: SE O USUARIO DIGITAR NA TEXTBOX1 80, OU SEJA: 80(TEMPO) / 60( 1 MINUTO) = SOBRA(%) DE 20 SEGUNDOS.
            }
            else
            {
                minuto = 0;              //OU O USUARIO PODE DIGITAR TEMPO INFERIOR A 1 MINUTO, 60 SEGUNDOS. OU SEJA, (O TEMPO NÃO É MAIOR IGUAL A 60, E SIM MENOR).
                segundos = tempo;        //EX: 10 SEGUNDOS, 20 SEGUNDOS... ENTÃO ESTA FORMULA SE APLICA.

            }
            label2.Text = "0" + minuto + ":" + segundos;       //A FORMA QUE SERÁ EXIBIDO NA TEXTBOX1.   
            timer1.Enabled = true;
            //POR ÚLTIMO, ADICIONA A FERRAMENTA "TIMER" ARRASTANDO-A E SOLTANDO SOBRE O FORMULARIO.                                                               
            //AGORA SERÃO ALTERADOS AS PROPRIEDADES DA FERRAMENTA "TIMER".
            //EM "Interval" APAGA O "100" E COLOCA-SE "1000". (POIS A CONTAGEM SERÁ EM MILISEGUNDOS). 
            //"Enable = False". OU SEJA, O TIMER NÃO SERÁ ATIVADO QUANDO RODAR O APLICATIVO E SIM, QUANDO APERTAR
            //O BOTÃO "Start". SE COLOCAR "True", O TIMER INICIARÁ QUANDO RODAR O APP.


            // AGORA, ADICIONA A LINHA DE COMANDO "timer1.Enabled = true;". ABAIXO DE "label2.Text = "0" + minuto + ":" + segundos;".
        }

        private void timer1_Tick(object sender, EventArgs e) //ADICIONA UM "TICK". OU SEJA, A CADA 1 SEGUNDO (1000 MILISEGUNDOS DE ESTOURO DO TIMER), DISPARA O COMANDO ABAIXO:
        {
            segundos = segundos - 1;        //OU segundo--, QUE É A MESMA COISA.
            if (minuto > 0)
         {
           if (segundos < 0)
           {
               segundos = 59;
               minuto--;
           }
        }
            label2.Text = "0" + minuto + ":" + segundos;  //REPETE O TRECHO DE CODIGO ACIMA. POIS DE UM EM UM SEGUNDO EU QUERO QUE REPITA A ATUALIZAÇÃO DO TEMPO. DE ACORDO
                                                          //COM A FUNÇÃO "timer1_Tick" LÁ EM CIMA. QUE ATUALIZA O VALOR DOS SEGUNDOS E DOS MINUTOS.
            if (minuto == 0 && segundos == 0) 
            {
                timer1.Enabled = false;                       //ESTE COMANDO É PARA QUANDO CHEGAR A ZERO, PARAR. SENÃO, IRÁ CONTINUAR CONTANDO: -1,-2,-3,-4....
                pictureBox1.Visible = true;

                
                
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                FIZ DESTA MANEIRA O COMANDO DE PARAR O CONTADOR E TAMBÉM DEU CERTO:
                 

                timer1.Stop();                           // ESTE COMANDO É PARA QUANDO CHEGAR A ZERO, PARAR. SENÃO, IRÁ CONTINUAR CONTANDO: -1,-2,-3,-4....
                pictureBox1.Visible = true;
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/                     
            }
     
    }
    }
}
