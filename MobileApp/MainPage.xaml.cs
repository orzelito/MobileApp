using MobileApp.Services;

namespace MobileApp;

public partial class MainPage : ContentPage
{
	private readonly ApiService _apiService;

	public MainPage()
	{
		InitializeComponent();
		_apiService = new ApiService();
	}

	private async void OnRefreshClicked(object sender, EventArgs e)
	{
		var orders = await _apiService.GetOrders();
		OrdersList.ItemsSource = orders;
	}
}
