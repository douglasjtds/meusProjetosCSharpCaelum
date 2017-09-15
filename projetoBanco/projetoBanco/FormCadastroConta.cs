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
using projetoBanco.Busca;

namespace projetoBanco
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;
        
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            int indice = comboBoxTipoDaConta.SelectedIndex;
            string titular = textoTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);
            if(!ehDevedor) {
                if (indice == 0) {
                    var novaConta = new ContaCorrente();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    //novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                    this.formPrincipal.AddConta(novaConta);
                } else if (indice == 1){
                    var novaConta = new ContaPoupanca();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    this.formPrincipal.AddConta(novaConta);
                } else if (indice == 2) {
                    var novaConta = new ContaInvestimento();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    this.formPrincipal.AddConta(novaConta);
                }
                

            } else {
                MessageBox.Show("Cliente é devedor.");
            }

            
            this.Dispose();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            comboBoxTipoDaConta.Items.Add("Conta Corrente");
            comboBoxTipoDaConta.Items.Add("Conta Poupança");
            comboBoxTipoDaConta.Items.Add("Conta Investimento");
        }

        private void comboBoxTipoDaConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
