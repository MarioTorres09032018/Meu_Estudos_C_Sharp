using System;

namespace Console_STRUCT

    //STRUCT (ESTRUTURA) É UM TIPO. QUANDO DEFINIMOS UMA ESTRUTURA, FALAMOS QUE UM TIPO VAI PERMITIR O ARMAZENAMENTO DE DIFERENTES TIPOS DE DADOS. A STRUCT
    //É SEMELHANTE A CLASSE MAS COM UMA DIFERENÇA IMPORTANTE. "STRUCT" É TRATADA COMO TIPO "VALUE", A "CLASSE" COMO REFERENCIA. ISSO SIGNIFICA QUE OS MEMBROS
    //DA "STRUCT" SÃO ACESSADOS DIRETAMENTE E NÃO POR REFERENCIA. SÓ QUE, COMO A "STRUCT" NÃO É CLASSE, NÃO É POSSÍVEL HERDAR DE UMA CLASSE E NEM COMO BASE
    //DE RERANÇA PARA UMA CLASSE. MAS, PODE-E USAR CONSTRUTORES QUE PODERÁ SER CHAMADO USANDO OPERADOR "NEW" PARA INSTANCIAR UM OBJETO DESDE QUE ESTE SEJA
    //DO TIPO "STRUCT".


{
    struct Carro    //ESTRUTURA "STRUCT" CRIADA. (*OBS: LEMBRANDO QUE "STRUCT" NÃO É "CLASSE". NÃO TEMOS TODAS AS FORMAS DE TRABALHO ORIENTADO A OBJETOS
                    //COMO TEMOS EM UMA "CLASSE", É UM RECURSO MAIS LIMITADO DENTRO DAS LINGUAGENS. A VANTAGEM É DE ÀS VEZES NÃO PRECISARMOS IMPLEMENTAR
                    //UMA "CLASSE" PARA UTILIZAR UM OBJETO, O "STRUCT" RESOLVE QUANDO SE TRATA DE ALGO MAIS SIMPLES).

    {   
        public string marca; //PROPRIEDADES DE "struct Carro" CRAIDAS
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor) //CONSTRUTOR CRIADO E ATRIBUIDO ARGUMENTOS STRING CRIADOS ACIMA.
        {
            this.marca = marca;//OPERADOR "this" PARA INICIALIZAR OS OBJETOS CRIADOS NA "struct Carro" REFERINDO-OS AOS ARGUMENTOS DO CONSTRUTOR "Carro".
            this.modelo = modelo;
            this.cor = cor;
        }

        public void info() //METODO "info()" QUE RETORNA AS INFORMAÇÕES DAS PROPRIEDADES(OBJETOS) UTILIZANDO O OPERADOR "this".
        {
           Console.WriteLine("marca.:{0}", this.marca);
           Console.WriteLine("modelo:{0}", this.modelo);
           Console.WriteLine("cor...:{0}", this.cor);
        }
    }
    

    class Program //CLASSE PADRÃO JÁ EXISTENTE.
    {
        static void Main() //METODO PADRÃO JÁ EXISTENTE.
        {
            Carro c1; //"struct Carro" SENDO UTILIZADA COM O NOME DE "c1".

            c1.marca = "Nissan"; //ATRIBUINDO VALORES ÀS REFERENCIAS.
            c1.modelo = "March";
            c1.cor = "Preto";

            Carro c2=new Carro("Chevrolet","Agile","Vinho"); //"struct Carro" SENDO UTILIZADO COM O NOME DE "c2" QUE É O NOVO OBJETO INSTANCIADO "new" 
                                                             //PARA CHAMAR O "CONSTRUTOR Carro".


            Console.WriteLine("A marca é {0}, o modelo é {1} e, a cor é {2}.", c1.marca, c1.modelo, c1.cor);//IMPRIMINDO UM TEXTO UTILIZANDO AS POSIÇÕES
                                                                                                            //INDEX{} DOS OBJETOS DE "struct".

            Console.WriteLine("A marca é {0}, o modelo é {1} e, a cor é {2}.", c2.marca, c2.modelo, c2.cor);//IMPRIMINDO UM TEXTO UTILIZANDO AS POSIÇÕES
                                                                                                            //INDEX{} DOS OBJETOS DE "struct".
            Console.WriteLine("");//APENAS PARA ESPAÇAR.
            c1.info(); //METODO INFO() SENDO CHAMADO A IMPRESSÃO DE C1 DENTRO DO METODO "Main".
            Console.WriteLine("");//APENAS PARA ESPAÇAR.
            c2.info(); //METODO INFO() SENDO CHAMADO A IMPRESSÃO DE C2 DENTRO DO METODO "Main".

        }
    }
}
