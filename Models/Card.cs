using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Models
{
    public class Card
    {
        public Card(int id, string name, string description, DateTime CreationDate, int boardId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CreationDate = CreationDate;
            this.BoardId = boardId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int BoardId { get; set; }
    }
}
