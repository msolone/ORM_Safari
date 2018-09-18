using System;

namespace  ORM_Safari.Models
{
    public class SeenAnimals
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public int CountOfTimesSeen { get; set; }
        public string LocationOfLastSeen { get; set; }

        public DateTime LastSeenTime { get; set; }
    }
}