﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FirmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
    }
}
