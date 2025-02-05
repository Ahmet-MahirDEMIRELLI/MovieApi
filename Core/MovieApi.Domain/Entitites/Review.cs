using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entitites
{
    public class Review
    {
        public int ReviewId { get; set; }
        public required string ReviewComment { get; set; }
        public int UserRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool Status { get; set; }
    }
}
