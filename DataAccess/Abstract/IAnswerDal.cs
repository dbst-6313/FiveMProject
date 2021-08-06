using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAnswerDal: IEntityRepository<Answer>
    {
        List<UserAnswerDto> GetUserAnswer();
        List<UserAnswerDto> GetUserAnswerById(int id);
        List<UserAnswerDto> GetDeniedAnswersDto();
        List<UserAnswerDto> GetActiveAnswersDto();
    }
}
