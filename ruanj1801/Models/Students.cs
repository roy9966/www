using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace ruanj1801.Models
{
    public partial class Students
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "ѧ������")]
        public string Name { get; set; }
        [Display(Name = "�༶ID")]
        public int? ClassId { get; set; }
    }
}
