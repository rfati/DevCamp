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
        public void Insert(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var deletedInstructor = instructors.First(c => c.Id == entity.Id);
            instructors.Remove(deletedInstructor);
        }

        public Instructor GetById(int id)
        {
            return instructors.First(c => c.Id == id); ;
        }

        public List<Instructor> List()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var updatedInstructor = instructors.First(c => c.Id == entity.Id);
            updatedInstructor.Id = entity.Id;
            updatedInstructor.Description = entity.Description;
            updatedInstructor.FirstName = entity.FirstName;
            updatedInstructor.LastName = entity.LastName;
            
        }
    }
}
