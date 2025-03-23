using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Controller.Entities
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; } = "NotEmail";
        public int BuyCount { get; set; } = 0;
        public ICollection<Selles> Selles { get; set; }

    }
}
