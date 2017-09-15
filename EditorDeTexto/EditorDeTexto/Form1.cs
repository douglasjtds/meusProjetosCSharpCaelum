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

            //como salvar o arquivo em uma pasta diferente da pasta do projeto
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
            escritor.Write(textoConteuto.Text);
            escritor.Close();
            saida.Close();

            MessageBox.Show("Arquivo salvo com sucesso");
            //this.Dispose(); //para fechar a janela do programa

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteuto.Text;
            int resultadoBusca = textoDoEditor.IndexOf(busca);
            if (resultadoBusca >= 0) {
                MessageBox.Show("Achei o texto " + busca); 
            } else {
                MessageBox.Show("Não achei.");
            }

        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteuto.Text;
            int resultadoDaBusca = textoDoEditor.IndexOf(busca);
            if (resultadoDaBusca >= 0) {
                busca = busca.Replace(textoBusca.ToString(), textoReplace.ToString());
                MessageBox.Show("Substituição feita com sucesso.");

                //continuar daqui, ainda não terminei a lógica de salvar a modificação no arquivo
                //exercício 3


            } else {
                MessageBox.Show("Palavra não encontrada.");
            }
        }
    }
}
