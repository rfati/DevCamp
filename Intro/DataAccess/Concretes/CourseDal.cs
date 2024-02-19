using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concrate
{

    public class CourseDal:ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            courses = new List<Course>() { new Course { Name="Kurs1",Id=1,Description="Açıklama1",InstructorId=1,CategoryId=1},
            new Course { Name="Kurs2",Id=2,Description="Açıklama2",InstructorId=2,CategoryId=2 } };

        }
        public void Insert(Course course)
        {
            //DB İşlemleri
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            //DB İşlemleri
            var deletedCourse = courses.First(c => c.Id == course.Id);
            courses.Remove(deletedCourse);
        }

        public Course GetById(int id)
        {
            //DB İşlemleri
            return courses.First(course => course.Id == id); ;
        }

        public List<Course> List()
        {   //DB İşlemleri
            return courses;
        }

        public void Update(Course course)
        {
            //DB İşlemleri
            var updatedCourse = courses.First(o => o.Id == course.Id);
            updatedCourse.Id = course.Id;
            updatedCourse.Description = course.Description;
            updatedCourse.Name = course.Name;
            updatedCourse.InstructorId = course.InstructorId;
            updatedCourse.CategoryId = course.CategoryId;

        }

        
    }

}
