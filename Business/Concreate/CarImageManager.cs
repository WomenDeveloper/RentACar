using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Business.Constants.ImagePath;
using Core.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concreate;
using Microsoft.AspNetCore.Http;

namespace Business.Concreate
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal  _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(CarImage carImage,IFormFile file)
        {

            IResult result = BusinessRules.Run(CheckIfImageLimitExceeded(carImage.CarId));
            if (result != null)  return result;
            

            var imagepath = _fileHelper.Upload(file, ImagesUploadRoot.ImagePath);
            if (!imagepath.Success) return new ErrorResult("error upload");


            var filePath = ImagesUploadRoot.ImagePath;
            carImage.ImagePath = filePath + imagepath.Data;
            carImage.ImageUploadDate = DateTime.Now;

            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var result = _fileHelper.Delete(ImagesUploadRoot.ImagePath+ carImage.ImagePath);
            if (result.Success)
            {
                _carImageDal.Delete(carImage);
                return new SuccessResult("success");

            }
            return new ErrorResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int id)
        {

            var result = BusinessRules.Run(CheckIfAnyImageExists(id));
            if(!result.Success) return new ErrorDataResult<List<CarImage>>(GetDefaultImage(id));
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i => i.CarId == id));
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(i => i.CarImageId == id));
        }

        public IResult Update(CarImage carImage,IFormFile file)
        {

            string filePath = ImageRoot.ImagePath + carImage.ImagePath;

            var carImageResult = _fileHelper.Update(file, ImagesUploadRoot.ImagePath, filePath);
            if (carImageResult.Success)
            {
                carImage.ImageUploadDate = DateTime.Now;
                carImage.ImagePath = carImageResult.Data;
                _carImageDal.Update(carImage);
                return new SuccessResult(Messages.CarImageUpdated);

            }

            return new ErrorResult();
        }

        private IResult CheckIfImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId);
            if (result.Count >= 5)
            {
                return new ErrorResult("Image limit exceed!");
            }
            return new SuccessResult();
        }

        private IResult CheckIfAnyImageExists(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id);
            if (result.Any())
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        private List<CarImage> GetDefaultImage(int id)
        {
            List<CarImage> defaultImage = new List<CarImage>();
            defaultImage.Add(new CarImage
            {
                CarId = id,
                ImageUploadDate = DateTime.Now,
                ImagePath = "wwwroot/Uploads/Images/images.jpeg"
            }); 
            return defaultImage;
        }
    }
}

