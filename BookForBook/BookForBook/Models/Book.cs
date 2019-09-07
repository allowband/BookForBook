using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookForBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Artist { get; set; }
        [Display(Name = "Release Date")]
        [Column(TypeName = "datetime2")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}