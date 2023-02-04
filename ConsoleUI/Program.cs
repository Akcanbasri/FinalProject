﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//SOLID
// O -> Open Closed Prenciple

//ProductTest();
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

foreach (var Category in categoryManager.GetAll())
{
    Console.WriteLine(Category.CategoryName);
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetAll())
    {
        Console.WriteLine(product.ProductName);
    }
    Console.WriteLine("\n");

    foreach (var product in productManager.GetAllByCategoryId(1))
    {
        Console.WriteLine(product.CategoryId + " - " + product.ProductName);
    }
    Console.WriteLine("\n");

    foreach (var product in productManager.GetAllByUnitPrice(15, 60))
    {
        Console.WriteLine(product.ProductName + " - " + product.UnitPrice);
    }
    Console.WriteLine("\n");
}