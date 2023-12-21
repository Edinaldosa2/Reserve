// Dentro de MyProject.Web.Controllers
using ApresentacaoReserve.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

public class CovidDataController : Controller
{
    private readonly ICovidDataFetcher _covidDataFetcher;

    public CovidDataController(ICovidDataFetcher covidDataFetcher)
    {
        _covidDataFetcher = covidDataFetcher;
    }

    public async Task<IActionResult> Top10ActiveCases()
    {
        var data = await _covidDataFetcher.FetchTop10CountriesWithActiveCases();
        return View(data); 
    }
}
