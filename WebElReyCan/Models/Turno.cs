using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        public int ID { get; set; }

        [Column(TypeName ="Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(5)]
        public string Hour { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string PetName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string  Breed { get; set; }

        [Column(TypeName = "int")]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string OwnerName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string CellNumber { get; set; }
    }
}