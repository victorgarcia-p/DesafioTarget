using DesafioTarget.Suporte;
using Newtonsoft.Json;

namespace DesafioTarget.Desafios;

class Exec3
{
    public void VerificarDadosFaturamento()
    {
        var faturamento = CarregarDadosFaturamento();

        var diasUteis = faturamento.Where(f => f.Valor > 0).ToList();
        var menor = diasUteis.Min(f => f.Valor);
        var maior = diasUteis.Max(f => f.Valor);
        var media = diasUteis.Any() ? diasUteis.Average(f => f.Valor) : 0;
        int diasAcimaMedia = diasUteis.Count(f => f.Valor > media);

        Console.WriteLine($"Menor faturamento diário: {menor:C}");
        Console.WriteLine($"Maior faturamento diário: {maior:C}");
        Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
    }

    static List<DadosFaturamento> CarregarDadosFaturamento()
	{
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string jsonPath = Path.Combine(basePath, "..", "..", "..", "Suporte", "dados.json");

        if (!File.Exists(jsonPath))
		{
			throw new FileNotFoundException("Arquivo de dados não encontrado!");
		}

		string json = File.ReadAllText(jsonPath);
		return JsonConvert.DeserializeObject<List<DadosFaturamento>>(json);
	}

}
