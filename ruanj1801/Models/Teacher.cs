using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace ruanj1801.Models
{
    [Table("Teacher")]
    public partial class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "°àÖ÷ÈÎ")]
        public string Name { get; set; }
    }
}
