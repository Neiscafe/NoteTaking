using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Models
{
    public class Board
    {
        public Board(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Board()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
