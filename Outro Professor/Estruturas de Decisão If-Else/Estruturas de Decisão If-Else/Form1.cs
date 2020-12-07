using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas_de_Decisão_If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

     
        }

        private void button3_Click(object sender, EventArgs e)
        {
                                 //________TABELA PROPOSTA_______//     
                                
                                /* Bebê de 0 a 2 anos
                                   Criança de 3 a 12 anos
                                   Adolescente de 13 a 17 anos
                                   Adulto de 18 a 59 anos
                                   Idoso acima de 60 anos*/


            int idadeAnos;
                idadeAnos = -1; //HELENA
            if (idadeAnos <= 3)
            MessageBox.Show("HELENA É BEBÊ");
            if(idadeAnos <= 0)                           //ESTA PAERTE TEM FUNÇÃO DE COMPARAÇÃO "==". POIS HELENA TEM 0 ANOS (3 MESES). 
            MessageBox.Show("HELENA TEM 3 MESES");      //SENDO ASSIM A COMPARAÇÃO idadeAnos = 0; E A MENSAGEM NA messageBox será "HELENA TEM 3 MESES".


            int idadeAnos1;
                idadeAnos1 = 14; //NICOLAS
            if (idadeAnos1 <= 12)
            MessageBox.Show ("NICOLAS É CRIANÇA");
                                                        // ESSA PARTE É APENAS SIM OU NÃO. POIS NICOLAS TEM 14 ANOS. idadeAnos = 14; SE APENAS OS MENORES DE 12 ANOS NA PROPOSTA
                                                        // "if" SÃO CRIANÇAS sendo 14>12, A PROPOSTA PULA PARA "else" QUE DÁ A MENSAGEM "NICOLAS É ADOLESCENTE"
            else 
            MessageBox.Show ("NICOLAS É ADOLESCENTE");


//          INTERVALO &&:

            idadeAnos1 = 14;         //EXEMPLO: DENTRO DO INTERVALO && SE FOSSE COLOCADO 12 POR EXEMPLO EM idadeAnos1 = 12;
                                     //A PROPOSTA PULARIA PARA "else", POIS: >=13 && <=17 NÃO CONTÉM O NUMERO 12.
                                     // ENTÃO SERIA MessageBox.Show("NICOLAS NÃO É ADOLESCENTE"); PARA SER VERDADEIRO SE ANALISA A SEGUINTE VERIFICAÇÃO:
                                     // 12 É MAIOR IGUAL A 13 = NÃO. E 12 É MENOR IGUAL A 17 = SIM. PORTANTO PARA A PROPOSTA SER VERDADEIRA EM "if", OS DOIS VALORES DEVERÃO
                                     // SER V && V (VERDADEIRO E VERDADEIRO). SENÃO A PROPOSTA PULA PARA "else" SENDO FALSO UM DOS VALORES.

            if (idadeAnos1 >= 13 && idadeAnos1 <= 17)
                MessageBox.Show("NICOLAS É ADOLESCENTE E TEM 14 ANOS");

            else

                MessageBox.Show("NICOLAS NÃO É ADOLESCENTE");

//          OU ||: OU UM OU OUTRO SE VERDADEIROS, A EXPRESSÃO SERÁ VERDADEIRA.

            int idadeAnos2;
            idadeAnos2 = 33; //MÁRIO
            string Nome = "Mário Torres";
            if (idadeAnos2 >= 18 && idadeAnos2 <= 59 || Nome == "Mário Torres")       //USO DA VARIÁVEL "int" + VARIÁVEL "string" DENTRO DA EXPRESSÃO || "ou".
            {
                MessageBox.Show("MÁRIO TORRES É ADULTO");
                MessageBox.Show("O NOME MÁRIO TORRES CORRESPONDE A LISTA");
            }

            else

                MessageBox.Show("A IDADE E O NOME NÃO CONSTAM");

//          ELSE IF

            int idadeAnos3;
            idadeAnos3 = 68; // ALICE



            if (idadeAnos3 <= 2)
                MessageBox.Show("BEBÊ");
            else if (idadeAnos3 >= 3 && idadeAnos3 <= 12 )
                MessageBox.Show("CRIANÇA");
            else if (idadeAnos3 >= 13 && idadeAnos3 <= 17)
                MessageBox.Show("ADOLESCENTE");
            else if (idadeAnos3 >= 18 && idadeAnos3 <= 59)
                MessageBox.Show("ADULTO");
            else
                MessageBox.Show(" ALICE É IDOSA E TEM 68 ANOS");

            
            
            // VERIFICAÇÃO BOLEANA COM DOIS PARENTESES "(())". SIM E NÃO "&&" - SIM OU NÃO "||".
            // SE É CRIANÇA OU E, MASCULINO OU FEMININO.


            int idadeAnos4;
            idadeAnos4 = 3; // CRIANÇA DE 3 A 12 ANOS.
            string sexo = "M";



            if ((idadeAnos4 >= 3 && idadeAnos4 <= 12) || sexo == "M")  // É CRIANÇA. TEM ENTRE 3 "&&" 12 ANOS. OU "||" É DO SEXO MASCULINO. AMBAS SÃO VERDADDEIRAS,
                MessageBox.Show(" CRIANÇA DO SEXO MASCULINO");         // CONTINUARIA SENDO VERDADEIRO, SE UMA DELAS FOSSE (V) OU (F) VERDAEIRO 0U FALSO
                                                                       //SÓ SERIA FALSO "else" SE AS DUAS EXPRESSÕES FOSSEM FALSAS.
                    // EX:((idadeAnos4 >= 3 && idadeAnos4 <= 12) && sexo == "F") FALSO POR CAUSA DA EXPRESSÃO && CORRESPONDENTE A sexo == "F"); IDADE "E" SEXO TEM QUE SER (V).
                    // EX:((idadeAnos4 >= 3 && idadeAnos4 <= 12) || sexo == "F") VERDADEIRO POR CAUSA DA EXPRESSÃO || CORRESPONDENTE A sexo == "F"); "OU" IDADE DE 3 A 9 ANOS.
            else
                
                MessageBox.Show("NÃO É CRIANÇA E NÃO É DO SEXO MASCULINO");




            Close();

        }
    }
}   

        
                 

       
        
            

        

       
        

        
    


