//Metodo buscar covid

async function FetchCovidData()
{

    try {
        //URL da API
        const response = await fetch('https://dev.reserve.com.br/covid19api/summary');
        const data = await response.json();
        return data.map(Country => ({
            name: Country.Country,
            ActiveCases: Country.cases - Country.recovered
        })); 
    } catch (error) {
        'fazer algo'
    }

}

// modelo pronto :

function displayTop10Countries(countries) {
    countries.sort((a, b) => b.activeCases - a.activeCases);
    const top10 = countries.slice(0, 10);

    let html = '<ol>';
    top10.forEach((country, index) => {
        html += `<li>${index + 1}. ${country.name} - Casos ativos: ${country.activeCases.toLocaleString()}</li>`;
    });
    html += '</ol>';

    document.getElementById('covidTop10').innerHTML = html;
}

async function main() {
    const countries = await fetchCovidData();
    if (countries) {
        displayTop10Countries(countries);
    }
}

main();