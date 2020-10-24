using System;

namespace StockTask.Domain.Models
{
    public class SoldItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SoldDate
        {
            get { return SoldDate; }
            set { SoldDate = DateTime.Now; }
        }
    }
}
