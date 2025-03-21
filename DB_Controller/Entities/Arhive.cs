using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Controller.Entities
{
    public class Arhive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public string PublisherName { get; set; }
        public int SongCount { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public float CostPrice { get; set; }
    }
}
