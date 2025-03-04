using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Configuration
    {
        [Key]
        public required int Id { get; set; }

        [ForeignKey("User")]
        public required int User_Id { get; set; }
        
       

        [StringLength(50)]
        public required string? ConfigName { get; set; }

        [ForeignKey("ConfigEngine")]
        public required int Engine_Id { get; set; }
       
       
        [ForeignKey("ConfigColor")]
        public required int Color_Id { get; set; }
        
      
        [ForeignKey("ConfigTransmissionType")]
        public required int TransmissionType_Id { get; set; }
        
    } 
}
