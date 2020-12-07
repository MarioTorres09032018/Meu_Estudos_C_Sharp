using System;

namespace Console_CLASSES_SEALED

//UM CONCEITO SIMPLES É QUE UMA CLASSE "Sealed" NÃO PODE SER HERDADA.

{
    sealed class veiculo 
    {

    }

    class Carro:veiculo  //A MENSAGEM DE ERRO JÁ INFORMA QUE A CLASSE "sealed class veiculo" NÃO PODE SER HERDADA. 
    {

    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
