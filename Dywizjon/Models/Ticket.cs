﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dywizjon.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string Type { get; set; }

        public Ticket()
        {

        }
    }
}