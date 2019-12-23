using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ruanj1801.Models
{
    public partial class CourseManagements
    {
        [Display(Name = "班级")]
        public string ClassName
        {
            get
            {
                if (!ClassId.HasValue)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var classes = db.Classes.Where(t => t.Id == ClassId.Value).FirstOrDefault();
                if (classes == null)
                {
                    return "";
                }
                return classes.Name;
            }
        }
        [Display(Name = "课程")]
        public string CourseName
        {
            get
            {
                if (!CourseId.HasValue)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var course = db.Courses.Where(t => t.Id == CourseId.Value).FirstOrDefault();
                if (course == null)
                {
                    return "";
                }
                return course.Name;
            }
        }
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