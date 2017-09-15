using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProjectTest
{
    public class Cliente
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;
        
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Cliente (string nome, int idade) {
            this.Nome = nome;
            this.Idade = idade;
        }

        public bool EhMaiorDeIdade () {
            if(this.idade >= 18) {
                MessageBox.Show("Cliente é maior de idade.");
                return true;
            }else {
                MessageBox.Show("Cliente NÃO é maior de idade.");
                return false;
            }
        }
    }
}
