using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }
        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult("Soru eklendi");
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult("Soru silindi");
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(), "Soruları listelendi");
        }

        public IDataResult<Question> GetById(int Id)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(a => a.id == Id));
        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult("Soru güncellendi");

        }
    }
}
