using _09__UpcastingDowncastingExplicitImplicit.Models;
using System;
namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Proqram
    {
        static void Main(string[] args)
        {
            #region UpCasting-DownCasting
            //    Dog dog = new Dog { AvgLifeTime = 23, Breed = "Xaski", Gender = "male", Name = "Hatika" };
            //    Eagle eagle = new Eagle { AvgLifeTime = 50, FlySpeed = 200, Gender = "female" };

            //    ////Upcasting= Implicit
            //    //Animal animal = dog;
            //    //Animal animal1 = eagle;



            //    ////DownCasting= Explicit
            //    //Dog dog1 = (Dog)animal;
            //    //Eagle eagle1 =(Eagle) animal;

            //    Animal[] animals = {dog, eagle};
            //    foreach (var animal  in animals)
            //    {
            //        //Eagle eagle1= (Eagle)animal;
            //        //Eagle eagle1 = animal as Eagle;


            //        //eagle1.Fly();

            //        //if (eagle1 != null)
            //        //{
            //        //    eagle1.Fly();
            //        //}


            //        if (animal is Eagle)
            //        {
            //            Eagle eagle1 = (Eagle)animal;
            //        }
            //        else
            //        {
            //            Dog dog1 = (Dog)animal;
            //        }

            #endregion

            #region Boxing-Unboxing
            //Boxing 
            //int a = 5;

            //Object b = a as Object;

            //int c = (int)b;

            //Test test = new Test();


            //ITest test1 = test;

            //Test test2 = (Test)test1; 
            #endregion

            Dollar dollar = new(200);
            //Console.WriteLine(dollar.USD);


            Manat manat = new(170);
            //Console.WriteLine(manat .AZN);

            Dollar dollar1 = manat;
            Console.WriteLine(dollar1.USD);

            Manat manat1 = dollar;
            Console.WriteLine(manat1.AZN);




        }
    }
}
