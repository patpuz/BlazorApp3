﻿using System.Reflection.Metadata;
using System.Collections.Generic;

namespace BlazorApp3.Components.Pages
{
    public class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}

