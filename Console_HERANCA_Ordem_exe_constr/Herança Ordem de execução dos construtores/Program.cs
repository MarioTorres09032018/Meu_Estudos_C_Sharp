using System;

namespace Herança_Ordem_de_execução_dos_construtores
{

    //A ORDEM DE EXECUÇÃO DOS CONSTRUTORES DAS CLASSES CRIADAS, QUANDO SE TEM UM SET DE DERIVADAS, SERÁ SEMPRE DA CLASSE BASE PARA AS 
    //CLASSES DERIVADA1 E DEPOIS, DERIVADA2.

    class Base //NOVA CLASSE "Base" CRIADA.
    {
        public Base() //CONSTRUTOR
        {
            Console.WriteLine("Construtor da classe Base");
        }
    }
    class Derivada1 : Base //NOVA CLASSE "Derivada1" CRIADA QUE HERDA AS PROPRIEDADES DA CLASSE "Base".
    {
        public Derivada1() //CONSTRUTOR
        {
            Console.WriteLine("Construtor da classe Derivada1");
        }
    }
    class Derivada2 : Derivada1 //NOVA CLASSE "Derivada2" CRIADA QUE HERDA AS PROPRIEDADES DA CLASSE "Derivada1".
    {
        public Derivada2() //CONSTRUTOR
        {
            Console.WriteLine("Construtor da classe Derivada2");
        }
        class Program//CLASSE PADRÃO JÁ EXISTENTE.
        {
            static void Main()//METODO PADRÃO JÁ EXISTENTE. 
            {
                Derivada2 Derivada2 = new Derivada2();//ISTANCIAÇÃO
            }
        }
    }
}
