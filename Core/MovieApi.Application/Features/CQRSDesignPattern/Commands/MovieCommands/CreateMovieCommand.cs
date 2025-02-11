using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class CreateMovieCommand
    {
        public required string MovieTitle { get; set; }
        public required string CoverImageUrl { get; set; }
        public decimal Rating { get; set; }
        public required string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public required string CreatedYear { get; set; }
        public bool Status { get; set; }
    }
}
