﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entitites
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
    }
}
