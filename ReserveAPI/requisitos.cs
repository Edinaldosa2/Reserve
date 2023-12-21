using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System;

namespace ReserveAPI
{
    public class requisitos
    {


        //Apresentar em uma página os 10 países com mais casos de Covid-19 ativos(10 pontos)
        // * get dos valores e top10  -- OK

        // O número de casos ativos compreende a diferença entre o total de casos confirmados e o total de

        //casos recuperados(2 pontos)
        //
        //* apenas fazer o calculo casos ativos -- OK


        // A lista de países deve apresentar o nome do país, sua posição no ranking e o número de casos de Covid-19 ativos(3 pontos)



        //    "ID": "4205721d-64b3-4f69-a9de-92e03103b18d",
    //"Message": "",
    //"Global": {
    //    "NewConfirmed": 331934,
    //    "TotalConfirmed": 103274035,
    //    "NewDeaths": 6883,
    //    "TotalDeaths": 2236348,
    //    "NewRecovered": 155231,
    //    "TotalRecovered": 57306923,


         //"ID": "645be438-2609-4612-8333-dcc1529110c2",
         //   "Country": "Afghanistan",
         //   "CountryCode": "AF",
         //   "Slug": "afghanistan",
         //   "NewConfirmed": 0,
         //   "TotalConfirmed": 55059,
         //   "NewDeaths": 0,
         //   "TotalDeaths": 2404,
         //   "NewRecovered": 0,
         //   "TotalRecovered": 47723,
         //   "Date": "2021-02-02T20:47:39.621Z",
         //   "Premium": {}

        // A lista deve ser apresentada ordenada do maior número de casos para o menor(2 pontos) -- OK

        //Requisitos Técnicos(obrigatórios)
        // O desenvolvimento no backend deve utilizar ASP.NET
        //
        //, seja com.NET Framework ou Core (10 pontos)


        // A fonte de dados sobre Covid-19 deve ser a Covid19 API, disponível no endereço abaixo: (10 pontos)
        //https://dev.reserve.com.br/covid19api/summary

        //Requisitos Técnicos(opcionais)


        // Usar um framework javascript(Angular, React ou Vue), acessando uma Web API ASP.NET(10 pontos)

        //acessar o Diretório com JS.. + 10 



        // Aplicar no backend os princípios SOLID(2 pontos para cada princípio aplicado) --/50 
        // Implementar testes automatizados no backend(2 pontos para cada 25% de cobertura)
        // Implementar cache no servidor, com 1h de duração, para consulta da API(5 pontos)
        // Usar uma boa apresentação na UI(5 pontos)
        // Usar um pré-processador para minificar os recursos estáticos(5 pontos)
        // Usar o local storage no client para armazenar e apresentar os dados na tela(5 pontos)
        // Criar uma imagem docker para a aplicação web(10 pontos para imagem até 100MB, ou 5 pontos)
        // Versionar código-fonte no github(5 pontos)
    }
}
