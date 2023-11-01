using NoteTaking.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking.Repositories
{
    public class CardRepository
    {
        public List<Card> GetCards()
        {
            return new List<Card>
            {
                new Card(1, "Teste 1", "Teste 2", DateTime.Now, 1),
                new Card(2, "Teste 1", "Teste 2", DateTime.Now, 1),
                new Card(3, "Teste 1", "Teste 2", DateTime.Now, 2),
                new Card(4, "Teste 1", "Teste 2", DateTime.Now, 3),
            };
        }
    }
}
