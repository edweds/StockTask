using System;

namespace StockTask.Domain.Models
{
    public class CreatedItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReceivingDate
        {
            get { return ReceivingDate; }
            set { ReceivingDate = DateTime.Now; }
        }
    }
}
