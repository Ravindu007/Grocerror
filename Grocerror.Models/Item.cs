using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocerror.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int ListId { get; set; }
        public string ItemName { get; set; }

        public DateTime Date { get; set; }

        public ItemStatus Status { get; set; }
    }
}
