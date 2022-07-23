using System;
using System.Collections.Generic;
using System.IO;
using Core.Business;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {

        public IResult Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return new SuccessResult("Dosya silindi");
            }
            return new ErrorResult("Belirtilen dosya bulunamadı");
        }

        public IDataResult<string> Update(IFormFile file, string root, string filePath)
        {
            var result = Delete(filePath);

            if (result.Success)  return Upload(file, root);

            return new SuccessDataResult<string>(data: Upload(file, root).Data);
        }

        public IDataResult<string> Upload(IFormFile file, string root)
        {
            IResult result = BusinessRules.Run(CheckFileExits(file) ,CheckFileExtension(file));

            if (result != null)  return new ErrorDataResult<string>(data: null); 

            if (!Directory.Exists(root)) Directory.CreateDirectory(root);
            
            string fileName = CreateFile(root, file);
            return new SuccessDataResult<string>(data: fileName);
  
        }

        
        private string CreateFile(string root, IFormFile file)
        {
            var guid = Guid.NewGuid().ToString();
            var extension = Path.GetExtension(file.FileName);
            var filePath = guid + extension;

            using (FileStream fileStream = File.Create(root + filePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return filePath;
        }

        private static  IResult CheckFileExits(IFormFile file)
        {
            if (file == null && file.Length < 0) return new ErrorResult("File doesn't exist");
            
            return new SuccessResult();
        }
        private static IResult CheckFileExtension(IFormFile file)
        {
            var extensions = new List<string> { ".jpg", ".png", "jpeg" };
            var extension = Path.GetExtension(file.FileName);
            if (extensions.Contains(extension)) return new ErrorResult("Invalid file extension");
            
            return new SuccessResult();
        }
    }
}

