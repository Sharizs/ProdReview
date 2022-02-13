using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProdReview.Shared.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public int BrandRating { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }
    }
}
