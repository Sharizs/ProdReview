using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProdReview.Shared.Domain
{
   public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserRole { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

    }
}
