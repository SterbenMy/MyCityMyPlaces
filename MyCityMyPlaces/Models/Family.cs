using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    [Table("Family")]
    public class Family
    {
        [Key]
        public int idFamily { get; set; }
        
        [ForeignKey("User")]
        public int idUser { get; set; }
        public int idRelatedMember{ get; set; }
        public User User { get; set; }
        
        
        
        
    }
}