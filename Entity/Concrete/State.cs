using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class State:IEntity
    {
        public int id { get; set; }
        public string Text { get; set; }
    }
}
