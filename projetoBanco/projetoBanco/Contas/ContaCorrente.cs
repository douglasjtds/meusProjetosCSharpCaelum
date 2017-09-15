using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoBanco.Contas;

namespace projetoBanco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            //base.Saca(valor + 0.05);


            //com tratamento de exceções 
            if(valor < 0) {
                throw new ArgumentException();
            }

            if (valor + 0.05 > this.Saldo) {
                throw new SaldoInsuficienteException();
            } else {
                this.Saldo -= valor + 0.05;
            }
        }

        public override void Deposita(double valorOperacao) {
            if(valorOperacao < 0.0) {
                throw new ArgumentException();
            }

            //antes do tratamento de exceção
            base.Deposita(valorOperacao - 0.10);
        }

        public double CalculaTributo() {
            return this.Saldo * 0.05;
        }
    }
}
