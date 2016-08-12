using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Books
    {
        public int ID { get; set; }
        
        [StringLength(60,MinimumLength=3)]
        public string Title { get; set; }
        
        [Display(Name="Releasedate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true) ]
        public DateTime ReleaseDate { get; set; }
        
        [StringLength(30)]
        [Required]
        public string Genre { get; set; }

        [Range(1,50)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


        private int Qty { get; set; }

        public int qty
        {
            get
            {
                return Qty;
            }
            set
            {
                Qty = value;
            }
        }
    }
   public class Booksdbcontext : DbContext
   {
       public DbSet<Books> Bookss { get; set; }
   }
}