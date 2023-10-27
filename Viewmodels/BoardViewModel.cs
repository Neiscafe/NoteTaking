using NoteTaking.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Viewmodels
{
    public class BoardViewModel: INotifyPropertyChanged
    {
        public BoardViewModel()
        {
            this.BoardCards = new()
            {
                new Card("Teste 1", "Teste 2", DateTime.Now),
                new Card("Teste 1", "Teste 2", DateTime.Now),
                new Card("Teste 1", "Teste 2", DateTime.Now),
                new Card("Teste 1", "Teste 2", DateTime.Now),
            };
        }
        public string BoardName { get; set; }   
        public ObservableCollection<Card> BoardCards { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
