using Intro.Business.Abstract;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concrate;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business.Concrete
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;
        //dependency injection design pattern
  

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Insert(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.List();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
