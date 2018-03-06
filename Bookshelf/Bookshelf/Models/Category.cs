using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {   [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; } // Many books for category 
    }
}