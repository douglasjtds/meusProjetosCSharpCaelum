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
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;

        private Form1 formPrincipal;

        public FormRelatorios(List<Conta> contas)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            this.contas = contas;
            
        }

        private void buttonFiltroSaldo_Click(object sender, EventArgs e)
        {
            //filtro com o LINQ
            listaResultado.Items.Clear();

            var resultadoFiltroSaldo = from c in contas                             //
                                       where c.Saldo > 5000                         // query do LINQ
                                       orderby c.Titular.Nome, c.Numero             //
                                       select c;                                    //

            /* ou com os métodos do próprio LINQ, ficaria assim:
            var resultadoFiltroSaldo = contas
                                       .Where(c => c.Saldo > 10000)
                                       .OrderBy(c => c.Titular.Nome)
                                       .ThenBy(c => c.Numero);
                                       */


            foreach (var c in resultadoFiltroSaldo)
            {
                listaResultado.Items.Add(c);
            }

            /*   ------ não descobri o pq desse erro :(  -> seção 21.7 de apostila caelum
            double saldoTotal = resultadoFiltroSaldo.Sum(c => c.Saldo);
            double maiorSaldo = resultadoFiltroSaldo.Max(c => c.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);   */
        }

        private void buttonContasAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultadoContasAntigas = from c in contas
                                         where (c.Numero < 5 && c.Saldo > 1000)
                                         orderby c.Titular.Nome
                                         select c;

            foreach (var c in resultadoContasAntigas)
            {
                listaResultado.Items.Add(c);
            }

        }
    }
}
