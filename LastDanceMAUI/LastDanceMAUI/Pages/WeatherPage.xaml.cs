using LastDanceMAUI.Manager;
using LastDanceMAUI.Model;
using System.Collections.ObjectModel;

namespace LastDanceMAUI.Pages;

public partial class WeatherPage : ContentPage
{
	public ObservableCollection<Daily> Weathers { get; set; } = new();
    public bool IsLoading { get; set; }

    public WeatherPage()
	{
		BindingContext = this;
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        IsLoading = true;
        OnPropertyChanged(nameof(IsLoading));

        await LoadWheathers();

        IsLoading = false;
        OnPropertyChanged(nameof(IsLoading));
    }

    public async Task LoadWheathers()
    {
        Weathers.Clear();

        var recordWeather = await NetworkManager.Instance.GetWeatherFromJsonAsync();


        foreach (var weather in recordWeather)
        {
            Weathers.Add(weather);
            if (weather.time.Date == DateTime.Today)
            {
                weather.todayStatus = weather.status;
            }
        }
        
    }
}