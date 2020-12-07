using System;

namespace Console_MEMBROS_PROTECTED

    //A DIFERENÇA DO PRIVATE PARA O PROTECTED É QUE, O PRIVATE RESTRINGE O ACESSO AO MEMBRO SOMENTE A CLASSE. SÓ É POSSÍVEL ACESSAR O MEMBRO COM METODOS DA PRÓPRIA
    //CLASSE, A CLASSE BASE. UMA CLASSE DERIVADA DE VEICULO, NÃO TERÁ ACESSO AOS MEMBROS "private" DA CLASSE BASE "Veiculo". OS MEMBROS "private" SÓ PODERÃO SER 
    //ACESSADOS ATRAVÉS DE METODOS "public". O "protected" PERMITE O ACESSO AOS MEMBROS PELAS CLASSES DERIVADAS, TANTO DA CLASSE BASE, QUANTO DE SUAS CLASSES DERIVADAS.
    //MAS, SOMENTE PELAS CLASSES. SE TENTARMOS ACESSAR O MEMBRO "protected" FORA DA CLASSE, PELO OBJETO, NÃO TEREMOS ACESSO.

{
    class Veiculo //NOVA CLASSE BASE CRIADA
    {
        public int VelociadeAtual;      //PROPRIEDADE(MEMBRO) DE NIVEL DE SEGURANÇA "public" DO TIPO "int" CRIADA PARA GUARDAR A VELOCIDADE ATUAL DO "Veiculo"
        private int VelocidadeMaxima;    //PROPRIEDADE(MEMBRO) DE NIVEL DE SEGURANÇA "private" DO TIPO "int" CRIADA PARA GUARDAR A VELOCIDADE MAXIMA DO "Veiculo"
        protected bool ligado;          //PROPRIEDADE(MEMBRO) DE NIVEL DE SEGURANÇA "protected" DO TIPO "bool" CRIADA PARA DETERMINAR SE "Veiculo" ESTÁ LIGADO  

        public Veiculo(int VelocidadeMaxima)//METODO CONSTRUTOR "Veiculo" CRIADO DENTRO DA CLASSE BASE "Veiculo" PARA INICIAR A PROPRIEDADE "VelocidadeMaxima" 
                                            //QUE ENTRA COMO PARÂMETRO DENTRO DO CONSTRUTOR "Veiculo".
        {
            VelociadeAtual = 0;
            this.VelocidadeMaxima = VelocidadeMaxima; //OPERADOR "this" USADO PARA CHAMAR A PROPRIEDADE "VelocidadeMaxima" DA CLASSE "Veiculo" QUE É "private" INICIADO
            ligado = false;                           //COMO PARAMETRO DENTRO DO CONSTRUTOR "Veiculo".
        }

        public bool getLigado() //METODO CRIADO PARA OBTER O "ligado" QUE É "protected".
        {
            return ligado;
        }
        public int getVelocidadeMaxima() //METODO CRIADO PARA OBTER A "Velocidade Maxima" QUE É "private".
        {
            return VelocidadeMaxima;
        }

        class Carro:Veiculo //CLASSE DERIVADA "Carro" QUE HERDARÁ MEMBROS DA CLASSE BASE "Veiculo".
        {
            public string nome; //PROPRIEDADE(MEMBRO) DE NIVEL DE SEGURANÇA "public" DO TIPO "string" DE NOME "nome" CRIADA PARA HERDAR MEMBROS DA CLASSE "Veiculo"
            public Carro(string nome, int VelMax):base(VelMax) //METODO CONTRUTOR "Carro" DA CLASSE DERIVADA "carro".
               
            {
                this.nome = nome;
                ligado = true;
            }
        }
        class Program //CLASSE PADRÃO JÁ EXISTENTE
        {
            static void Main()  //METODO PADRÃO JÁ EXISTENTE
            {
                Carro carro = new Carro("Omega", 120); //ISTANCIAÇÃO DE "Carro" COM PARAMETROS RELACIONADOS AO CONTRUTOR "public Carro(string nome, int VelMax)
                                                       //:base(VelMax)" DA CLASSE DERIVADA "Carro" QUE HERDA AS PROPRIEDADE DE "Veiculo".
                Console.WriteLine("Nome.............:{0}", carro.nome);
                Console.WriteLine("Velocidade Maxima:{0}", carro.getVelocidadeMaxima());
                Console.WriteLine("Ligado...........:{0}", carro.getLigado()); //LEMBRANDO QUE "ligado" QUE É "protected" SÓ PODE SER ACESSADO DENTRO DA CLASSE DERIVADA OU, 
                                                                               //DENTRO DA PRÓPRIA CLASSE. POR ISSO UTILIZAMOOS O METODO "get" PARA OBTER ESTA PROPRIEDADE.
            }
        }
    }
    
}
