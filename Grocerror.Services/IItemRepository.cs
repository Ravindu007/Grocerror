using Grocerror.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocerror.Services
{
    public interface IItemRepository
    {
        public List<Item> AllItems();

        public Item SingleItem(int id);
    }
}
