using System;

namespace Console_METODOS_VIRTUAIS
{
    //METODOS VIRTUAIS SÃO METODOS QUE TEM O MESMO NOME, EM CLASSES DIFERENTES. UMA CLASSE QUE HERDA DA OUTRA E QUE TEM UM METODO QUE TEM EXATAMENTE O MESMO NOME DA SUA
    //CLASSE BASE. PORÉM ESTE METODO IRÁ EXECUTAR UMA AÇÃO DIFERENTE. E DEVEMOS DEFINIR NA CLASSE BASE QUE ESTE METODO VAI SER VIRTUAL E, QUE PODERÁ SER SOBRESCRITO EM
    //UMA CLASSE DERIVADA.
    class Base //NOVA CLASSE "Base" CRIADA.
    {
        public Base() //CONSTRUTOR
        {
            Console.WriteLine("Construtor da classe Base");
        }
        virtual public void info() //METODO "virtual" DA CLASSE "Base".
        {
            //NÃO FAZ SENTIDO UMA IMPLEMENTAÇÃO NO BLOCO DE "Base" QUE É "virtual" POIS, ELE SERÁ SOBREESCRITO.
        }
    }
    class Derivada1 : Base //NOVA CLASSE "Derivada1" CRIADA QUE HERDA AS PROPRIEDADES DA CLASSE "Base".
    {
        public Derivada1() //CONSTRUTOR
        {
            Console.WriteLine("Construtor da classe Derivada1");
        }

        override public void info() //METODO "override" DA CLASSE "Derivada 1" QUE UTILIZA-SE DO MESMO METODO "info()" PRESENTE NA CLASSE "Base" 
                                    //SOBRESCREVENDO O "info()" DA CLASSE BASE. QUANDO O METODO "info()" FOR CHAMADO NOVAMENTE, ELE IRÁ IMPRIMIR ESTE
                                    //PRINT ("Derivada1") E NÃO MAIS O "info()" DA CLASSE "Base".
        {
            Console.WriteLine("Derivada1");
        }
    }
    class Derivada2 : Derivada1 //NOVA CLASSE "Derivada2" CRIADA QUE HERDA AS PROPRIEDADES DA CLASSE "Derivada1".
    {
        public Derivada2() //CONSTRUTOR
        {
            Console.WriteLine("Construtor da classe Derivada2");
        }

        override public void info() //METODO "override" DA CLASSE "Derivada 2" QUE UTILIZA-SE DO MESMO METODO "info()" PRESENTE NA CLASSE "Derivada1" 
                                    //SOBRESCREVENDO O "info()" DESTA CLASSE. QUANDO O METODO "info()" FOR CHAMADO NOVAMENTE, ELE IRÁ IMPRIMIR ESTE
                                    //PRINT ("Derivada2") E NÃO MAIS O "info()" DA CLASSE "Derivada1".
        {
            Console.WriteLine("Derivada2");
        }

    class Program//CLASSE PADRÃO JÁ EXISTENTE.
        {
            static void Main()//METODO PADRÃO JÁ EXISTENTE. 
            {
                //POR ISTANCIAÇÃO 
                Derivada1 derivada1 = new Derivada1();//ISTANCIAÇÃO FEITA PARA QUE SE PODESSE CHAMAR AMBAS AS "Derivadas" "override"
                Derivada2 derivada2 = new Derivada2();//ISTANCIAÇÃO FEITA PARA QUE SE PODESSE CHAMAR AMBAS AS "Derivadas" "override"

                derivada1.info(); //"info()" QUE IMPRIME A "derivada1" 
                derivada2.info(); //"info()" QUE IMPRIME A "derivada2"


                //POR REFERENCIA:

                Base Ref; //REFERENCIA FEITA PARA QUE SE POSSA CHAMAR OS "info()" APONTADOS NA "Ref".

                Ref = derivada1; //"Ref" QUE FAZ A REFERENCIA A "derivada1"

                Ref.info(); //"info()" QUE IMPRIME A REFERENCIA A "derivada1"

                //LEMBRANDO QUE, A REFERENCIA QUE FOR CHAMADA EM "Ref" (derivada1, derivada2), SERÁ IMPRESSA EM "Ref.info()".
            }
        }
    }
}
