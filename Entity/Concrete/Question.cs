using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Question:IEntity
    {
        public int id { get; set; }

        public string question { get; set; }
    }
}
