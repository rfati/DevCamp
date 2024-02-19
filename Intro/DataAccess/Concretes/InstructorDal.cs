using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class InstructorDal:IInstructorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>() { new Instructor { FirstName = "Yayıncı1", LastName = "Yayıncı1", Description = "Açıklama1", Id = 1 }, new Instructor { FirstName = "Yayıncı2", LastName = "Yayıncı2", Description = "Açıklama2", Id = 2 } };

        }
        public void Insert(Instructor instructor)
        {
            //DB İşlemleri
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            //DB İşlemleri
            var deletedInstructor = instructors.First(o => o.Id == instructor.Id);
            instructors.Remove(deletedInstructor);
        }

        public Instructor GetById(int id)
        {
            //DB İşlemleri
            return instructors.First(o => o.Id == id);
        }

        public List<Instructor> List()
        {
            //DB İşlemleri
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            var updatedInstructor = instructors.First(o => o.Id == instructor.Id);
            updatedInstructor.Id = instructor.Id;
            updatedInstructor.Description = instructor.Description;
            updatedInstructor.FirstName = instructor.FirstName;
            updatedInstructor.LastName = instructor.LastName;
            
        }
    }
}
