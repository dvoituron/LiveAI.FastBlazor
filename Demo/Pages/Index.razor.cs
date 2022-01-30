using LiveAI.FastBlazor.Demo.Data;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Demo.Pages
{
    public partial class Index
    {
        [Inject]
        public WeatherForecastService? ForecastService { get; set; }

        public WeatherForecast[]? Forecasts { get; set; }

        public string ConsoleContent { get; set; } = "";

        public void AddTrace(string text)
        {
            ConsoleContent = $"{DateTime.Now:HH:mm:ss} - {text}{Environment.NewLine}{ConsoleContent}";            
        }

        protected async override Task OnInitializedAsync()
        {
            Forecasts = await ForecastService!.GetForecastAsync(DateTime.Now);
        }
    }
}
