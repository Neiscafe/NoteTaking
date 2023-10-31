using NoteTaking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Viewmodels
{
    public class CardViewModel : INotifyPropertyChanged
    {
        public CardViewModel(Card selectedCard)
        {
            this.SelectedCard = selectedCard;
        }
        public Card SelectedCard { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
