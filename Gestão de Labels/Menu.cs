using GestaoLabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoLabels
{
    internal class Menu
    {
        private List<string?> labels = new List<string?>();
        public void print()
        {
            Console.Clear();
            Console.WriteLine("[+] Bem Vindo ao Sistema de Labels");
            Console.WriteLine("1 - Cadastrar novo Label");
            Console.WriteLine("2 - Exibir Label");
            Console.WriteLine("3 - Excluir Label");
            Console.WriteLine("9 - Sair");
            Console.Write("\nEscolha uma opção: ");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        var cadastrarLabel = new CadastrarLabel(labels);
                        cadastrarLabel.print();
                        break;
                    case 2:
                        var listarLabel = new ListarLabels(labels);
                        listarLabel.print();
                        break;
                    case 3:
                        //ExcluirLabel();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("[-] Opção inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("[-] Entrada inválida.");
            }

            Console.WriteLine();
        }
    }
}
   
