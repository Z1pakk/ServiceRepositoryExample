using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(200)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        public DateTime DateCreate { get; set; }
    }
}
