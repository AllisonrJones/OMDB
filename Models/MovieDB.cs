using System;
namespace OMDB.Models
{
	
        public class MovieDB
        {
            public string Title { get; set; }
            public long Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Awards { get; set; }
            public Uri Poster { get; set; }

    }

        public partial class Rating
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }
    
}

