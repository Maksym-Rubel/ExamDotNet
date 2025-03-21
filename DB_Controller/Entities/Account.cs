using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Controller.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Selles> Selles { get; set; }
    }
}
