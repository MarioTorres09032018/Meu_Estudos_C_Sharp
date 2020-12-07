using System;

//SÃO PROPRIEDADES ESPECIAIS PRIVADAS FLEXÍVEIS. ONDE CONSEGUIMOS LER, ATRIBUIR OU CALCULAR UM VALOR PELAS PROPRIEDADES 
//ACESSORS. É UMA PROPRIEDADE QUE SE EQUIPARA A UM METODO E, OS CONCEITOS SE MISTURAM ENTRE METODOS E ESSAS PROPRIEDADES
//ACESSORS. PODEMOS OBTER E ALTERAR DADOS DE UMA PROPRIEDADE PRIVADA.

namespace Console_ACESSORS_GET_SET
{
    class Carro //CLASSE CRIADA "carro"
    {
        private int velMax; //PROPRIEDADE PRIVADA

        public Carro() //CONSTRUTOR "Carro"
        {
            this.velMax = 120; //PROPRIEDADE "velMax" DA CLASSE "Carro" INICIALIZADA UTILIZANDO O OPERADOR "this" E ATRIBUIDO
                               //O VALOR "120". ESSA INICIALIZAÇÃO DEFINE QUE QUALQUER INSTANCIAÇÃO DA VELOCIDADE MAXIMA DE 
                               //QUALQUER CARRO SERÁ DE VALOR "120".

             Vm = 120; //UTILIZANDO DE FORMA DIRETA O "get/set" DE "velMax" DENTRO DO CONSTRUTOR "Carro()".
        }
        //--------------------------------------------------------------------------------------------------------------------
        //UTILIZANDO ESTA CHAMADA DA PROPRIEDADE "velMax" ATRAVÉS DE METODO:

        public void VM(int velMax) //APÓS INICIALIZAR "velMax", CRIAMOS UM METODO QUE PERMITIRÁ A ATRIBUIÇÃO DE UM VALOR A 
                                   //"velMax". E SE QUISERMOS ATRIBUIR TERÁ QUE TER RETORNO "void", E SERÁ DADO UM NOME, NO 
                                   //CASO DESTE METODO, "VM", E O VALOR DE "int velMax" É PASSADO COMO ARGUMENTO DE ENTRADA
                                   //NO METODO "VM".
        {
            this.velMax = velMax; //DAÍ, USAMOS O OPERADOR "this" NOVAMENTE PARA DIZER QUE "velMax" QUE É PRIVADO DA CLASSE
                                  //"Carro" RECEBE "int velMax" QUE FOI USADO NO ARGUMENTO DE ENTRADA DE "VM".
        }

        //--------------------------------------------------------------------------------------------------------------------
        //UTILIZANDO ESTA CHAMADA PELA PROPRIEDADE "velMax" ATRAVÉS DOS ACESSORS "get And set":

        public int Vm //CHAMAMOS UMA PROPRIEDADE COM  NOME "Vm", LEMBRANDO QUE COM PARENTESES() SE TORNARIA UM METODO, SEM OS
                      //PARENTESES() SE TORNA UMA PROPRIEDADE, QUE RECEBERÁ UM ACESSADOR "get And set".
                      
        {
            get //SE UTILIZARMOS SOMENTE O "get" SERÁ UMA PROPRIEDADE SOMENTE "LEITURA" (OBTENDO O VALOR DA PROPRIEDADE).
                //(READY ONLY)
            {
                return velMax; //UTILIZAMOS O "return" PARA DIZER QUE A PROPRIEDADE "Vm" RECEBE O VALOR DE "velMax".
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
                    velMax = 0;//PASSA-SE UM VALOR MÍNIMO ACEITÁVEL.
                }
                else if(value >300) //LIMITAMOS TAMBÉM A VELOCIDADE MÁXIMA QUE O CARRO PODE TER.
                {
                    velMax = 300;
                }else
                {
                    velMax = value; //ESTA CONCLUSÃO É SE O VALOR ESTÁ NA FAIXA DE VELOCIDADE ENTRE "0 E 300"."velMax" RECEBE
                                    //"value".
                }
            }
        }

        //FEITO O PROCESSO "get/set" AGORA PODEMOS USAR A PROPRIEDADE PRIVADA "int velMax" INCLUSIVE DENTRO DA PRÓPRIA CLASSE
        //"Carro" BASTA CHAMAR O VALOR OBTIDO EM "get/set" DA PROPRIEDADE "Vm".

        
    }
    class Program //CLASSE PADRÃO JÁ EXISTENTE "Program".
    {
        static void Main()//METODO PADRÃO JÁ EXISTENTE.
        {
            Carro c1 = new Carro(); //INSTANCIANDO UM NOVO CARRO

            c1.Vm = 200; //ATRIBUINDO UM NOVO VALOR DE VELOCIDADE A PROPRIEDADE "Vm" (ATRAVÉS DO ACESSOR "set").

            Console.WriteLine("velocidade {0}",c1.Vm);//OBTIDO O VALOR DA VELOCIDADE PARA "c1", DA PROPRIEDADE "Vm"
                                                      //(UTILIZANDO O ACESSOR "get").
        }
    }
}
