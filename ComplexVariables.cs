using System;
namespace DataStructuresMethods
{
    class ComplexVariables
    {
        static void MainWin(string[] args)
        {
            //Create new array 
              string[] cars = {"Volvo", "Mersedez", "BMW"};

              // adding new element to array
              Array.Resize(ref cars, cars.Length+1);
              cars[cars.Length-1] = "Chevrolet";

              //deleting an element in array 
              int a = cars.Length-1;
              int indexRemove = cars.Length-1;
              for (int i = 0; i < a; i++)
              {
                  cars[a] = null;
                  //System.Console.WriteLine(cars);
              }
        }
    }
}
