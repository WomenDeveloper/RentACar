// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;

Console.WriteLine("Hello, Kodlama.IO!");

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (Car c in carManager.GetAll())
    Console.WriteLine(c.BrandId+" "+c.DailyPrice+" "+c.Description);