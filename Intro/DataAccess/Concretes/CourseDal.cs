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
        public void Insert(Course entity)
        {
            courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var deletedCourse = courses.First(c => c.Id == entity.Id);
            courses.Remove(deletedCourse);
        }

        public Course GetById(int id)
        {
            return courses.First(c => c.Id == id); ;
        }

        public List<Course> List()
        {
            return courses;
        }

        public void Update(Course entity)
        {
            var updatedCourse = courses.First(c => c.Id == entity.Id);
            updatedCourse.Id = entity.Id;
            updatedCourse.Description = entity.Description;
            updatedCourse.Name = entity.Name;
            updatedCourse.InstructorId = entity.InstructorId;
            updatedCourse.CategoryId = entity.CategoryId;

        }

        
    }

}
