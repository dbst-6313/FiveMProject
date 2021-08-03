using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<Question>> GetAll();

        IDataResult<Question> GetById(int Id);
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
    }
}
