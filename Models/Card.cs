using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Models
{
    public class Card
    {
        public Card(string name, string description, DateTime CreationDate)
        {
            this.Name = name;
            this.Description = description;
            this.CreationDate = CreationDate;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
