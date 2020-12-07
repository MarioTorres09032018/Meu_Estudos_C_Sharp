using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // while = Enquanto. 
            // EX: Enquanto um número for menor que 10, ficar repetindo. Por exemplo.


            int numero = 1;
            while (numero <= 5)                           //ou seja: Enquanto os numeros forem menores e igual a cinco (1,2,3,4,5); 
            {
                MessageBox.Show(numero.ToString());      // Pega a sequência de execução de "numero" 1,2,3,4,5 converte para Texto "ToString" e exibe na caixa de mensagem.
                numero = numero + 1;                     // pode ser escrito também : "numero++;" (É a forma abreviada da mesma coisa).  
            }



            // EXEMPLO SE FOSSE EM ORDEM DECRESCENTE:

            int numero2 = 5;
            while (numero2 >= 1)                             //ou seja: Enquanto os numeros forem maiores e igual a um (5,4,3,2,1); 
            {
                MessageBox.Show(numero2.ToString());         // Pega a sequência de execução de "numero2" 5,4,3,2,1 converte para Texto "ToString" e exibe na caixa de mensagem.
                numero2 = numero2 - 1;  //numero2--;         // pode ser escrito também : "numero2--;" (É a forma abreviada da mesma coisa). 


            }
            //*OBS: "numero = numero + 1;" (SIGNIFICA QUE "numero" FARÁ REFERÊNCIA A ELE MESMO "= numero" E ADICIONARÁ "+ 1".
            // ESSE PROCESSO EVITA QUE O PROGRAMA TRAVE OU ENTRE EM LOOPING INFINITO AO EXECUTAR QUANDO SE UTILIZA A VARIÁVEL "While" (ENQUANTO).
            // 



            // BREAK

            int numero3 = 1;
            while (numero3 <= 5)
            {
                MessageBox.Show(numero3.ToString());             //AO CHEGAR NO "numero3" PARA! IRÁ PARA A PRÓXIMA INSTRUÇAO. IRÁ CONTAR: 1,2, COMO O NUMERO 2 IRÁ RECEBER 
                numero3 = numero3 + 1;  //numero3++;             //INCREMENTO "++" NA LINHA DE BAIXO, PASSARÁ A SER 3, FINALIZANDO ESTE WHILE E IRÁ IMPRIMIR PRÓXIMA 
                if (numero3 == 3)                                // INSTRUÇÃO SE HOUVER.

                break;                          // COM BASE NA MESMA FORMULA INICIAL, SÓ MUDANDO O NOME DA VARIÁVEL "numero", TEMOS AGORA O "break".
            }                                   // QUE INDICA QUE ENQUANTO "While" ESTIVER RODANDO E "numero3 = numero3 + 1" ESTIVER ADICIONANDO MAIS UM,
            // AO CHEGAR NA CONTAGEM CRESCENTE DE 1,2,3 QUE SÃO MENORES E IGUAL A 5. CHEGANDO NO NUMERO "3"
            // INDICADO "if (numero3 == 3)" O CODIGO IRÁ PARAR DE RODAR O "while" POR CONTA DA INSTRUÇÃO "break".
            // E IRÁ PULAR PARA A PRÓXIMA LINHA DANDO CONTINUIDADE NO "While", SE HOUVER. SENÃO O PROGRAMA
            // SIMPLESMENTE FECHA.


            //*OBS: ISSO PODE SER MELHOR VERIFICADO ADICIONANDO UM BREAK POINT NA BARRA LATERAL À ESQUERDA DO CODIGO. E INICIANDO
            // O MODO "DEBUG" DANDO START NO CODIGO. AO CHEGAR NO PONTO DE VERIFICAÇÃO TECLANDO (F10) "STEP OVER", ANALIZÁ-SE OS VALORES E VÊ-SE
            // A INSTRUÇÃO DO CÓDIGO ESTÁ RETORNANDO OS VALORES ESPERADOS. NO CASO, "While" CONTINUA RODANDO O CODIGO, "numero++;" CONTINUA ADICIONANDO
            // MAIS UM, ATÉ QUE A COMPARAÇÃO "if" INDIQUE QUE QUANDO AS ADIÇÕES CHEGAREM AO NUMERO "3" É PARA DAR "break" NO CODIGO, PULANDO 
            // PARA A PROXIMA LINHA.



            //CONTINUE

            int numero4 = 1;                         //FAZ-SE A VERIFICAÇÁO: INTEIROS COMEÇANDO PELO 1, MENORES E IGUAL A 5. QUANDO CHEGAR NO NUMERO 2, QUE É A VERIFICAÇÃO
            while (numero4 <= 5)                     //"IF", ESTE RECEBERÁ INCREMENTO "++". PORTANTO, O NUMERO 2 NÃO SERÁ IMPRIMIDO NA MESSAGEBOX, EXIBINDO O NUMERO 3, 
            {                                        //DEPOIS 4, E DEPOIS 5. FICANDO ASSIM: 1, 3(2+1 continue), 4, 5. APÓS FINALIZAR O APP FECHA. 
                if (numero4 == 2)                    //*OBS: LEMBRANDO QUE O CONTINUE EXECUTARÁ ENQUANTO OS RESULTADOS DA SENTENÇA FOREM <= A 5. DEPOIS IRÁ PARA PROXIMA LINHA.
                {
            numero4 = numero4 + 1;  //numero++;      //SEMPRE QUE USAR "CONTINUE", DEVERÁ SER INCREMENTADO VALOR++ OU --. SE NÃO USAR ANTES DO CONTINUE GERARÁ LOOPING INFINITO.
            continue;                                //AO CONTRÁRIO DO "break" QUANDO OS ACRESCIMOS CHEGAREM ATÉ O NUMERO INDICADO NO CASO EM: "if (numero4 == 2)".
                                                     //A INSTRUÇÃO IRÁ SER "CONTINUAR" ATÉ OS MENORES IGUAL A CINCO. (1,3++,4,5). 
                                                     //IMPRIME-SE EM MESSAGEBOX OS VALORES E PULA PARA PROXIMA INSTRUÇÃO SE HOUVER. COMO NÃO HÁ NESTE CASO,
                                                     //A ÚLTIMA INSTRUÇÃO RESTANTE É "Close();" FECHAR O PROGRAMA.
                }
                        
            MessageBox.Show(numero4.ToString());
            numero4 = numero4 + 1;

                    }

                    {

                    }





            Close();
                }


            }


        }

    



        

