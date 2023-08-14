using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation
{
    [Table("Mobile")]
    public class Phone
    {
        [Key]
        public int IdMobile { get; set; }

        [Column("Title",TypeName ="varchar")]
        [Required,MaxLength(20)]
        public string? Name { get; set; }
        [Range(1,8000)]
        public int Price { get; set; }
        [NotMapped]
        public int Discount { get; set; }

        public int idCompany { get; set; }
        [ForeignKey("idCompany")]

        public Company Company { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }    
    }
}
