using System;

namespace StockTask.Domain.Models
{
    public class SoldItem:TableDomainObject
    {
        public string Name { get; set; }
        public DateTime SoldDate { get; private set; }
        public SoldItem()
        {
            SoldDate = DateTime.Now;
        }
    }
}
