using ApresentacaoReserve.Domain.Interface;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ApresentacaoReserve.Domain.Infraestrutura
{
    public class CovidDataFetcher : ICovidDataFetcher
    {
        private readonly HttpClient _httpClient;

         public CovidDataFetcher()
    {
        _httpClient = new HttpClient();
    }


        public async Task FetchTop10CountriesWithActiveCases()
        {
            string url = "https://dev.reserve.com.br/covid19api/summary";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();

            var data = JObject.Parse(content);
            var countries = data["Countries"]
                .Select(c => new
                {
                    Name = c["Country"].ToString(),
                    ActiveCases = (int)c["TotalConfirmed"] - (int)c["TotalRecovered"]
                })
                .OrderByDescending(c => c.ActiveCases)
                .Take(10);

            int rank = 1;
            foreach (var country in countries)
            {
                Console.WriteLine($"{rank}. {country.Name} - Casos ativos: {country.ActiveCases}");
                rank++;
            }
        }
    }
}


