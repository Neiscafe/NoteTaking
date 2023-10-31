using NoteTaking.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Repositories
{
    public class BoardRepository
    {
        public BoardRepository()
        {
            
        }
        
        public ObservableCollection<Board> GetBoards()
        {
            return new ObservableCollection<Board>()
            {
                new Board (1, "asdasdasd"),
                new Board (2, "asdasdasd"),
                new Board (3, "asdasdasd"),
                new Board (4, "asdasdasd"),
            };
        }
    }
}
