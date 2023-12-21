using NUnit.Framework;
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


        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public async Task TestCovidApiSummary()
        {
            // URL da API
            string url = "https://dev.reserve.com.br/covid19api/summary";

            // Fazendo a requisição
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // Verificando se a resposta é bem-sucedida
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(response.IsSuccessStatusCode, "A API não retornou um status de sucesso.");

            // Opcional: Verifique a estrutura dos dados aqui



            string responseData = await response.Content.ReadAsStringAsync();
           // Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(VerificarEstruturaDosDados(responseData), "A estrutura dos dados não está correta.");
        }


    }


}
