namespace DesafioTarget.Desafios;

class Exec1
{
    public void Sequencia()
    {
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K++;
            SOMA += K;
        }

        Console.WriteLine($"Valor da Soma: {SOMA}");
    }
}
