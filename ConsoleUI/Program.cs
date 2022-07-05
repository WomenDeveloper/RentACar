// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;

Console.WriteLine("Hello, Kodlama.IO!");

CarManager carManager = new CarManager(new InMemoryCarDal());
Car c = carManager.GetById(2);
Console.WriteLine(c.CarId+" "+c.BrandId+" "+c.ColorId+" "+c.DailyPrice+" "+c.Description);

foreach (Car c1 in carManager.GetAll())
    Console.WriteLine(c1.BrandId+" "+c1.DailyPrice+" "+c1.Description);