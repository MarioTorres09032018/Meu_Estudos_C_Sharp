using System;
using System.Windows.Forms;
using System.Threading;     // FOI ADICIONADO UM NOVO "using" COM O NOME "Threading". POIS IREMOS TRABALHAR COM OUTRAS THREADINGS (ENCAIXES / JAMPEAMENTO / OUTRAS 
                            //TELAS INTERLIGADAS).


namespace TelaLoginSenha
{
    public partial class Form1 : Form
    {
        Thread NovaTela;           // CRIA UMA VARIAVEL DO TIPO THREAD.

        public Form1()
        {
            InitializeComponent();                                       // APENAS IF ELSE. NA TEXTBOX2 (SENHA), HÁ UMA MUDANÇA NAS PROPRIEDADES PARA QUE A SENHA EXIBA UM 
        }                                                                // CHAR, EM VEZ DE EXIBIR A SENHA DIGITADA. PROPRIEDADE "passwordChar".

    private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mario Torres" && textBox2.Text == "12345")
            {
                MessageBox.Show("BEM VINDO MARIO TORRES!");

                this.Close();
                NovaTela = new Thread(novoForm);       
                NovaTela.SetApartmentState(ApartmentState.STA);
                NovaTela.Start();
            }                     
                
/* VARIAVEL "NovaTela" = OPERADOR "new" DO TIPO "Thread" COM METODO (novoForm); 
SERÁ PRECISO PASSAR O MOUSE SOBRE O METODO "(NovoForm)", QUE APARECERÁ A OPÇÃO: 
Gerar metodo stub para 'novoForm' em 'TelaLoginSenha.FORM1'. APARECERÁ UMA LINHA COMPLETA AO FINAL DO CODIGO
"private void novoForm(object obj)" LOGO ABAIXO, "throw new NotImplementedException();" PARA QUE O PROCESSO SEJA FEITO,
APAGA-SE O ULTIMO CODIGO GERADO "throw new NotImplementedException();" E ESCREVE-SE UMA NOVA LINHA QUE DIRÁ 
PARA QUE O CODIGO "RODE"(RUN). A LINHA SERÁ: "Application.Run(new TelaLoginSenhaNovoForm());" QUE FAZ REFERENCIA 
A NOVA TELA (NOVO FORM "TelaLoginSenhaNovoForm"). MAS ANTES LÁ NA LINHA ABAIXO DE "NovaTela = new Thread(novoForm);"
SERÁ DEFINIDO O ESTADO DO APPARTMENT DA THREAD COM A LINHA DE CODIGO: "NovaTela.SetApartmentState(ApartmentState.STA);"
TERÁ MTA(MULTIPLAS THREADS) E STA(SINGLE THREAD). NO CASO DO NOSSO APP SERÁ USADO STA(UMA THREAD SÓ). 
E POR FIM DAR START NA THREAD COM A LINHA: "NovaTela.Start(); E ABRIRÁ O FORM2 (TelaLoginSenhaNovoForm) E FECHARÁ O FORM1.
*/                                              
                                            
            else
            {
                MessageBox.Show("LOGIN OU SENHA NÃO CONFEREM!");

            }
        }

   private void novoForm(object obj)
{
 	          Application.Run(new TelaLoginSenhaNovoForm());      
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    }
    

