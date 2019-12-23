
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ruanj1801.Models
{
    public partial class Courses
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "°à¼¶Ãû³Æ")]
        public string Name { get; set; }
    }
}
