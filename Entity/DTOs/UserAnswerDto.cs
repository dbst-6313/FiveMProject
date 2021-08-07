using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class UserAnswerDto:IDto
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int AnswerId { get; set; }
        public string Answer { get; set; }
        public string Email { get; set; }
        public int StateId { get; set; }
        public string State { get; set; }
    }
}
