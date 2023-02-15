using System;
using Tecnm.Practica1.Core.Entities;
using Tecnm.Practica1.Core.Managers;
using Tecnm.Practica1.Core.Services;
namespace Tecnm.Practica1.App;

public static class Program{
   
    public static void Main(string [] args){
         float Weight = 0;

         System.Console.WriteLine("Please enter your Weight");
         Single.TryParse(System.Console.ReadLine(), out Weight);

         var data = new Data{Peso = Weight};

         var service = new pmServices();
         var manager = new pmManager(service);

         Result result = manager.GetResult(data);

         System.Console.WriteLine($"Peso en marte {result.PesoMarte} KG");
    }
}

// See https://aka.ms/new-console-template for more information
