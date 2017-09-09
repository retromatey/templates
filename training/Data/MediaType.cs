﻿using System;
using System.Collections.Generic;

namespace Training.Data
{
    public partial class MediaType
    {
        public MediaType()
        {
            Track = new HashSet<Track>();
        }

        public int MediaTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Track> Track { get; set; }
    }
}