using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Verao.Models;
using Verao.Views.Informacoes;
using Xamarin.Forms;

namespace Verao.ViewsModels
{
    class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Praia> Praias { get; }
        public Command<Praia> PraiaTapped { get; set; }
        public HomeViewModel()
        {
            Praias = new ObservableCollection<Praia>
            {
                new Praia { Id = 1, Nome = "Marataizes", Imagem = "marataizes.jpg" },
                new Praia { Id = 1, Nome = "Kenedy", Imagem = "kenedy.jpg" },
                new Praia { Id = 1, Nome = "Itapemirim", Imagem = "itapemirim.jpg" }
            };
            OnPropertyChanged(nameof(Praias));

            PraiaTapped = new Command<Praia>(CarregaDados);
        }

        private async void CarregaDados(Praia praia)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InformacoesViews());
        }
    }
}
