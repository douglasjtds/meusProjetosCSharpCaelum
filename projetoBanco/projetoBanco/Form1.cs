using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoBanco.Contas;

namespace projetoBanco
{
    public partial  class Form1 : Form
    {
        // adicionando dicionário
        private Dictionary<string, Conta> dicionario;


        //para guardar o número de contas já cadastradas
        /* private int numeroDeContas;  quando passsou a usar List 
        no lugar de array, não precisaremos disso mais */

        private List<Conta> listaDeContas; //private Conta[] contas;
        //private List<Cliente> listaDeClientes;

        //HashSet<string> devedores = new HashSet<string>();
        //int elementosDevedores = devedores.Count; //não sei pq sáporra tá com erro 
        

        public void AddConta(Conta conta) {
            //this.contas[this.numeroDeContas] = conta;
            listaDeContas.Add(conta);
            
            //this.numeroDeContas++; //não precisa contar mais quando usa lista
            //...por causa da função Count
            
            comboContas.Items.Add(conta.Titular.Nome);

            //this.dicionario.Add(conta.Titular.Nome, conta);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listaDeContas = new List<Conta>();
            //this.listaDeClientes = new List<Cliente>();

            this.dicionario = new Dictionary<string, Conta>();

            /*
            //criando o array para guardar as contas
            this.contas = new Conta[10]; */

            //inicializando algumas instancias de conta
            this.listaDeContas.Add(new ContaCorrente());
            this.listaDeContas[0].Titular = new Cliente("Douglas - Conta");
            this.listaDeContas[0].Numero = 1;
            //this.numeroDeContas++;

            this.listaDeContas.Add(new ContaPoupanca());
            this.listaDeContas[1] = new ContaPoupanca();
            this.listaDeContas[1].Titular = new Cliente("Mauricio - ContaPoupanca");
            this.listaDeContas[1].Numero = 2;
            //this.numeroDeContas++;

            this.listaDeContas.Add(new ContaCorrente());
            this.listaDeContas[2] = new ContaCorrente();
            this.listaDeContas[2].Titular = new Cliente("Olívia - ContaCorrente");
            this.listaDeContas[2].Numero = 3;
            //this.numeroDeContas++;
            
            foreach (Conta conta in listaDeContas)
            {
                //comboContas.Items.Add(conta.Titular.Nome);
                comboContas.Items.Add(conta);
            }
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDeposito_Click(object sender, EventArgs e)
        {
            /* 
            //recuperar o indice da conta selecionada
            int indice = comboContas.SelectedIndex;

            this.contas[indice].Deposita(Convert.ToDouble(textoValor.Text));
            //double valor = Convert.ToDouble();
            //selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(contas[indice].Saldo);
            MessageBox.Show("Sucesso"); 
            
             agora acrescentando o try catch  */

            //Conta selecionada = (Conta) comboContas.SelectedItem; //tmb poderia ser feito dessa forma 
    
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = this.listaDeContas[indice];

            try {

                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Deposito realizado com sucesso.");

            } catch (ArgumentException) {
                MessageBox.Show("Não é possível depositar um valor negativo.");
            }

        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            ////recuperar o indice da conta selecionada
            ////int indice = Convert.ToInt32(textoIndice.Text);
            //int indice = comboContas.SelectedIndex;

            //this.contas[indice].Saca(Convert.ToDouble(textoValor.Text));

            ////ler a posição correta do array
            ////Conta selecionada = this.contas[indice];


            ////double valor = Convert.ToDouble(textoValor.Text);
            ////selecionada.Saca(valor);
            //textoSaldo.Text = Convert.ToString(contas[indice].Saldo);
            //MessageBox.Show("Sucesso");


            /* agora utilizando o try */
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = this.listaDeContas[indice];
            try {

                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro liberado - Saque efetuado com sucesso");

            } catch (SaldoInsuficienteException ex) {
                MessageBox.Show("Saldo insuficiente");
            } catch (ArgumentException ex) {
                MessageBox.Show("Não é possível sacar um valor negativo.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = listaDeContas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void buttonNovaConta(object sender, EventArgs e)
        {
            // this representa a instância de Form1 que está sendo utilizada pelo Windows Form
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            /* Sem a classe TotalizadorDeTributos */
            //ContaCorrente conta = new ContaCorrente();
            //conta.Deposita(200.0);

            //MessageBox.Show("imposto da conta corrente = " + conta.CalculaTributo());
            //ITributavel t = conta;

            //MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributo());

            //SeguroDeVida sv = new SeguroDeVida();
            //MessageBox.Show("imposto do seguro = " + sv.CalculaTributo());

            //t = sv;
            //MessageBox.Show("imposto do seguro pela interface = " + t.CalculaTributo());


            /* Com a classe TotalizadorDeTributos */
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(conta);
            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.Acumula(sv);
            MessageBox.Show("Total: " + totalizador.Total);

        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaTitular.Text;
            Conta conta = dicionario[nomeTitular];

            comboContas.SelectedItem = conta;

            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);

        }

        private void buttonAbrirTelaDoLINQ_Click(object sender, EventArgs e)
        {
            // this representa a instância de Form1 que está sendo utilizada pelo Windows Form
            FormRelatorios formularioLINQ = new FormRelatorios(this.listaDeContas);
            formularioLINQ.ShowDialog();
        }
    }
}
