using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<Answer> GetById(int Id);
        IDataResult<List<UserAnswerDto>> GetAnswerDetails();
        IDataResult<List<UserAnswerDto>> GetAcceptedAnswers();
        IDataResult<List<UserAnswerDto>> GetDeniedAnswers();
        IDataResult<List<UserAnswerDto>> GetAnswerDetailsByUserId(int id);
        IResult Add(Answer answer);
        IResult Update(Answer answer);
        IResult changeStateDenied(int id);
        IResult changeStateAccept(int id);
        IResult Delete(Answer answer);
    }
}
