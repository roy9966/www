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

        [Required(ErrorMessage="����д�༶����")]
        [StringLength(20,MinimumLength = 2, ErrorMessage = "�༶�������ٰ���2���ַ�")]
        [Display(Name="�༶����")]
        public string Name { get; set; }
        [Display(Name = "������ID")]
        public int? TeacherId { get; set; }
    }
}
