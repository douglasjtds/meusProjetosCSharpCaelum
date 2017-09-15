using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProjectTest{

    public class Conta{
        //declaração dos atributos
        private int numero;
        private double saldo;
        private Cliente titular;

        //get e set automático (auto-implemented property)
        public int Numero { get; set; }


        // get é público e pode ser acessado por qualquer classe
        // set é privado e por isso só pode ser usado pela Conta
        public double Saldo { get; private set; }
       

        //métodos
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Saca(double valor) {
            if(this.saldo >= valor) {
                this.saldo -= valor;
                MessageBox.Show("Saque realizado com sucesso.");
                return true;
            } else {
                MessageBox.Show("Saldo insuficiente.");
                return false;
            }

        }

        public void Transfere(double valor, Conta destino) {
            if(this.Saca(valor)) {
                destino.Deposita(valor);
            }
        }

        /*
      //getter
      public double PegaSaldo()
      {
          return this.saldo;
      }


      //setter
      public void ColocaNumero(int numero)
      {
          this.numero = numero;
      }    */



    }
}
