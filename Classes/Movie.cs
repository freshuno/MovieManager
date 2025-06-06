﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Movie_Manager.Classes
{
    public class Movie
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Rated { get; set; }
        [JsonPropertyName("Released")]
        public string? ReleasedRaw { get; set; }

        [JsonIgnore]
        public DateTime? Released { get; set; }
        public string? Runtime { get; set; }
        public string? Genre { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public string? Actors { get; set; }
        public string? Plot { get; set; }
        public string? Language { get; set; }
        public string? Country { get; set; }
        public string? Awards { get; set; }
        public string? Poster { get; set; }
        public List<OmdbRating> Ratings { get; set; }
        public string? Metascore { get; set; }
        public string? imdbRating { get; set; }
        public string? imdbVotes { get; set; }
        public string? imdbID { get; set; }
        public string? Type { get; set; }
        public string? DVD { get; set; }
        public string? BoxOffice { get; set; }
        public string? Production { get; set; }
        public string? Website { get; set; }
        [JsonPropertyName("totalSeasons")]
        public string? totalSeasonsRaw { get; set; }
        [JsonIgnore]
        public int? totalSeasons { get; set; }
        public string? Response { get; set; }
        public bool Watched { get; set; } = false;
    }

    public class OmdbRating
    {
        public string Source { get; set; }
        public string Value { get; set; }
    }
}
