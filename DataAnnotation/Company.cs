using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation
{
    public class Company
    {
        //[Key]
        //[Column(Order = 1)]
        [Key,Column(Order = 1)]
        public int IdCompany { get; set; }
        //[Required]
        //[Column(Order = 0)]
        [Required,Column(Order = 0)]
        public string? Name { get; set;}

    }
}
