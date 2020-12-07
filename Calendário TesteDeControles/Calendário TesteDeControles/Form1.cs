using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendário_TesteDeControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            DateTime dataNacimento; 
            string cidade;                     
            bool sexoM;
            bool sexoF;
            int numeroCadastro; 
           
            nome = textBox1.Text;              //PEGA TEXTO DENTRO DA "textBox1" E INSERE DENTRO DA VARIÁVEL "nome".
            dataNacimento = dateTimePicker1.Value;
            cidade = comboBox1.Text;
            sexoM = radioButton1.Checked;
            sexoF = radioButton2.Checked;
            numeroCadastro = Convert.ToInt16(textBox2.Text);

            
            MessageBox.Show("Nome: " + nome); //EXIBE "Nome: " (QUE JÁ SERÁ EXIBIDO POR CONTA DAS ASPAS) + A VARIÁVEL "nome" (O "+" TEM A FUNÇÃO DE CONCATENAR VALORES).
            MessageBox.Show("Data de Nascimento: " + dataNacimento);   // "Data de Nascimento: " + dataNascimento.
            MessageBox.Show("Cidade: " + cidade);                      // "Cidade: " + cidade.
            MessageBox.Show("Sexo Masculino: " + sexoM);               // "Sexo Masculino: " + sexoM.
            MessageBox.Show("Sexo Feminino: " + sexoF);                // "Sexo Feminino: " + sexoF.
            MessageBox.Show("Numero do Cadastro: " + numeroCadastro);  // "Numero do Cadastro: " + numeroCadastro.

    

        }
            

    }
}
