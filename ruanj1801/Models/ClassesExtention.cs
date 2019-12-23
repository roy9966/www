using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ruanj1801.Models
{
    public partial class Classes
    {
        //private int t;
        [Display(Name = "班主任")]
        public string TeacherName
        {
            get
            {
                if (!TeacherId.HasValue)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var teacher = db.Teacher.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}