using System;
using DesafioTarget.Desafios;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Exercícios...");

        Console.WriteLine("\nExercício 1:");
        Exec1 exec1 = new Exec1();
        exec1.Sequencia();

        Console.WriteLine("\nExercício 2:");
        Exec2 exec2 = new Exec2();
        exec2.Fibonacci();

        Console.WriteLine("\nExercício 3:");
        Exec3 exec3 = new Exec3();
        exec3.VerificarDadosFaturamento();

        Console.WriteLine("\nExercício 4:");
        Exec4 exec4 = new Exec4();
        exec4.FaturamentoMensal();

        Console.WriteLine("\nExercício 5:");
        Exec5 exec5 = new Exec5();
        exec5.InverterString();

        Console.WriteLine("Execução finalizada.");
    }
}
