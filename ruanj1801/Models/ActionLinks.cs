namespace ruanj1801.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ActionLinks
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "����")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "������")]
        public string Controller { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "����")]
        public string Action { get; set; }
    }
}
