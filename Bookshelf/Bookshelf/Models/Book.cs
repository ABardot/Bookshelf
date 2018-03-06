using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")] // Set up the foreign key for relationship. Each Model has it own key
        public int CategoryID { get; set; } 
        public virtual Category Category { get; set; } // A navigation property with one category 
    }
}