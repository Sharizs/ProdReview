using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProdReview.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
      
        public string ReviewTitle { get; set; }
        [Required]

        public string ProductName { get; set;  }
        [Required]

        public string ReviewDescrip { get; set; }
        [Required]

        public int ReviewRating { get; set; }
        
        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

    }
}



