﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoSabahSabah.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<Note> Notes { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} ";
        }
    }
}
