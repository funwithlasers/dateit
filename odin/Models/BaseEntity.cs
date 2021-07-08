using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace odin.Models
{
    //This class contains data that should be saved to the DB for (almost) all data types
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? LastUpdated { get; set; }

       // DateTime utcDate = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

    }
}
