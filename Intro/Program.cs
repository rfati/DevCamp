using Intro.Business.Concrete;
using Intro.DataAccess.Concrate;
using Intro.Entities.Concretes;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new(new CourseDal());

            List<Course> courses = courseManager.GetAll();
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
            }

            Instructor inn = new Instructor();
            
            

            
        }
    }
}
