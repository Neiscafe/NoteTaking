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
        public ObservableCollection<Card> GetCards(int boardId)
        {
            return new ObservableCollection<Card>
            {
                new Card("Teste 1", "Teste 2", DateTime.Now),
                new Card("Teste 1", "Teste 2", DateTime.Now),
                new Card("Teste 1", "Teste 2", DateTime.Now),
                new Card("Teste 1", "Teste 2", DateTime.Now),
            };
        }
    }
}
