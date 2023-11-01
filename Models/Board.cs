using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Models
{
    public class Board
    {
        public Board(int id, string name, List<Card> cards)
        {
            this.Id = id;
            this.Name = name;
            this.Cards = cards;
        }
        public Board(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Cards = new();
        }
        public Board()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
