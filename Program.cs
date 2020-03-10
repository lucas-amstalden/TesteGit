using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "-2";

            while (opcao != "3")
            {
                opcao = string.Empty;
                Console.Clear();
                Console.WriteLine("Bem vindo, teste!");
                Console.WriteLine("***************************");
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1 - Tabuada");
                Console.WriteLine("2 - Potência");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("***************************");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
                switch(opcao)
                {
                    case "1":
                        Tabuada tabu = new Tabuada();
                        tabu.calculaTabuada();
                        break;
                    case "2":
                        Potencia pot = new Potencia();
                        pot.calculaPotencia();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.Read();
                        break;
                }
            }
            

            
        }
    }
}
