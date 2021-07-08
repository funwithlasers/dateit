using System;

namespace odin.Models
{
    public class ActivityCard : BaseEntity
    {
        public string Category { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; } //in minutes

        public string Location { get; set; }

        //Add dictionary with flags for additional markers <String, Bool>
        //Price, in/out, 
    }
}
