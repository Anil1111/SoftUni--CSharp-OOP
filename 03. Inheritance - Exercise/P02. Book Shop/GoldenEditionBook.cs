﻿namespace P2.BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) 
            : base(author, title, price)
        {
        }

        protected override decimal Price
        {
            
            set
            {
                base.Price = value * 1.3m;
            }
        }
    }
}
