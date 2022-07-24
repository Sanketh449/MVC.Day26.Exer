using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Day26.Exer.Models
{
    public class BookStore
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Topic { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }

        //Auditable Column
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}