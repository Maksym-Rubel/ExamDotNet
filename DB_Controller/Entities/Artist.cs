﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Controller.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Listers { get; set; } = 0;

        public ICollection<Record> Records { get; set; }
        public ICollection<Selles> Selles { get; set; }


    }
}
