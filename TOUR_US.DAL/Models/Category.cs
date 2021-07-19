using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_US.DAL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(500)]
        public string Title { get; set; }

        [DataType(DataType.Text)]
        [StringLength(500)]
        public string Header { get; set; }


        [DataType(DataType.MultilineText)]
        [StringLength(2000)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]

        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }
        [Required]
        public ApplicationUser CreatedBy { get; set; }


        public virtual ICollection<CategoryImage> CategoryImages { get; set; }


    }
}
