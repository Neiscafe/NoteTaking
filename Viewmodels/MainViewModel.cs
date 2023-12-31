﻿using NoteTaking.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Viewmodels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Boards = new ObservableCollection<Board>(UnitOfWork.BoardRepository.GetBoards());
        }

        public ObservableCollection<Board> Boards { get; set; }
        public Board SelectedBoard { get; set; }
        public Card SelectedCard { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
