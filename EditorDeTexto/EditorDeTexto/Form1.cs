using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //como salvar o arquivo em uma pasta diferente da pasta do projeto(?)
            var pastaDocumentos = Environment.GetFolderPath(
                          Environment.SpecialFolder.MyDocuments);

            var caminhoArquivo = Path.Combine(pastaDocumentos, "texto.txt");

            //File.WriteAllText(caminhoArquivo, txtConfig.Text);


            if (File.Exists("texto.txt")) {

                Stream entrada = File.Open("texto.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                //while (linha != null) {
                //    textoConteuto.Text += linha;
                //    linha = leitor.ReadLine();
                //}

                //  ou:
                leitor.ReadToEnd(); //isso da certo tmb
                    
                leitor.Close();
                entrada.Close();
            }
        }

        private void buttonGrava_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open("texto.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(textoConteudo.Text);
            escritor.Close();
            saida.Close();

            MessageBox.Show("Arquivo salvo com sucesso");
            //this.Dispose(); //para fechar a janela do programa

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultadoBusca = textoDoEditor.IndexOf(busca);
            if (resultadoBusca >= 0) {
                MessageBox.Show("Achei o texto: " + busca); 
            } else {
                MessageBox.Show("Não achei " + "- " + busca + " -" + " no texto.");
            }

        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            string textoParaMudar = textoReplace.Text;
            int resultadoDaBusca = textoDoEditor.IndexOf(busca);
            if (resultadoDaBusca >= 0) {
                textoConteudo.Text = textoDoEditor.Replace(busca, textoParaMudar);
            } else {
                MessageBox.Show("Palavra não encontrada.");
            }
        }

        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            string tudoMaiusculo = textoConteudo.Text;
            tudoMaiusculo = tudoMaiusculo.ToUpper();
            textoConteudo.Text = tudoMaiusculo;
            MessageBox.Show("Texto alterado com sucesso.");
        }

        private void buttonToLower_Click(object sender, EventArgs e)
        {
            string tudoMinusculo = textoConteudo.Text;
            tudoMinusculo = tudoMinusculo.ToLower();
            textoConteudo.Text = tudoMinusculo;
            MessageBox.Show("Texto alterado com sucesso.");
        }

        private void buttonSelectedToUpper_Click(object sender, EventArgs e){

            /*código que peguei no exercício da apostila para colocar em maiusculo 
            apenas o texto selecionado pelo usuário */

            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

            // e também do texto depois
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            // E agora só precisamos redefinir o campo texto
            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
        }
    }
}
