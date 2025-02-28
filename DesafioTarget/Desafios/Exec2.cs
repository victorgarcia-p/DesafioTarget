using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesafioTarget.Desafios;

class Exec2
{
    static bool Fibonacci(int numero)
    {
        int a = 0;
        int b = 1; 
        int temp = 0;

        while (a <= numero)
        {
            if (a == numero) return true;
            temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }

    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (Fibonacci(numero))
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
    }
}
