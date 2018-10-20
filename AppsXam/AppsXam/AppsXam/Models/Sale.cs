using System;
using System.Collections.Generic;
using System.Text;

namespace AppsXam.Models
{
    class Sale
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long amount { get; set; }
        public int percentage { get; set; }
        public string deal { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
    }
}
