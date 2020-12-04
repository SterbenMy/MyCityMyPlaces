using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    public class Location
    {
        [Key]
        public int idLocation { get; set; }
        [Required]
        [Column(TypeName = "decimal(8,6)")]
        public decimal coordinateX { get; set; }
        [Required]  
        [Column(TypeName = "decimal(8,6)")]
        public decimal coordinateY { get; set; }
        
        public string comment { get; set; }
        
        public string locationName { get; set; }
        [Required] 
        public bool visible { get; set; } = false;
        
        [ForeignKey("User")]
        public int idUser { get; set; }
        public User User { get; set; }

    }
}