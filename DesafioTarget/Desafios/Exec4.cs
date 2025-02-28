namespace DesafioTarget.Desafios;

internal class Exec4
{
    public void FaturamentoMensal()
    {
        var faturamentoEstados = new (string estado, double valor)[]
        {
            ("SP", 67836.43),
            ("RJ", 36678.66),
            ("MG", 29229.88),
            ("ES", 27165.48),
            ("Outros", 19849.53)
        };

        double faturamentoTotal = 0;
        foreach (var estado in faturamentoEstados)
        {
            faturamentoTotal += estado.valor;
        }

        Console.WriteLine("Percentual de representação de cada estado:\n");
        foreach (var estado in faturamentoEstados)
        {
            double percentual = (estado.valor / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.estado}: {percentual:F2}%");
        }
    }
}
