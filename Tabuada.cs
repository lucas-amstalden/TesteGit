using System;

namespace TesteGit
{
    class Tabuada
    {
        public void calculaTabuada()
        {  
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Classe para calcular a Tabuada");
            Console.Write("Digite o número tabuada: ");
            int aux = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + aux.ToString());
            Console.WriteLine("***************************");
            
            for(int i=1; i<11; i++)
            {
                Console.WriteLine(aux + " X " + i + " = " + (aux * i));
            }
            
        }
    }



}
