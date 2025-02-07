using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entitites
{
    public class Cast
    {
        public int CastId { get; set; }
        public required string Title { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string ImageUrl { get; set; }
        public string? Overivew { get; set; }
        public string? Biography { get; set; }
    }
}
