// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using Entity.DTOs;

Console.WriteLine("Hello, Kodlama.IO!");


//InMemoryCar_Test()
//GetByIdCar_Test();
//GetCarsByBrandId_Test();
//GetCarDetails_Test();
DataResulr_GetCarDetail_Test();



//static void GetCarsByBrandId_Test()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (Car c1 in carManager.GetCarsByBrandId(1))
//        Console.WriteLine(c1.BrandId + " " + c1.DailyPrice + " " + c1.Description);
//}

//static void GetByIdCar_Test()
//{
//    CarManager carManager = new(new EfCarDal());
//    Car c = carManager.GetById(2);
//    Console.WriteLine(c.CarId + " " + c.BrandId + " " + c.ColorId + " " + c.DailyPrice + " " + c.Description);
//}

//static void InMemoryCar_Test()
//{
//    CarManager carManager = new CarManager(new InMemoryCarDal());
//    foreach (Car c1 in carManager.GetAll())
//        Console.WriteLine(c1.BrandId + " " + c1.DailyPrice + " " + c1.Description);
//}

//static void GetCarDetails_Test()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (CarDetailDto c1 in carManager.GetCarDetails())
//        Console.WriteLine(c1.CarName + " " + c1.BrandName + " " + c1.ColorName + " " + c1.DailyPrice);
//}

static void DataResulr_GetCarDetail_Test()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetails();
    if (result.Success)
    {
        foreach (CarDetailDto c1 in result.Data)
            Console.WriteLine(c1.CarName + " " + c1.BrandName + " " + c1.DailyPrice + " " + c1.ColorName);
    }
    else { Console.WriteLine(result.Message); }
}