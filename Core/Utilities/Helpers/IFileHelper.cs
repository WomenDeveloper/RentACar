using System;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public interface IFileHelper
    {
        IDataResult<string> Upload(IFormFile file, string root);
        IDataResult<string> Update(IFormFile file, string root, string filePath);
        IResult Delete(string filePath);
    }
}

