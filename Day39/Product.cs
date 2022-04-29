using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core2.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int PID { get; set; }
        public string ProdName { get; set; }

    }
}
