﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocerror.Models;

namespace Grocerror.Services
{
    public class ItemService
    {
        public List<Item> AllItems() //provides all items
        {
            var items = new List<Item>();

            var item1 = new Item
            {
                Id = 1,
                ListId = 1,
                ItemName = "Test",
                Date = DateTime.Now,
                Status = ItemStatus.Got
            };
            items.Add(item1);   

            return items ;

        }
    }
}