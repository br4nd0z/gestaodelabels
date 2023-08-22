using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoLabels
{
    internal class ListarLabels
    {
        public ListarLabels(List<string?>labels) 
        {
            this.internalLabels = labels;
        }

        private List<string?> internalLabels = new List<string?>();
        public void print()
        {
            Console.Clear();
            for (int i = 0; i < internalLabels.Count; i++)
            {
                Console.WriteLine(internalLabels[i]);
            }
            Console.WriteLine("[!] Pressione qualquer tecla para voltar a Menu.");
            Console.Read();
        }

    }
}
