using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Verao.Models;

namespace Verao.ViewsModels
{
    class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Praia> Praias { get; }

        public HomeViewModel()
        {
            Praias = new ObservableCollection<Praia>
            {
                new Praia { Id = 1, Nome = "Marataizes", Imagem = "marataizes.jpg" },
                new Praia { Id = 1, Nome = "Kenedy", Imagem = "kenedy.jpg" },
                new Praia { Id = 1, Nome = "Itapemirim", Imagem = "itapemirim.jpg" }
            };
            OnPropertyChanged(nameof(Praias));
        }
    }
}
