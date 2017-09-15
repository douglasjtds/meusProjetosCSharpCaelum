using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoBanco.Busca
{
    public class GeradorDeDevedores
    {
        public List<string> GeraList()
        {
            List<string> nomes = new List<string>();
            for (int i = 0; i < 30000; i++)
            {
                nomes.Add("devedor " + i);
            }
            return nomes;
        }
    }
}
