using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TOUR_US.DAL.Models
{
   public class ApplicationUser:IdentityUser
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "Please do not exceed 200 characters!")]
        public string Name { get; set; }

        [DataType(DataType.ImageUrl)]
        [StringLength(300)]
        public string ImageUrl { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }
}
