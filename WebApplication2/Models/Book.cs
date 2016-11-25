using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }

        public string Genre { get; set; }

        public int AuthorID { get; set; }
        //public virtual Author Author { get; set; }
    }
}