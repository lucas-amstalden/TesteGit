using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            Console.WriteLine("Bem vindo, teste!");
            Console.WriteLine("***************************");
            Console.Write("Digite o número tabuada: ");
            aux = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O número digitado foi: " + aux.ToString());
            Console.WriteLine("***************************");
            
            for(int i=1; i<11; i++)
            {
                Console.WriteLine(aux + " X " + i + " = " + (aux * i));
            }
        }
    }
}
