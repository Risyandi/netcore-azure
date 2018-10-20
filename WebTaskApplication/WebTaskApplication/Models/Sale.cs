using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTaskApplication.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int Percentage { get; set; }
        public string Deal { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
    }
}
