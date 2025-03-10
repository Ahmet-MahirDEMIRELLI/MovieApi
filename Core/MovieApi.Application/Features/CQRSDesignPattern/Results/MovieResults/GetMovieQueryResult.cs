﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults
{
    public class GetMovieQueryResult
    {
        public int MovieId { get; set; }
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
