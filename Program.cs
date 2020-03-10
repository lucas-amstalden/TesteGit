using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo, teste!");
            Console.WriteLine("***************************");
            
            Tabuada tabu1 = new Tabuada();
            tabu1.calculaTabuada();
            Console.WriteLine("***************************");
            Console.Write("Fim");
        }
    }
}
