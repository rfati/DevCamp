using Intro.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities.Concretes
{
    public class BaseEntity:IEntity
    {
        public int Id { get; set; }
    }
}
