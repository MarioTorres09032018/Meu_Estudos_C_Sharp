using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Switch (Desvio - OU SEJA: VERIFIQUE MES 1, NÃO CORRESPONDE AO MÊS CONTIDO NA VARIAVEL "INT", PARE. DESVIE PARA O FIM DA LINHA, RECOMECE O CASE E VERIFIQUE MES 2. 
            //E ASSIM SUCESSIVAMENTE, MES 3, MES 4... ATÉ RETORNAR O VALOR 12) E EXIBIR NA MESSAGEBOX.
            // *OBS: POR UMA QUESTÃO DE SÍNTAXE, O CSHARP EXIGE QUE TENHA UM BREAK APÓS CADA CASE. SENÃO DARÁ ERRO.
            int mes = 12;
            switch (mes)
            {
                case 1 :                          //DIFERENTE DE "IIF" NO QUAL OS ":" SIGNIFICAM "SENÃO", QUE DEVOLVEM RESULTADO DE VERIFICAÇÃO "FALSO" ("?" ENTÃO, ":" SENÃO).
                    MessageBox.Show("janeiro");   //OS ":" SIGNIFICAM "ENTÃO" EM "SWITCHCASE". TRADUZINDO: "caso mes 1 seja igual a 12, então exibe msgBox e pare "BREAK". 
                    break;                        //vai pro fim da linha, e recomeça outro case até devolver valor 12 e exibir na MessageBox" ISSO SE VERIFICA DEBUGANDO F10.
                case 2 :
                    MessageBox.Show("fevereiro");
                    break;
                case 3:
                    MessageBox.Show("março");
                    break;
                case 4:
                    MessageBox.Show("abril");
                    break;
                case 5:
                    MessageBox.Show("maio");
                    break;
                case 6:
                    MessageBox.Show("junho");
                    break;
                case 7:
                    MessageBox.Show("julho");
                    break;
                case 8:
                    MessageBox.Show("agosto");
                    break;
                case 9:
                    MessageBox.Show("setembro");
                    break;
                case 10:
                    MessageBox.Show("outubro");
                    break;
                case 11:
                    MessageBox.Show("novembro");
                    break;
                case 12:                    
                    MessageBox.Show("dezembro");
                    break; 
                    

                default:           /*caso não seja nenhum dos 12 meses, por padrão, sempre cairá em "default" e irá para a próxima linha e exibirá a informação "Invalido",
                                    *contido na MessageBox abaixo.
                                    */
                    MessageBox.Show("Invalido");    
                    break;                  
                   

                
            }

        }
    }
}
