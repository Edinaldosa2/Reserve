// Dentro de MyProject.Web.Controllers
using ApresentacaoReserve.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

public class CovidDataController : Controller
{
    private readonly ICovidDataFetcher covidDataFetcher;

    public CovidDataController(ICovidDataFetcher covidDataFetcher)
    {
        this.covidDataFetcher = covidDataFetcher;
    }

    public async Task<IActionResult> Top10ActiveCases()
    {
        var data = await covidDataFetcher.FetchTop10CountriesWithActiveCases();
        return View(data); 
    }

    public IActionResult Index()
    {
        return View();
    }
}
