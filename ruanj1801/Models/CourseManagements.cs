namespace ruanj1801.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CourseManagements
    {
        public int Id { get; set; }
        [Display(Name = "�༶ID")]
        public int? ClassId { get; set; }
        [Display(Name = "�γ�ID")]
        public int? CourseId { get; set; }
        [Display(Name = "������ID")]
        public int? TeacherId { get; set; }
    }
}
