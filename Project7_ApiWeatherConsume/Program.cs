#region Menü_Başlangıcı

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Text;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz!");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir  ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-ID'ye Göre Şehir Getirme");
Console.WriteLine();

#endregion

string number;

Console.Write("Tercihiniz: ");
number = Console.ReadLine();
Console.WriteLine();

if (number == "1")
{
    string url = "https://localhost:7033/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach(var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir: {cityName}");
        }
    } 
}
if (number == "2")
{
    string url = "https://localhost:7033/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString();
            string country = item["country"].ToString();
            Console.WriteLine(cityName + "-" + country + "-->" + temp + " Derece");
            Console.WriteLine("---------------------");
        }
    }
}
if (number == "3")
{
    Console.WriteLine("### Yeni Veri Girişi");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;
    Console.Write("Şehir Adı:");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();

    Console.Write("Hava Durumu Detayı: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());


    string url = "https://localhost:7033/api/Weathers";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Temp = temp,
        Detail = detail
        
    };
    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json,Encoding.UTF8,"application/json");   
        HttpResponseMessage response = await client.PostAsync(url,content);
        response.EnsureSuccessStatusCode();
        
    }
}
if (number == "4")
{
    string url = "https://localhost:7033/api/Weathers?id=";
    Console.WriteLine("Silmek İstediğiniz Id Değeri:");
    int id = int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.DeleteAsync(url+id);
        response.EnsureSuccessStatusCode(); 
    }
}
if(number == "5")
{
    string url = "https://localhost:7033/api/Weathers";

    Console.WriteLine("### Veri Gücelleme İşlemi ###");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;
    int cityId;
    Console.Write("Şehir Adı:");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();

    Console.Write("Hava Durumu Detayı: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Şehir Id:");
    cityId = int.Parse(Console.ReadLine());

    var updateWeatherValues = new
    {
        CityId = cityId,
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(updateWeatherValues);
        StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
        HttpResponseMessage response = await client.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
}
if (number == "6")
{
    string url = "https://localhost:7033/api/Weathers/GetByIWeatherCity?id=";

    Console.WriteLine("Bilgilerini Getirmek İstediğiniz Id Değeri: ");
    int id = int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url + id);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject weatherCityObject = JObject.Parse(responseBody);

        string cityName = weatherCityObject["cityName"].ToString();
        string details = weatherCityObject["details"].ToString();
        string country = weatherCityObject["country"].ToString();
        decimal temp = decimal.Parse (weatherCityObject["temp"].ToString());

        Console.Write("Girmiş Olduğunuz Id Değerine Ait Bilgiler");
        Console.WriteLine();
        Console.WriteLine("Şehir: " +  cityName + " Ülke: " +  country + " Detay: " +  details + " Sıcaklık: " +  temp);



    } 



}
Console.Read();
