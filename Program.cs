using System;

namespace DataStructuresMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int methods
              //converting string to int type
              var num = "3";
              var result = Int32.Parse(num);

              //display the Maximum value 
              var maxValueint = Int32.MaxValue;
              Console.WriteLine(maxValueint);
              Console.ReadKey();

              //int to char converting
              var numToChar = 2;
              var ch = (char)numToChar;
              
              //getting the variable type
              var abc = 2;
              var zxc = abc.GetType();

              //converting int type to string type
              var sdf = "2"; 
              int lll;
              var convertion = Int32.TryParse(sdf, out lll);

              //Min value
              var newNumber = 2; 
              newNumber = Int32.MinValue;
              Console.WriteLine(newNumber);

               //String methods
              //getting type of variable   
              var firstName = "John";
              var nameType = firstName.GetType();

              //converting string to int
              var val = "2";
              var val2 = Convert.ToInt32(val);

                //converting int to String
              int n = 2;  
              string inputNums = n.ToString();

              // Use the Empty constant instead of the literal ""
              var message = System.String.Empty;

              //converting string to Date time 
              var dateInput = "Feb 28, 2022";
              var convertedString = DateTime.Parse(dateInput);

              //copy the referrence of the string
              var message1 = "asdf";
              var clonedmessage = (String)message1.Clone();

              //checking if the string is empty or no
              var str = "";
              var checking = string.IsNullOrEmpty(str);

              //removing the characters in string
              var str2 = "barometric";
              var str3 = str2.Remove(2,5);

              //converting string into lower case 
              var msg = "Barometric";
              var output = msg.ToLower();

              //converting the character to upper case
              var msg2 = "barometric";
              var output2 = msg2.ToUpper();

              //Double methods

              //Math.Pow method to square a number
              var squareNum = 2;
              var resSquare = Math.Pow(2,squareNum);
        }
    }
}
