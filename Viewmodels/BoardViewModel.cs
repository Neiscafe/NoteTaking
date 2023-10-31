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
        public BoardViewModel(Board selectedBoard)
        {
            this.SelectedBoard = selectedBoard;
            BoardCards = UnitOfWork.CardRepository.GetCards(SelectedBoard.Id);
        }
        public Board SelectedBoard { get; set; }
        public string BoardName { get; set; }   
        public ObservableCollection<Card> BoardCards { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
