using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Exercícios da apostila Caelum de c#
namespace firstProjectTest{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e){
            string message = ("Mensagem: Hello world!");
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e){
            int idadeJoao = 10, idadeMaria = 25, idadeDouglas = 22, media;
            media = (idadeDouglas + idadeJoao + idadeMaria) / 3;
            MessageBox.Show("A média de idade dos três amigos é: " + media);
        }


        private void button3_Click_1(object sender, EventArgs e){
            double pi = 3.14;
            MessageBox.Show("O valor de pi: " + pi);
        }

        private void button4_Click(object sender, EventArgs e){
            double pi = 3.14;
            int brokenPi = (int)pi; //fazendo um casting teste
            MessageBox.Show("pi quebrado = " + brokenPi);
        }

        private void button5_Click(object sender, EventArgs e){
            int a = 1, b = -3, c = -10;
            double delta, a1, a2;
            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            MessageBox.Show("O valor de a1 é " + a1);
            MessageBox.Show("O valor de a2 é " + a2);
        }

        //para dizer se a pessoa está apta a votar
        private void button6_Click(object sender, EventArgs e){
            int idade = 15;
            bool brasileira = true;
            if((idade>=16) && (brasileira)){
                MessageBox.Show("Pode votar.");
            }else {
                MessageBox.Show("Não pode votar.");
            }
        }
        
        private void button7_Click(object sender, EventArgs e){
            double valorDaNotaFiscal = 999.0;
            double imposto;
            if (valorDaNotaFiscal<=999){
                imposto = 0.2;
                MessageBox.Show("O valor do imposto é: " + imposto);
            } else if((valorDaNotaFiscal>=1000) && (valorDaNotaFiscal<=2999)){
                imposto = 0.25;
                MessageBox.Show("O valor do imposto é: " + imposto);
            } else if((valorDaNotaFiscal>=3000) && (valorDaNotaFiscal<=6999)) {
                imposto = 0.28;
                MessageBox.Show("O valor do imposto é: " + imposto);
            } else if(valorDaNotaFiscal>=7000) {
                imposto = 0.3;
                MessageBox.Show("O valor do imposto é: " + imposto);
            }

        }

        //treinando repetições
        private void button8_Click(object sender, EventArgs e){
            int soma = 0; 
            for(int i = 0; i<=1000; i++) {
                soma = soma + i;
            }
            MessageBox.Show("A soma dos números é = " + soma);

            //outro exercício de repetição
            int j = 0;
            while(j<=100) {
                if(j % 3 == 0) {
                    MessageBox.Show("múltiplo: " + j);
                }
                j++;
            }

            //outro (soma de 0 a 100 pulando os múltiplos de 3)
            int somaMultiplos = 0;
            for (int k = 0; k <= 100; k++){
                if (!(k % 3 == 0)){
                    somaMultiplos = somaMultiplos + k;
                }
            }
            MessageBox.Show("soma pulando os múltiplos de 3 é: " + somaMultiplos);

        }

        private void button9_Click(object sender, EventArgs e){
            int fatorial = 1;
            for (int n = 1; n <= 10; n++){
                fatorial = fatorial * n;
                MessageBox.Show("Fatorial de " +n+ " = " + fatorial);
                Console.WriteLine(fatorial);
            }
        }

        private void button10_Click(object sender, EventArgs e){
            /*    
                //cria a contaDouglas
                Conta contaDouglas = new Conta();
                contaDouglas.titular = "Douglas";
                contaDouglas.numero = 35;
                contaDouglas.saldo = 1000.0;


                //cria a contaFulano
                Conta contaFulano = new Conta();
                contaFulano.titular = "Fulano";
                contaFulano.numero = 39;
                contaFulano.saldo = 100.0;

                //imprime informações da contaDouglas
                MessageBox.Show("----Valores iniciais----" + "\n" + "Nome do titular: " + contaDouglas.titular + "\n" + 
                                "Número da conta: " + contaDouglas.numero + "\n" +
                                "Saldo: " + contaDouglas.saldo);

                //imprime informações da contaFulano                    
                MessageBox.Show("----Valores iniciais----" + "\n" + "Nome do titular: " + contaFulano.titular + "\n" +
                                "Número da conta: " + contaFulano.numero + "\n" +
                                "Saldo: " + contaFulano.saldo);

                //Realizando alguns testes no código...
                contaDouglas.Saca(100);

                MessageBox.Show("Nome do titular: " + contaDouglas.titular + "\n" +
                               "Número da conta: " + contaDouglas.numero + "\n" +
                               "Saldo: " + contaDouglas.saldo);



                contaFulano.Deposita(200);
                MessageBox.Show("Nome do titular: " + contaFulano.titular + "\n" +
                                "Número da conta: " + contaFulano.numero + "\n" +
                                "Saldo: " + contaFulano.saldo);



                contaDouglas.Transfere(100, contaFulano);
                MessageBox.Show("Nome do titular: " + contaDouglas.titular + "\n" +
                               "Número da conta: " + contaDouglas.numero + "\n" +
                               "Saldo: " + contaDouglas.saldo);

                MessageBox.Show("Nome do titular: " + contaFulano.titular + "\n" +
                                "Número da conta: " + contaFulano.numero + "\n" +
                                "Saldo: " + contaFulano.saldo);




                //teste questão 9
               /*
                Conta mauricio = new Conta();
                mauricio.numero = 1;
                mauricio.titular = "Mauricio";
                mauricio.saldo = 100.0;

                Conta mauricio2 = new Conta();
                mauricio2.numero = 1;
                mauricio2.titular = "Mauricio";
                mauricio2.saldo = 100.0;

                if (mauricio == mauricio2){
                    MessageBox.Show("As contas são iguais");
                }
                else{
                    MessageBox.Show("As contas são diferentes");
                }
                //fim questão 9

                //teste questão 10
                Conta mauricio = new Conta();
                mauricio.saldo = 2000.0;

                Conta copia = mauricio;
                copia.saldo = 3000.0;

                MessageBox.Show("mauricio = " + mauricio.saldo);
                MessageBox.Show("copia = " + copia.saldo);

                */

            //Conta umaConta = new Conta();
            //Cliente guilherme = new Cliente();
            //guilherme.nome = "Guilherme Silveira";
            //umaConta.titular = guilherme;

            //MessageBox.Show(umaConta.titular.nome);


            //testes final do cápítulo 6
            /*Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.rg = "12345678-9";

            umaConta.titular = guilherme;
            umaConta.titular.rg = "98765432-1";

            MessageBox.Show(guilherme.rg);

             */

            //Conta umaConta = new Conta();
            //Cliente guilherme = new Cliente();
            //umaConta.titular.idade = 15;
            //guilherme.EhMaiorDeIdade();




        }
    }
}
