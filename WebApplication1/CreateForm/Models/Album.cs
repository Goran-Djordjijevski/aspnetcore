using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateForm.Models
{
    public class Album
    {
        public int ID { get; set; }

        public string Artist { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }
    }
}
