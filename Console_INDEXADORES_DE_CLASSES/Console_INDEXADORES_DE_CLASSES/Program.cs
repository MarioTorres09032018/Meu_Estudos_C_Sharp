using System;

namespace Console_INDEXADORES_DE_CLASSES
    //INDEXADOR É UM MEMBRO DE UMA CLASSE QUE PERMITE AOS OBJETOS DA CLASSE SEREM INDEXADOS COMO SE FOSSEM ARRAYS. 
{
    class Carro //CLASSE CRIADA "carro"
    {
        private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };//PROPRIEDADE PRIVADA ARRAY CRIADA COM 5 POSIÇÕES.

        //UTILIZANDO ESTA CHAMADA PELA PROPRIEDADE "velMax" ATRAVÉS DOS ACESSORS "get And set" COM INDEXADOR:

        public int this [int i] //CHAMAMOS UMA PROPRIEDADE COM  NOME "Vm", LEMBRANDO QUE COM PARENTESES() SE TORNARIA UM METODO, SEM OS
                      //PARENTESES() SE TORNA UMA PROPRIEDADE, QUE RECEBERÁ UM ACESSADOR "get And set".

        {
            get //SE UTILIZARMOS SOMENTE O "get" SERÁ UMA PROPRIEDADE SOMENTE "LEITURA" (OBTENDO O VALOR DA PROPRIEDADE).
                //(READY ONLY)
            {
                return velMax[i]; //UTILIZAMOS O "return" PARA DIZER QUE A PROPRIEDADE "Vm" RECEBE O VALOR DE "velMax".
            }
            set //SE UTILIZARMOS SOMENTE O "set" SERÁ UMA PROPRIEDADE DE "ESCRITA"(ALTERANDO O VALOR DA PROPRIEDADE).
                //(WRITE ONLY)

            //"get And set" SERÁ DE LEITURA E ESCRITA (READY AND WRITE).
            {
                if (value < 0)//O VALOR ATRIBUIDO DA PROPRIEDADE "velMax" EM "set" FICA ARMAZENADO DENTRO DE "value", QUE
                              //PODE SER UTILIZADO A QUALQUER MOMENTO. PORTANTO AQUI REALIZAMOS UM TESTE PARA PERGUNTAR SE O
                              //VALOR PASSADO "value" FOR MENOR (<) DO QUE ZERO "0".(VELOCIDADE NÃO EXISTE VALOR MENOR QUE 0)
                              //ENTÃO:
                {
                    velMax[i] = 0;//PASSA-SE UM VALOR MÍNIMO ACEITÁVEL DO ARRAY NA POSIÇÃO[i] QUE É "0".
                }
                else if (value > 300) //LIMITAMOS TAMBÉM A VELOCIDADE MÁXIMA QUE O CARRO PODE TER QUE É "300".
                {
                    velMax[i] = 300;
                }
                else
                {
                    velMax[i] = value; //ESTA CONCLUSÃO É SE O VALOR ESTÁ NA FAIXA DE VELOCIDADE ENTRE "0 E 300"."velMax" RECEBE
                                       //"value".
                }
            }
        }

        //FEITO O PROCESSO "get/set" AGORA PODEMOS USAR A PROPRIEDADE PRIVADA "int[] velMax" INCLUSIVE DENTRO DA PRÓPRIA CLASSE
        //"Carro" BASTA CHAMAR O VALOR OBTIDO EM "get/set" DO ARRAY DE 5 POSIÇÕES.

    }
    class Program //CLASSE PADRÃO JÁ EXISTENTE "Program".
    {
        static void Main()//METODO PADRÃO JÁ EXISTENTE.
        {
            Carro c1 = new Carro(); //INSTANCIANDO UM NOVO CARRO

            c1[4] = 299; //ATRIBUINDO UM NOVO VALOR DE VELOCIDADE AO VETOR "C1" NA POSIÇÃO[4] (ATRAVÉS DO ACESSOR "set").
                         //LEMBRANDO QUE O VALOR MINIMO É "0" E MAXIMO É 300. SE EU DER UM "SET" DE 301 POR EXEMPLO NÃO SETARÁ O NOVO VALOR. 

            Console.WriteLine("velocidade {0}", c1[4]);//OBTIDO O VALOR DA VELOCIDADE PARA "c1", DO ARRAY NA POSIÇÃO[4]X
                                                       //(UTILIZANDO O ACESSOR "get").
        }
    }
}
