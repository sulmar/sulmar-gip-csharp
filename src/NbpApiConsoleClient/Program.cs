
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;

const string format = "json";
const string table = "A";
string currencyCode = "EUR";

string baseUrl = "https://api.nbp.pl";
string url = $"/api/exchangerates/rates/{table}/{currencyCode}?format={format}";

// Process.Start("notepad.exe"); 

HttpClient nbpClient = new HttpClient();
nbpClient.BaseAddress = new Uri(baseUrl);

// Programowanie asynchroniczne
// string content = await nbpClient.GetStringAsync(url);

ExchangeRate exchangeRate = await nbpClient.GetFromJsonAsync<ExchangeRate>(url);

Console.WriteLine($"{exchangeRate.Currency} {exchangeRate.Rates[0].Mid}");

WebClient webClient = new WebClient();
string content = webClient.DownloadString($"{baseUrl}{url}");
Console.WriteLine(content);

class ExchangeRate
{
    public string Table { get; set; }
    public string Currency { get; set; }
    public string Code { get; set; }
    public Rate[] Rates { get; set; }
}

class Rate
{
    public string No { get; set; }
    public DateTime EffectiveDate { get; set; }
    public decimal Mid { get; set; }
}

