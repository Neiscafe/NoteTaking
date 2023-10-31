using NoteTaking.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaking
{
    public static class UnitOfWork
    {
        public static BoardRepository BoardRepository = new();
        public static CardRepository CardRepository= new();
    }
}
