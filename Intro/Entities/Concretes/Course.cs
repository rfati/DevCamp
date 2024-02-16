using Intro.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities.Concretes
{
    public class Course:BaseEntity
    {
        
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
       
    }
}
