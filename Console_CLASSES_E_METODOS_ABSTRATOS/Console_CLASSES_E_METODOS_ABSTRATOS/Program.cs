using System;

namespace Console_CLASSES_E_METODOS_ABSTRATOS

//UMA CLASSE ABSTRATA, BASICAMENTE É COMO UMA CLASSE DE REFERENCIA. QUANDO DECLARAMOS UMA CLASSE COMO ABSTRATA, ELA SERVIRÁ DE (BASE) DE
//REFERENCIA PARA OUTRAS CLASSES QUE IRÃO HERDAR DA CLASSE ABSTRATA.

//EM METODOS ABSTRATOS, NÃO SERÁ IMPLEMENTADO O COMPORTAMENTO DO METODO, SÓ É CRIADO O PROTÓTIPO QUE SERVIRÁ DE REFERENCIA PARA AS CLASSES QUE 
//ESTÃO HERDANDO DA CLASSE ABSTRATA. LEMBRANDO QUE NUMA CLASSE ABSTRATA CONTERÃO METODOS ABSTRATOS E NÃO ABSTRATOS, OS METODOS NÃO ABSTRATOS 
//CONTERÃO IMPLENTAÇÃO NORMAL. E, AS CLASSES DERIVADAS QUE HERDAM DAS CLASSES ABSTRATAS, DEVEM IMPLEMENTAR TODOS OS METODOS ABSTRATOS E PROPRIEDADES.
//*OBS: PORÉM NÃO SE PODE ISNTANCIAR OBJETOS DE UMA CLASSE ABSTRATA. COMO JÁ DITO, ESSES OBJETOS SÓ PODEM SER HERDADOS.
{

    abstract class Veiculo //CLASSE BASE ABSTRATA
    {
        protected int velMaxima;
        protected int velAtual;
        protected bool ligado;

        public Veiculo() //CONSTRUTOR QUE INICIALIZA AS PROPRIEDADES DA CLASSE "Veiculo". COMO ELE NÃO É ABSTRATO, SEU CONTEUDO PRECISA SER IMPLEMENTADO.
        {
            ligado = false;
            velAtual = 0;
        }

        public void setLigado(bool ligado) //METODO CRIADO PARA LIGAR O VEICULO. COMO ESTE METODO TAMBÉM NÃO É ABSTRATO, É OBRIGATÓRIO IMPLEMENTAR SUA
                                           //FUNCIONALIDADE.
        {
            this.ligado = ligado;
        }

        public int getVelAtual() //METODO CRIADO PARA OBTER O RETORNO DA VELOCIDADE ATUAL DO VEICULO.
                                  
        {
            return velAtual;
        }

        abstract public void aceleracao(int mult); //METODO ABSTRACT CRIADO E SEM IMPLEMENTAÇÃO.

    }   
        class Carro:Veiculo
        {
             public Carro()
            {
                velMaxima=120;
            }
        override public void aceleracao(int mult) //METODO "aceleracao" SOBRESCRITO "override" CRIADO E IMPLEMENTADO O MULTIPLICADOR DE ACELERAÇÃO.
        {
            velAtual += 10 * mult;
        }
    }
    
    class Program
    
    {
        static void Main()
        {
            Carro carro1 = new Carro();

            //QUANTAS VEZES FOR CHAMADA A ACELERAÇÃO DO CARRO1, ESTA SERÁ MULTIPLICADA E IMPRESSA.
            carro1.aceleracao(1);  
            carro1.aceleracao(2);
            carro1.aceleracao(4);
            carro1.aceleracao(6);

            //DESACELERANDO:
            carro1.aceleracao(-6);
            carro1.aceleracao(-4);
            carro1.aceleracao(-2);
            carro1.aceleracao(-1);

            //ACELERANDO NOVAMENTE
            carro1.aceleracao(1);

            Console.WriteLine(carro1.getVelAtual());
        }
    }
}
