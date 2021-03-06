using System;
using System.Collections.Generic;
using DatingApp_API.Models;

namespace DatingApp_API.Dtos
{
    public class UserForDetailsDto
    {
                public int Id { get; set; }

        public string Username { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string KnowAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }
        
        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests {get; set;}

        public string City {get; set;}

        public string Contry {get; set;}

        public string PhotoUrl { get; set; }

        public ICollection<PhotosFroDetailedDto> Photos { get; set; }
    }
}