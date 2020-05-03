using System;

namespace DatingApp_API.Dtos
{
    public class PhotosFroDetailedDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set;}

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set;}
    }
}