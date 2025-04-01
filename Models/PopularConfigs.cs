using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VroomWiki.Models
{
    public class PopularConfigs
    {
        [Key]
        public required int Id { get; set; }

        [StringLength(50)]
        public required string? ConfigName { get; set; }

        [ForeignKey("ConfigEngine")]
        public required int Engine_Id { get; set; }
        public required ConfigEngine ConfigEngine { get; set; }


        [ForeignKey("ConfigColor")]
        public required int Color_Id { get; set; }
        public required ConfigColor ConfigColor { get; set; }


        [ForeignKey("ConfigTransmissionType")]
        public required int TransmissionType_Id { get; set; }
        public required ConfigTransmissionType ConfigTransmissionType { get; set; }
        public int Price { get; set; }
        public string? ImageBase64 { get; set; }
    }
}
