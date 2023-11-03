using Grocerror.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocerror.DataAccess;

namespace Grocerror.Services
{
    public class ItemsSqlService : IItemRepository
    {
        private readonly ItemDBContext _context = new ItemDBContext();
        public List<Item> AllItems()
        {
            return _context.Items.ToList();
        }

        public Item SingleItem(int id)
        {
            return _context.Items.Find(id);
        }

    }
}
