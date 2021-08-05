using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnswerDal : EfEntityRepositoryBase<Answer, WhitelistApplicationContext>, IAnswerDal
    {
        public UserAnswerDto GetUserAnswerById(int id)
        {
            using (var context = new WhitelistApplicationContext())
            {
                var result = from a in context.answers
                             join q in context.questions
                             on a.QuestionId equals q.id
                             join s in context.state
                             on a.StateId equals s.id
                             join u in context.users
                             on a.UserId equals u.Id
                             select new UserAnswerDto
                             {
                                 Answer = a.answer,
                                 Email = u.Email,
                                 Question = q.question,
                                 State = s.Text,
                                 UserId = u.Id
                                 ,
                                 StateId = s.id
                             };
                return result.FirstOrDefault(e => e.UserId == id);

            }
        }
        public List<UserAnswerDto> GetUserAnswer()
        {
            using (var context = new WhitelistApplicationContext())
            {
                var result = from a in context.answers
                             join q in context.questions
                             on a.QuestionId equals q.id
                             join s in context.state
                             on a.StateId equals s.id
                             join u in context.users
                             on a.UserId equals u.Id
                             select new UserAnswerDto
                             {
                                 Answer = a.answer,
                                 Email = u.Email,
                                 Question = q.question,
                                 State = s.Text,
                                 UserId = u.Id
                                 ,
                                 StateId = s.id
                             };
                return result.ToList();

            }
        }
        public List<UserAnswerDto> GetActiveAnswersDto()
        {
            using (var context = new WhitelistApplicationContext())
            {
                var result = from a in context.answers
                             join q in context.questions
                             on a.QuestionId equals q.id
                             join s in context.state
                             on a.StateId equals s.id
                             join u in context.users
                             on a.UserId equals u.Id
                             select new UserAnswerDto
                             {
                                 Answer = a.answer,
                                 Email = u.Email,
                                 Question = q.question,
                                 State = s.Text,
                                 UserId = u.Id
                                 ,
                                 StateId = s.id
                             };
                return result.Where(a=>a.StateId == 2).ToList();

            }
        }
        public List<UserAnswerDto> GetDeniedAnswersDto()
        {
            using (var context = new WhitelistApplicationContext())
            {
                var result = from a in context.answers
                             join q in context.questions
                             on a.QuestionId equals q.id
                             join s in context.state
                             on a.StateId equals s.id
                             join u in context.users
                             on a.UserId equals u.Id
                             select new UserAnswerDto
                             {
                                 Answer = a.answer,
                                 Email = u.Email,
                                 Question = q.question,
                                 State = s.Text,
                                 UserId = u.Id
                                 ,
                                 StateId = s.id
                             };
                return result.Where(a => a.StateId == 1).ToList();

            }
        }
    }
}
