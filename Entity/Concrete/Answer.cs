using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Answer:IEntity
    {
    public int id { get; set; }
    
    public int QuestionId { get; set; }
    
    public string answer { get; set; }

    public int UserId { get; set; }

    public int StateId { get; set; }

    }
}
