using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace ruanj1801.Models
{
    

    public partial class SideBars
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "名称")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "控制器")]
        public string Controller { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "功能")]
        public string Action { get; set; }
    }
}
