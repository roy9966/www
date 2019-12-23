using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace ruanj1801.Models
{

    public partial class Classes
    {
        public int Id { get; set; }

        [Required(ErrorMessage="请填写班级名称")]
        [StringLength(20,MinimumLength = 2, ErrorMessage = "班级名称至少包含2个字符")]
        [Display(Name="班级名称")]
        public string Name { get; set; }
        [Display(Name = "班主任ID")]
        public int? TeacherId { get; set; }
    }
}
