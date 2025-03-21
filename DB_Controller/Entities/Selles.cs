using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Controller.Entities
{
    public class Selles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int AccountId {  get; set; }
        public Account Account { get; set; }
        public Artist Artist { get; set; }
        public string PublisherName { get; set; }
        public int SongCounts { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public float CostPrice { get; set; }
    }
}
