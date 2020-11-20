using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;
            
            Console.Write("Digite o número da tabuada de multiplicação desejada: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int x = 1; x <= 10; x++)
            {
                resultado = numero * x;
                //concatenar o número digitado, multiplicador e resultado add sinais "x" E "="
                Console.WriteLine($"{numero}"+"x"+x+ " = "+ resultado);
            }
            Console.WriteLine();
            Console.WriteLine("Obrigado por utilizar nossa tabuada");
        }
    }
}
