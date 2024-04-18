using LastDanceMAUI.Manager;
using LastDanceMAUI.Model;
using System.Collections.ObjectModel;

namespace LastDanceMAUI.Pages;

public partial class LocationPage : ContentPage
{
    //public ObservableCollection<RecordLocation> Location { get; set; } = new();
    public RecordLocation Location { get; set; }

    public bool IsLoading { get; set; }

    public LocationPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        IsLoading = true;
        OnPropertyChanged(nameof(IsLoading));

        await LoadLocation();

        IsLoading = false;
        OnPropertyChanged(nameof(IsLoading));
    }

    public async Task LoadLocation()
    {
        //Location.Clear();

        //var recordLocation = await NetworkManager.Instance.GetLocationFromJsonAsync();
        //Location.Add(recordLocation);

        Location = await NetworkManager.Instance.GetLocationFromJsonAsync();
        OnPropertyChanged(nameof(Location));

    }
}