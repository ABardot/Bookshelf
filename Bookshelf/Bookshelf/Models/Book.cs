using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public int BookNunber { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Catagory { get; set; }
    }
}