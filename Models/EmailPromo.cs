﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingApplication.Models
{
    public class EmailPromo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
