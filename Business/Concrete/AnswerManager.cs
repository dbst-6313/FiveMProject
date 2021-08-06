using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {

        IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IResult Add(Answer answer)
        {
            _answerDal.Add(answer);
            return new SuccessResult("Cevap eklendi");
        }

        public IResult changeStateAccept(int id)
        {
            var answer = _answerDal.Get(p => p.id == id);
            answer.StateId = 2;
            _answerDal.Update(answer);
            return new SuccessResult("Başvuru durumu:Kabul edildi");
        }

        public IResult changeStateDenied(int id)
        {
            var answer = _answerDal.Get(p => p.id == id);
            answer.StateId = 1;
            _answerDal.Update(answer);
             return new SuccessResult("Başvuru durumu:Reddedildi");
        }

        public IResult Delete(Answer answer)
        {
            _answerDal.Delete(answer);
            return new SuccessResult("Cevap silindi");
        }

        public IDataResult<List<UserAnswerDto>> GetAcceptedAnswers()
        {
            return new SuccessDataResult<List<UserAnswerDto>>(_answerDal.GetActiveAnswersDto());
        }

        public IDataResult<List<Answer>> GetAll()
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(), "Cevaplar listelendi");
        }

        public IDataResult<List<UserAnswerDto>> GetAnswerDetails()
        {
            return new SuccessDataResult<List<UserAnswerDto>>(_answerDal.GetUserAnswer());
        }

        public IDataResult<List<UserAnswerDto>> GetAnswerDetailsByUserId(int id)
        {
            return new SuccessDataResult<List<UserAnswerDto>>(_answerDal.GetUserAnswerById(id));
        }

        public IDataResult<Answer> GetById(int Id)
        {
            return new SuccessDataResult<Answer>(_answerDal.Get(a => a.id == Id));
        }

        public IDataResult<List<UserAnswerDto>> GetDeniedAnswers()
        {
            return new SuccessDataResult<List<UserAnswerDto>>(_answerDal.GetDeniedAnswersDto());
        }

        public IResult Update(Answer answer)
        {
            _answerDal.Update(answer);
            return new SuccessResult("Cevaplar güncellendi");
        }
    }
}
