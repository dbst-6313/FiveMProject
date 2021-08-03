using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<Answer> GetById(int Id);
        IResult Add(Answer answer);
        IResult Update(Answer answer);
        IResult Delete(Answer answer);
    }
}
