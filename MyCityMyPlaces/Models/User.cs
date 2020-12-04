using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    [Table("User")]
    public class User
    {
        public User()
        {
            Locations=new List<Location>();
        }

        [Key] 
        public int idUser { get; set; }
        
        public string name { get; set; }
        [Required]  
        public string mail { get; set; }
        
        public IList<Location> Locations{ get; set; }
        public IList<Family> Families{ get; set; }
    }
}