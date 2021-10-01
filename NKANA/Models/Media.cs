﻿using System.Collections.Generic;

namespace NKANA.Models
{
    public class Media
    {
        public long Id { get; set; }
        public string MediaType { get; set; }
        public string MediaUrl { get; set; }
        public ICollection<ArtWorkMedia> ArtWorkMedias { get; set; }
    }
}