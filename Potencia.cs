using System;

namespace TesteGit
{
    class Potencia
    {
        public void calculaPotencia()
        {
            Console.Clear();
            double num = 0, aux = 0;
            Console.WriteLine("************************************");
            Console.WriteLine("Classe para calcular potência");
            Console.Write("Digite o número que deseja saber a potência: ");
            num = Convert.ToDouble(Console.ReadLine());
            aux = Math.Pow(num,2);
            Console.Clear();
            Console.WriteLine("************************************");
            Console.WriteLine("A pot do num " + num.ToString("n2") + "é = " + aux.ToString("n2"));
            
        }
    }

}