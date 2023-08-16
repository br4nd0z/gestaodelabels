// Projeto Gestão de Labels


class Programa
{
    static List<string> labels = new List<string>();

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("[+] Bem Vindo ao Sistema de Labels");
            Console.WriteLine("1 - Cadastrar novo Label");
            Console.WriteLine("2 - Buscar Label");
            Console.WriteLine("3 - Excluir Label");
            Console.WriteLine("9 - Sair");
            Console.Write("\nEscolha uma opção: ");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CadastrarLabel();
                        break;
                    case 2:
                        BuscarLabel();
                        break;
                    case 3:
                        ExcluirLabel();
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

    static void CadastrarLabel()
    {
        Console.Clear();
        Console.Write("[!] Digite o nome da label: ");
        string texto = Console.ReadLine();
        labels.Add(texto);
        Console.WriteLine("\n[+] Label cadastrada com sucesso!");

        Thread.Sleep(3000);
        Console.Clear();

    }

    static void BuscarLabel()
    {
        Console.Clear();
        
        Console.WriteLine("Labels:");
        for (int i = 0; i < labels.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {labels[i]}");
        }

        Thread.Sleep(3000);
        Console.Clear();
    }

    static void ExcluirLabel()
    {
        Console.Clear();

        BuscarLabel();

        Console.Write("[!] Digite o número da label que deseja exluir: ");
        if (int.TryParse(Console.ReadLine(), out int numeroLabel) && numeroLabel > 0 && numeroLabel <= labels.Count)
        {
            labels.RemoveAt(numeroLabel - 1);
            Console.WriteLine("[+] Label deletada com sucesso!");
        }
        else
        {
            Console.WriteLine("[-] Número de label inválido.");
        }

        Thread.Sleep(3000);
        Console.Clear();
    }

}

