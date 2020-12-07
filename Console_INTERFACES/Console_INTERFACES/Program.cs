using System;

namespace Console_INTERFACES

//PARECIDO COM AS CLASSES ABSTRATAS, PORÉM AS INTERFACES SÓ IMPLEMENTAM METODOS, O PROTOTIPO DOS METODOS. TODA CLASSE QUE IMPLEMENTAR UMA INTERFACE,
//OBRIGATORIAMENTE DEVE IMPLEMENTAR SEUS METODOS. NÃO CONTÉM CAMPOS E, UMA CLASSE PODE HERDAR MAIS DE UMA INTERFACE. PODEMOS IMPLEMENTAR QUANTAS 
//INTERFACES FOREM NECESSÁRIAS PARA COMPOSIÇÃO DA MINHA CLASSE. AS DIFERENÇAS SÃO QUE 'INTERFACES' NÃO PODEM TER NEM 'CONSTRUTOR', NEM 'DESTRUTOR'.  
//NÃO PODEMOS DEFINIR METODOS 'OPERATOR', NÃO PODEMOS DEFINIR MEMBROS 'STATIC'.
{

    public interface Veiculo //INTERFACE VEICULO CRIADA
    {
        void ligar(); //AQUI IMPLEMENTAMOS O RETORNO "void" DO METODO E A ASSINATURA "ligar" DE PARAMETROS DE ENTRADA() VAZIO.  
        void desligar(); //AQUI IMPLEMENTAMOS O RETORNO "void" DO METODO E A ASSINATURA "desligar" DE PARAMETROS DE ENTRADA() VAZIO.
        void info(); //AQUI OBRIGAMOS E IMPLEMENTAMOS O RETORNO "void" DO METODO E A ASSINATURA "info" DE PARAMETROS DE ENTRADA() VAZIO.
    }

    public interface Combate //INTERFACE COMBATE CRIADA
    {
        void disparar(); //AQUI IMPLEMENTAMOS O RETORNO "void" DO METODO E A ASSINATURA "disparar" DE PARAMETROS DE ENTRADA() VAZIO.
    }

    class Carro:Veiculo,Combate //CLASSE "Carro" CRIADA COM IMPLEMENTAÇÃO DAS INTERFACES HERDADAS "Veiculo e Combate".
    {
        public bool ligado;

        private int municao;

        public Carro() //CONSTRUTOR
        {
            setMunicao (100);
        }

        public void setMunicao(int qtde)
        {
            this.municao = qtde;
        }
        public void ligar()
        {
            this.ligado = true;
        }
        public void desligar()
        {
            this.ligado = false;
        }
        public void disparar() 
        {

        }
        public void info()
        {
            //PROGRAMA NÃO FAZ NADA. APENAS PARA ENTENDIMENTO DO CONCEITO DE "INTERFACES"
        }
    }

    class Program //CLASSE PADRÃO JÁ EXISTENTE
    {
        static void Main() //METODO PADRÃO JÁ EXISTENTE
        {
            Carro c1 = new Carro();
        }
    }
}
