using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using ApresentacaoReserve.Domain.Interface;

public class CovidDataFetcher : ICovidDataFetcher
{
    private readonly HttpClient _httpClient;

    public CovidDataFetcher()
    {
        _httpClient = new HttpClient();
    }

    public async Task<IEnumerable<CovidCountryData>> FetchTop10CountriesWithActiveCases()
    {
        string url = "https://dev.reserve.com.br/covid19api/summary";
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        string content = await response.Content.ReadAsStringAsync();

        var data = JObject.Parse(content);
        var countries = data["Countries"]
            .Select(c => new CovidCountryData
            {
                Name = c["Country"].ToString(),
                ActiveCases = (int)c["TotalConfirmed"] - (int)c["TotalRecovered"],
                Rank = 0 // Rank inicializado como 0, será atribuído posteriormente
            })
            .OrderByDescending(c => c.ActiveCases)
            .Take(10)
            .ToList();

        // Atribuindo o ranking após a ordenação
        int rank = 1;
        foreach (var country in countries)
        {
            country.Rank = rank++;
        }

        return countries;
    }
}

public class CovidCountryData
{
    public string Name { get; set; }
    public int ActiveCases { get; set; }
    public int Rank { get; set; }
}
