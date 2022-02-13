using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProdReview.Shared.Domain
{
    public class Store
    {
        public int Id { get; set; }
        [Required]
        public string StoreName { get; set; }
        [Required]
        public int StoreLeft { get; set; }
        [Required]
        public int StoreRating { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

    }
}
