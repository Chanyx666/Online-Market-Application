using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Market_Application.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}