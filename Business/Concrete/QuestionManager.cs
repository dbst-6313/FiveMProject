using Business.Abstract;
using Business.BusinessAspects.AutoFac;
using Core.Utilities.Constants;
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
        [SecuredOperation("admin")]
        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult(Messages.QuestionAdded);
        }
        [SecuredOperation("admin")]
        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult(Messages.QuestionDeleted);
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(), Messages.QuestionListed);
        }

        public IDataResult<Question> GetById(int Id)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(a => a.id == Id));
        }

        [SecuredOperation("admin")]
        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult(Messages.QuestionUpdate);

        }
    }
}
