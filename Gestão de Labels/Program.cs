// Projeto Gestão de Labels

using GestaoLabels;

static class Programa
{

    

    static void Main(string[] args)
    {
         Menu menu = new Menu();

        while (true)
        {
            menu.print();
        }
    }

    

    //void BuscarLabel()
    //{
    //    Console.Clear();
        
    //    Console.WriteLine("Labels:");
    //    for (int i = 0; i < labels.Count; i++)
    //    {
    //        Console.WriteLine($"{i + 1}. {labels[i]}");
    //    }

    //    Thread.Sleep(3000);
    //    Console.Clear();
    //}

    //void ExcluirLabel()
    //{
    //    Console.Clear();

    //    BuscarLabel();

    //    Console.Write("[!] Digite o número da label que deseja exluir: ");
    //    if (int.TryParse(Console.ReadLine(), out int numeroLabel) && numeroLabel > 0 && numeroLabel <= labels.Count)
    //    {
    //        labels.RemoveAt(numeroLabel - 1);
    //        Console.WriteLine("[+] Label deletada com sucesso!");
    //    }
    //    else
    //    {
    //        Console.WriteLine("[-] Número de label inválido.");
    //    }

    //    Thread.Sleep(3000);
    //    Console.Clear();
    //}

}

