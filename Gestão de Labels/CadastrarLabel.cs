using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GestaoLabels
{
    internal class CadastrarLabel
    {
        private List<string?> internalLabels = new List<string?>();
        
        public CadastrarLabel(List<string?>labels)

        {
            this.internalLabels = labels;
        }
        public void print()
        {
            
            Console.Clear();
            Console.Write("[!] Digite o nome da label: ");
            string? texto = Console.ReadLine();
            bool salvou = this.salvar(texto);
            if (salvou)
            {
                Console.WriteLine("[+] Label cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("[-] Erro ao cadastrar nova Label!");
            }
            Thread.Sleep(3000);
            Console.Clear();

        }

        private bool salvar(string? texto)
        {
            internalLabels.Add(texto);
            return true;
        }

    }
}
