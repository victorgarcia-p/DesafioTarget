namespace DesafioTarget.Desafios;

internal class Exec5
{
    public void InverterString()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string input = Console.ReadLine();

        char[] caracteres = input.ToCharArray();

        int inicio = 0;
        int fim = input.Length - 1;

        while (inicio < fim)
        {
            (caracteres[inicio], caracteres[fim]) = (caracteres[fim], caracteres[inicio]);

            inicio++;
            fim--;
        }

        Console.WriteLine($"String invertida: {caracteres}");
    }
}
