using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project13_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city?city=kars&lang=EN"),
                Headers =
    {
        { "x-rapidapi-key", "20cde4e231mshb048c858e0189c1p14c17ejsn79fcafcfb41a" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var fahrenheit = json["main"] ["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                lblFahrenheit.Text = fahrenheit;
                lblWindSpeed.Text = windSpeed;
                lblHumidity.Text = "%" +  humidity;
                double celsius = (double.Parse (fahrenheit) - 32) ;
                double celciusValue = celsius / 1.8;
                lblCelcius.Text = celciusValue.ToString("0.00");

                var weather = json["weather"][0]["main"].ToString();

                string imagePath = @"D:\C#\20 Tane C# Projesi\My20Projects\Project13_WeatherApp\İmages";
                string imageFile = "";

                switch (weather)
                {
                    case "Clouds":
                        imageFile = "clouds.png";
                        break;

                    case "PartlyCloudy":
                        imageFile = "PartlyCloudy.png";
                        break;

                    case "Rain":
                        imageFile = "Rainy.png";
                        break;

                    case "Snow":
                        imageFile = "Snow.png";
                        break;

                    case "Sun":
                        imageFile = "Sunny.png";
                        break;

                    default:
                        imageFile = "Snow.png";
                        break;
                }

                string fullImagePath = Path.Combine(imagePath, imageFile);
                pictureBox1.Image = Image.FromFile(fullImagePath);
            }
        }
    }
}
