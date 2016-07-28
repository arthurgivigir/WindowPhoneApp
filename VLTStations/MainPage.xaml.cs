using ConsumindoServicos.Api;
using System.Collections.Generic;
using VLTStations.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace VLTStations
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private async void BtnRecuperaEstacoes(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var api = new DataRioApi();
            //var result = await api.GetData();
            var result = criarEstacoesFalsas();
            foreach (var item in result)
            {
                CbStations.Items.Add(item.estacao);
            }
        }

        private void BtnVerDetalhes(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var estacao = CbStations.SelectedItem;
            Frame.Navigate(typeof(StationDetail), estacao);
        }


        /**
         * Caso o serviço da prefeitura (Data.rio) esteja fora, usar este método 
         **/
        private List<Station> criarEstacoesFalsas()
        {
            var station = new Station();
            var stations = new List<Station>();

            station.estacao = "Estação Museu";
            station.latitude = "-17,77777";
            station.latitude = "-57,77777";
            stations.Add(station);

            station = new Station();
            station.estacao = "Estação Carioca";
            station.latitude = "-17,77777";
            station.latitude = "-57,77777";
            stations.Add(station);

            station = new Station();
            station.estacao = "Estação Cinelândia";
            station.latitude = "-17,77777";
            station.latitude = "-57,77777";
            stations.Add(station);

            return stations;
        }
    }
}
