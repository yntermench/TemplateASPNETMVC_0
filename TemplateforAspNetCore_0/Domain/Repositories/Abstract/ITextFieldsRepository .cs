using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateforAspNetCore_0.Domain.Entities;

namespace TemplateforAspNetCore_0.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
