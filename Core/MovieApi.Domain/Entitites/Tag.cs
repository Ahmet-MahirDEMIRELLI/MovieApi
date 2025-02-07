using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entitites
{
    public class Tag
    {
        public int TagId { get; set; }
        public required string Title { get; set; }
    }
}
