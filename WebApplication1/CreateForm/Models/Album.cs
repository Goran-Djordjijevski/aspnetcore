using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreateForm.Models
{
    public class Album
    {
        public int ID { get; set; }

        public string Artist { get; set; }

        [Required]
        [StringLength(maximumLength: 60, MinimumLength = 3)]
        public string Name { get; set; }
        
        public string Genre { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(minimum: 0, maximum: 100.00)]
        public decimal Price { get; set; }

        public int Rank { get; set; }
    }
}
