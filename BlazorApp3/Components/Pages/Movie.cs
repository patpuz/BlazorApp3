using System.Collections.Generic;

namespace BlazorApp3.Components.Pages
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Rating> Ratings { get; } = new List<Rating>();
    }
}
