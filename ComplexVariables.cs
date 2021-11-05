using System;
namespace DataStructuresMethods
{
    class ComplexVariables
    {
        static void MainWin(string[] args)
        {
            //Create new array 
              string[] cars = {"Volvo", "Mersedez", "BMW"};

              //creating array to add items
              string[] iPhones = new string [4];
              iPhones[0] = "Iphone1";
              iPhones[1] = "Iphone2";
              iPhones[2] = "Iphone3";
              iPhones[3] = "Iphone4";

              // adding new element to array
              Array.Resize(ref cars, cars.Length+1);
              cars[cars.Length-1] = "Chevrolet";

              //deleting an element in array 
              int a = cars.Length-1;
              for (int i = 0; i < a; i++)
              {
                  cars[a] = null;
              }

              //Get lenth of Array
              int[] paper = {};
              int result = paper.Length;

              //Copy Array to Array
              int[] pen = {};
              int[] pencil = {};
              Array.Copy(pen,pencil,pen.Length); 

              //getting particular index in array
              int[] mac = {0,1,2,3,4};
              int findingIndex = Array.IndexOf(mac,3);

              //get the value of index 
              int[] mouse = {3,4,2,1,10};
              mouse.GetValue(3);

              //changing the value of Index
              string[] baseball = {"ball","micky","mark"};
              baseball[Array.IndexOf(baseball,2)] = "Jordan";

              //sort array 
              int[] numbers = {2,100,7};
              Array.Sort(numbers);

              //reverse array
              int[] phones = {123,0,333};
              Array.Reverse(phones);

              //convert array to string
              string[] names = {"Michael","Jack", "Bob"};
              string s = string.Join(" ",names);
        }
    }
}
