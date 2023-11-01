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

        public List<Board> GetBoards()
        {
            List<Board> boards = new()
            {
                new Board (1, "asdasdasd"),
                new Board (2, "asdasdasd"),
                new Board (3, "asdasdasd"),
                new Board (4, "asdasdasd"),
            };
            List<Card> cards = UnitOfWork.CardRepository.GetCards();
            foreach (Board board in boards)
                board.Cards = cards.Where(card => card.BoardId == board.Id).ToList();
            return boards;
        }
    }
}
