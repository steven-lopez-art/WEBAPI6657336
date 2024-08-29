using WEBAPI6657336.Servicios;

namespace WEBAPI6657336
{
    public partial class MainPage : ContentPage
    {
        private readonly IRickAndMortyService _rickAndMortyService;

        public MainPage(IRickAndMortyService service)
        {
            InitializeComponent();
            _rickAndMortyService = service;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _rickAndMortyService.Obtener();
            listViewPersonajes.ItemsSource= data;

            loading.IsVisible = false;
        }
    }
}