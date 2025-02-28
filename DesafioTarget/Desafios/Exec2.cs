namespace DesafioTarget.Desafios;

class Exec2
{
    public void Fibonacci()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (VerificaFibonacci(numero))
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
    }

    static bool VerificaFibonacci(int numero)
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

    
}
