using MVC.Day26.Exer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Day26.Exer.Controllers
{
    public class BookStoreController : Controller
    {
        // GET: BookStore
          public ActionResult Books()
            {
                var BookStore = GetBookDetails();
                return View(BookStore);//return list of product
            }

            //Data for Product Class
            public List<BookStore> GetBookDetails()
            {
                return new List<BookStore>
            {
                new BookStore { BookId=1, BookName="Inside World", Topic="Politics", Price=180, Quantity=4},
                new BookStore { BookId=2, BookName="Think Straight", Topic="Controlling our brain", Price=220, Quantity=2},
                new BookStore { BookId=3, BookName="Rich Dad Poor Dad", Topic="Money & Life", Price=130, Quantity=2},
                new BookStore { BookId=4, BookName="Out of the Box", Topic="Unexpected", Price=125, Quantity=1},
            };
            
        }
    }
}