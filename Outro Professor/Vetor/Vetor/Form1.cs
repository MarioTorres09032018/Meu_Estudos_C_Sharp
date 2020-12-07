using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVetorInteiro_Click(object sender, EventArgs e)
        {
            /* 
             DECLARAR VETOR []
             A DIFERENÇA ENTRE UMA VARIAVEL NORMAL E UMA DO TIPO VETOR É A ADIÇÃO DO COLCHETES "[]".
             * __________________________________________________________________________________
             *ESBOÇO DE ENDEREÇOS "INDEX[]" E OBJETOS  A SEREM INSERIDOS NA VARIAVEL int[] vetor:|
             * [0] - 7                                                                           |
             * [1] - 3                                                                           |
             * [2] - 5                                                                           |
             * [3] - 1                                                                           |
             *                                                                                   |
             ____________________________________________________________________________________|*/

            // Ex:
            // int Nome;     (EXEMPLO DE DECLARAÇÃO COMUM DE VARIAVEL DO TIPO "int").
            // int [] vetor; (EXEMPLO DE DECLARAÇÃO DE VARIAVEL DO TIPO "int" COM VETOR).
            MessageBox.Show("VETOR UNIDIMENCIONAL DE NUMEROS INTEIROS");                  //MENSAGEM ILUSTRATIVA DE INICIO DE CODIGO

            int[] vetor;    //* NESTE PONTO É NECESSÁRIO EXECUTAR DEBUG (F10) PARA VERIFICAR AS ALTERAÇÕES NOS ELEMENTOS/OBJETOS. AO INSERIR BRAKE POINT NESTA LINHA E AO CLICAR 
            // "START" NO DEBUG A SETA AMARELA APARECE. SE PASSAR O MOUSE SOBRE "vetor" NA LINHA ACIMA EM: "int[] vetor;" APARECERÁ "vetor null" COM UM PINO DE FIXAÇÃO AO LADO.
            // APÓS FIXAR O PINO NA TELA, CONTINUAMOS O DEBUG E PERCEBE-SE QUE APARECERÁ UM "+" AO LADO. CLICA-SE NELE E MAIS 4 ELEMENTOS "vetor[0]|0" APARECERÁ.
            // PARA VISUALIZÁ-LOS MELHOR FIXA-SE COM O PINO OS 4 OBJETOS PARA QUE OS MESMOS FIQUEM NA TELA.
            vetor = new int[4];     // O "new" SIGNIFICA INSTANCIAR O VETOR (CRIAR UM "NOVO". NO CASO, UM NOVO "int"). CRIAR UMA COPIA IDÊNTICA. 
            // O NUMERO "4" SIGNIFICA A QUANTIDADE DE ELEMENTOS/OBJETOS QUE QUERO QUE TENHA DENTRO DO MEU ENDEREÇO "INDEX []". 
            // CONTINUA O DEBUG (F10) E OS NUMEROS PROPOSTOS IRÃO SENDO INSERIDOS UM A UM EM "vetor|{int[4]}",NOS PINOS FIXADOS NA TELA.


            // VETORES PREENCHIDOS

            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;

            /*-----------------OBSERVAÇÃO:---------------------------------------------------------------------------------------
             * AO DEBUGAR COM (F10) "STEP OVER", O DEBUG EXECUTARÁ A VERIFICAÇÃO APENAS NAS LINHAS APÓS O BRAKE POINT.
             * AO DEBUGAR COM (F11) "STEP INTO", O DEBUG VERIFICA AS LINHAS E TAMBÉM OS MÉTODOS ENCONTRADOS APÓS O BRAKE POINT.
             * COMO O EXEMPLO ACIMA NÃO ESTÁ DENTRO DE NUNHUM METODO, PODE-SE USAR (F10) "STEP OVER".
             -------------------------------------------------------------------------------------------------------------------*/
            // ACESSAR POSIÇÃO - "INDEX" / ÍNDICE.

            int valor = vetor[1];        // ACESSA O VALOR DO ENDEREÇO "index[]" DENTRO DA VARIAVEL "int VETOR". NO CASO DESTA LINHA, POSIÇÃO 1 QUE CONTÉM O OBJETO 3. 
            //______________________________________________________________________________________________________________________________________________________________________________________

            // SABER O TAMANHO DO VETOR

            int tamanho = vetor.Length;  // ESTA PROPRIEDADE DEVOLVE O TAMANHO QUE SE QUER SABER DO VETOR QUE NO CASO É O 4. A QUANTIDADE DE ENDEREÇOS ADICIONADOS.
            // PASSANDO O MOUSE SOBRE A PROPRIEDADE "Length" VÊ-SE O NUMERO 4 COM TAMANHO "0" POIS AINDA NÃO FOI PREENCHIDO.
            // QUANDO DEBUGAR (F10), O NUMERO 4 TAMBÉM APARECERÁ EM "tamanho", QUE É O QUE SE QUER SABER.
            //_______________________________________________________________________________________________________________________________________________________________________________________

            //ORDENAR VETOR  "Sort" (ORDENAR/ORGANIZAR)

            System.Array.Sort(vetor);    // QUANDO FIXAR OS PINOS DO VETOR NA TELA VÊ-SE QUE ATÉ ESTA LINHA OS NUMEROS ERAM [0]=7, [1]= 3, [2]=5, [3]=1.
            // QUANDO DEBUGAR NOVAMENTE OS NUMEROS IRÃO SE ORDENAR COMO PEDE A LINHA: " System.Array.Sort(vetor); 
            // FICANDO ASSIM: [0]=1, [1]= 3, [2]=5, [3]=7. (O "1" E O "7" TROCARAM DE LUGAR CRIANDO UMA ORDEM NUMERICA CRESCENTE 1,3,5,7).
            // ESTA LINHA TEM A FUNÇÃO DE ORDENAR OS VETORES. USANDO A CLASSE "System.Array" QUE CONTÉM O METODO "Sort"(Ordenar). ASSIM, PODE-SE ORGANIZAR OS ELEMENTOS 
            // DE UM VETOR, NESTE CASO EM ORDEM CRESCENTE.
            //______________________________________________________________________________________________________________________________________________________________________________________ 

            //ACHAR VALOR (INFORMAÇÃO)  DENTRO DO VETOR

            int index1 = System.Array.IndexOf(vetor, 5); // NESTE METODO, O RETORNO APENAS INDICARÁ EM QUAL ENDEREÇO "index[]" SE ENCONTRA O VALOR 5. 
            // QUE NO CASO É NO ENDEREÇO NUMERO 2. AO DEBUGAR APÓS PASSAR ESTA LINHA O VALOR APARECERÁ
            // AO PASSAR O MOUSE SOBRE INDEX "index|2".
            // SENDO ASSIM: DECLARA UMA VARIAVEL DO TIPO "int" COM NOME "index1". USA A CLASSE "System.Array", JUNTO COM O METODO "IndexOf" (EndereçoDe). ENTRE PARENTESES, O 
            // NOME DO "vetor" A SER PROCURADO E, O VALOR NO CASO "5", QUE SE ENCONTRA DENTRO DO INDEX [2].
            //______________________________________________________________________________________________________________________________________________________________________________________

            //IMPRIMIR OS ELEMENTOS DO VETOR

            for (int index = 0; index < vetor.Length; index++) //O INDEX COMEÇARÁ DO ENDEREÇO "0", PASSARÁ PELOS MENORES QUE 4 (0,1,2,3, REFERENTE AO TAMANHO "Length"),
                                                               //"index++" REFERE-SE A FAZER O "FOR". OU SEJA, IMPRIMIR OS VALORE DO VETOR ACRESCENTANDO UM A UM ATÉ CHEGAR A 4, 
                                                               // MOSTRANDO OS VALORES QUE SÃO IMPRIMIDOS NA "MessageBox.Show" (1,3,5,7).
                MessageBox.Show(vetor[index].ToString());      


            //POR FIM O VETOR SERÁ IMPRIMIDO. O "ToString" É PORQUE O INDEX ESTÁ DECLARADO NUMA VARIAVEL "int" QUE SÓ 
            // PERMITE NUMEROS INTEIROS QUE PARA SER EXIBIDO PRECISA SER CONVERTIDO PARA TEXTO "String".

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            MessageBox.Show("MATRIZ BIDIMENCIONAL DE NUMEROS INTEIROS");              //MENSAGEM ILUSTRATIVA DE INICIO DE CODIGO
          
            // MATRIZ (ARRAY BIDIMENCIONAL DE NUMEROS INTEIROS).

           /*----------------------------------------------------------------------------------------------------------------------------
             * ESBOÇO DA MATRIZ:
             * 
             * 10 20 30 40
             * 6 12 18 24                     
             * 100 200 300 400                    *OBS: CONTROLE DE INDICE (INDEX-ENDEREÇO), COM 5 LINHAS E 4 COLUNAS DE NUMEROS INTEIROS.
             * 50 60 70 80
             * 7 14 21 28
             ----------------------------------------------------------------------------------------------------------------------------*/

            int[,] numeros = new int[5, 4];  //UM VETOR BIDIMENCIONAL "MATRIZ" É REPRESENTADO POR UMA "," DENTRO DA DECLARAÇÃO DE VARIAVEL NOS COLCHETES.
                                             //OU SEJA, NO INSTANCIAMENTO FEITO, CRIOU-SE UM ARRAY COM 5 LINHAS E 4 
            
                //POSIÇÕES DA MATRIZ:

                     //COLUNA 0    |      COLUNA 1     |      COLUNA 2     |       COLUNA 3  
                numeros[0, 0] = 10; numeros[0, 1] = 20; numeros[0, 2] = 30; numeros[0, 3] = 40;             //LINHA 0
                numeros[1, 0] = 6;  numeros[1, 1] = 12; numeros[1, 2] = 18; numeros[1, 3] = 24;             //LINHA 1
                numeros[2, 0] = 100; numeros[2, 1] = 200; numeros[2, 2] = 300; numeros[2, 3] = 400;         //LINHA 2
                numeros[3, 0] = 50; numeros[3, 1] = 60; numeros[3, 2] = 70; numeros[3, 3] = 80;             //LINHA 3
                numeros[4, 0] = 7; numeros[4, 1] = 14; numeros[4, 2] = 21; numeros[4, 3] = 28;              //LINHA 4


                //EXEMPLOS DE IDENTIFICAÇÃO DOS NUMEROS NA TABELA ESBOÇO:

                MessageBox.Show(numeros[0, 0].ToString());         //MOSTRARÁ 10   LINHA 0, COLUNA 0
                MessageBox.Show(numeros[2, 1].ToString());         //MOSTRARÁ 200  LINHA 2, COLUNA 1
                MessageBox.Show(numeros[3, 2].ToString());         //MOSTRARÁ 70   LINHA 3, COLUNA 2
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                
               //MATRIZ BIDIMENCIONAL DE NUMEROS INTEIROS E MULTIPLOS VALORES:
                MessageBox.Show("MATRIZ BIDIMENCIONAL DE NUMEROS INTEIROS E MULTIPLOS VALORES");              //MENSAGEM ILUSTRATIVA DE INICIO DE CODIGO
                
                //ESBOÇO:
                /*-----------------------------------------------------------
                 * 10 20 
                 * 6 12       3 LINHAS E 2 COLUNAS
                 * 14 17
                 ---------------------------------------------------------*/
             
                                                 //LINHA 1   //LINHA 2  //LINHA 3
                int[,] numeral = new int[3, 2] { { 10, 20 }, { 6, 12}, {14, 17} };  //CADA 2 NUMEROS NAS CHAVES REPRESENTA 1 LINHA. NO CASO SÃO 3 LINHAS.

                numeral[0, 0] = 10; numeral[1, 0] = 20;
                numeral[1, 0] = 6;  numeral[1, 1] = 12;
                numeral[2, 0] = 14; numeral[2, 1] = 17;

                MessageBox.Show(numeral[1, 0].ToString());       //EXEMPLO DE EXIBIÇÃO
                
            Close();

        }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        private void BtnVetorTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VETOR UNIDIMENCIONAL DE STRINGS");                        //MENSAGEM ILUSTRATIVA DE INICIO DE CODIGO
            //VETOR DE STRING (TEXTO)
            //______________________________________________________________________________________
            /* ESBOÇO DOS ELEMENTOS A SEGUIR:
             * [0] - MÁRIO                                                                         
             * [1] - SANGELA                                                                       
             * [2] - THÉO                                                                       
             * [3] - HELENA  */
            //______________________________________________________________________________________


            //DECLARE E INSTANCIE DESTE JEITO:

            //  string[] vetor;             //MESMA COISA QUE NO "INT". DECLARA UM VETOR DO TIPO STRING "strig[] vetor;" POIS CONTERÃO NOMES.
            //  vetor = new string[4];      //INSTANCIA COM A QUANTIDADE DE ENDEREÇOS QUE TERÃO ESSES VETORES "new string[4];"

            //OU DECLARE E INSTANCIE DESTE JEITO:

            String[] vetorString = new String[4];    //ADICIONA UM BREAK POINT NESTA LINHA, START O DEBUG, PASSA-SE O MOUSE SOBRE A VARIAVEL "vetorString", FIXA-SE O PINO
            //E VERIFICA-SE QUE OS VALORES/NOMES VÃO SENDO ADICIONADOS UM A UM COMO TEXTO A CADA CLICK (F10) STEP OVER.
            vetorString[0] = "Mário";                //NA DECLARAÇÃO ACIMA: "String[] vetorString" COM O SINAL "=", FOI DECLARADO E INSTANCIADO NA MESMA LINHA "new String[4];"
            vetorString[1] = "Sangela";
            vetorString[2] = "Théo";                 //NO PRIMEIRO EXEMPLO COM NUMEROS INTEIROS, PRIMEIRO FOI DECLARADA A VARIAVEL: "int[] = vetor;" E DEPOIS FOI INSTANCIADO
            vetorString[3] = "Helena";               //A QUANTIDADE DE VETORES: "vetor = new int [4];".


            //IMPRIMIR OS ELEMENTOS DO VETOR

            for (int index = 0; index < vetorString.Length; index++) //FAÇO O "FOR" DIZENDO PARA IMPRIMIR NA "MessageBox.Show", OS VALORES DOS ENDEREÇO "INDEX", MENORES QUE 
                MessageBox.Show(vetorString[index].ToString());      //4 "LENGHT". OS ENDEREÇOS SÃO CONVERTIDOS PARA TEXTO, POIS NOS ENDEREÇOS [0],[1],[2],[3] CONTÉM NUMEROS;
            // E NUMEROS SÃO "ints". AO FINAL INCREMENTA O INDEX PARA QUE EXIBA UM A UM NA MESSAGEBOX.

            //ACHAR VALOR (INFORMAÇÃO)  DENTRO DO VETOR
            int index1 = System.Array.IndexOf(vetorString, "Théo");

            // ACESSAR POSIÇÃO - "INDEX" / ÍNDICE
            string local = vetorString[1];

            // SABER O TAMANHO DO VETOR
            int tamanho = vetorString.Length;

            //ORDENAR VETOR  "Sort" (ORDENAR/ORGANIZAR)
            System.Array.Sort(vetorString); //É PRECISO DEBUGAR ESTA LINHA PARA VISUALIZAR AS MUDANÇAS. APARECERÁ [0]HELENA,[1]MÁRIO, [2]SANGELA, [3]THÉO. (EM ORDEM ALFABETICA)

                     
            
                      /*----------------------------------------------------------------------------------------------------------------------------
                     
                      // MATRIZ (ARRAY BIDIMENCIONAL DE STRINGS).

          
                        * ESBOÇO DA MATRIZ:
                        *------------------------------------ 
                        * MARIO  |SANGELA| THEO   | HELENA  |
                       * -----------------------------------|
                        * ALICE  |LUIZ   |BETO    |NICOLAS  |
                       * -----------------------------------|
                        * LUCIA  |DARIL  |PAULO   |LEONARDO |
                       * -----------------------------------|              *OBS: CONTROLE DE INDICE (INDEX-ENDEREÇO), COM 5 LINHAS E 4 COLUNAS DE STRINGS.
                        * ELIANA |SERGIO |MAURICIO| FERNANDA|
                       * -----------------------------------|
                        * NARCISO|VALERIA| GABRIEL| CLEBER  |
                         ----------------------------------------------------------------------------------------------------------------------------*/

            MessageBox.Show("MATRIZ BIDIMENCIONAL DE STRINGS");     //MENSAGEM ILUSTRATIVA DE INICIO DE CODIGO

            String[,] nomes = new string[5, 4];  //UM VETOR BIDIMENCIONAL "MATRIZ" É REPRESENTADO POR UMA "," DENTRO DA DECLARAÇÃO DE VARIAVEL NOS COLCHETES.
            //OU SEJA, NO INSTANCIAMENTO FEITO, CRIOU-SE UM ARRAY COM 5 LINHAS E 4 COLUNAS.

            //POSIÇÕES DA MATRIZ:

               //COLUNA 0    |         COLUNA 1     |           COLUNA 2     |         COLUNA 3           |
            nomes[0, 0] = "MARIO"; nomes[0, 1] = "SANGELA"; nomes[0, 2] = "THEO"; nomes[0, 3] = "HELENA";                   //LINHA 0
            nomes[1, 0] = "ALICE"; nomes[1, 1] = "LUIZ"; nomes[1, 2] = "BETO"; nomes[1, 3] = "NICOLAS";                     //LINHA 1
            nomes[2, 0] = "LUCIA"; nomes[2, 1] = "DARIL"; nomes[2, 2] = "PAULO"; nomes[2, 3] = "LEONARDO";                  //LINHA 2
            nomes[3, 0] = "ELIANA"; nomes[3, 1] = "SERGIO"; nomes[3, 2] = "MAURICIO"; nomes[3, 3] = "FERNANDA";             //LINHA 3
            nomes[4, 0] = "NARCISO"; nomes[4, 1] = "VALERIA"; nomes[4, 2] = "GABRIEL"; nomes[4, 3] = "CLEBER";              //LINHA 4


            //EXEMPLOS DE IDENTIFICAÇÃO DOS NUMEROS NA TABELA ESBOÇO:

            MessageBox.Show(nomes[1, 3].ToString());         //MOSTRARÁ NICOLAS    LINHA 1, COLUNA 3
            MessageBox.Show(nomes[4, 2].ToString());         //MOSTRARÁ GABRIEL    LINHA 4, COLUNA 2
            MessageBox.Show(nomes[2, 3].ToString());         //MOSTRARÁ LEONARDO   LINHA 2, COLUNA 3
         


            
            Close();

        }

        public int[,] num { get; set; }
    }
}