using NoteTaking.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Viewmodels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
        }

        public ObservableCollection<Board> Boards { get; set; } = UnitOfWork.BoardRepository.GetBoards();
    }
}
