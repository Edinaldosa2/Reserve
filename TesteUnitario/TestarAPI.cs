using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace TesteUnitario
{
    internal class TestarAPI
    {
        private readonly HttpClient _httpClient;

        public TestarAPI()
        {
            _httpClient = new HttpClient();

        }

        [TestMethod]
        public async Task TestCovidApiSummary()
        {
            // URL da API
            string url = "https://dev.reserve.com.br/covid19api/summary";
            // Fazendo a requisição
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(response.IsSuccessStatusCode, "A API não retornou um status de sucesso.");

        }


        [TestMethod]
        public async Task TestCovidApiSummaryClass()
        {
            // URL da API
            string url = "https://dev.reserve.com.br/covid19api/summary";

            // Fazendo a requisição
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // Verificando se a resposta é bem-sucedida
            Assert.IsTrue(response.IsSuccessStatusCode, "A API não retornou um status de sucesso.");
        }


    }


}
