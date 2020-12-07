using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorDeCodigoDeBarras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*ESTE EXERCICIO FOI FEITO E O PROFESSOR TINHA UM LEITOR DE CODIGOS DE BARRAS (MAS A TECLA ENTER DO PC TAMBÉM FOI IMPLEMENTADA COMO SENDO UM LEITOR).
          QUANDO DUBUGAR, PARA QUE APAREÇA ALGO NA MESSAGEBOX, ESCREVA ALGO NA CAIXA DE TEXTO. QUANDO O ENTER FOR APERTADO A MESSAGEBOX EXIBIRA A INFORMAÇÃO. 
         */ 

        // *OBS: OS EVENTOS KEYUP (TECLA SOLTA), KEYDOWN (TECLA APERTADA), E KEYPRESS; SÃO OS EVENTOS QUE PODEM SER IMPLEMENTADOS PARA LEITURA DE CODIGOS DE BARRAS.

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   //Codigo  lido pela Leitora
                string codigoBarras = textBox1.Text;

                //Exibir caixa de mensagem
                MessageBox.Show(codigoBarras);





                /*INSERE CAIXA DE TEXTO, VAI EM PROPRIEDADES DA CAIXA DE TEXTO: EVENTOS (O RAIO), DESCE NAS OPÇOES E CLICA DUAS VEZES NO BOTÃO "KEYUP", SERÁ IMPLEMENTADO
                  UM EVENTO AO BOTÃO. LEMBRANDO QUE A LETRA "e" LÁ EM CIMA NA INSTRUÇÃO "private void textBox1_KeyUp(object sender, KeyEventArgs e)" DO BOTÃO, 
                  GUARDA A TECLA QUE FOI APERTADA. VEM COMO PARÂMETRO, TODA VEZ QUE ACONTECE UMA AÇÃO DENTRO DA CAIXA DE TEXTO ESSE "e"  APARECE. 
                 */
                  
                
            }
        }
    }
}