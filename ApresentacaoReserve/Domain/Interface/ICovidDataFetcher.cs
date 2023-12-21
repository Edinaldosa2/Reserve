namespace ApresentacaoReserve.Domain.Interface
{
    public interface ICovidDataFetcher
    {
        Task<IEnumerable<CovidCountryData>> FetchTop10CountriesWithActiveCases();
    }
}