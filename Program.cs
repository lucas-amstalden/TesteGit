using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                opcao = 0;
                Console.Clear();
                Console.WriteLine("Bem vindo, teste!");
                Console.Read();
                Console.WriteLine("***************************");
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1 - Tabuada");
                Console.WriteLine("2 - Potência");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("***************************");
                Console.Write("Opção: ");
                opcao = Convert.ToInt16(Console.ReadLine( ));
                switch(opcao)
                {
                    case 1:
                        Tabuada tabu = new Tabuada();
                        tabu.calculaTabuada();
                        opcao = 0;
                        break;
                    case 2:
                        Potencia pot = new Potencia();
                        pot.calculaPotencia();
                        opcao = 0;
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.Read();
                        opcao = 0;
                        break;
                }
            } while (opcao == 0);
            
        }
    }
}
