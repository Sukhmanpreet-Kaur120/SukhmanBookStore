using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SukhmanBookStore.Models.ViewModels
{
    public class Category
    {
        [Key]

        public int Id { get; set; }

        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
