using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Models
{
   public class Book
    {
        public int Id { get; set; }
        private protected int Name { get; set; }
        protected internal int Author { get; set; }
    }
}
