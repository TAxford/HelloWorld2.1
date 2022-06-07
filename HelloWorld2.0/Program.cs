using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting
            string greetingOne = "Hello World!";
            string greetingTwo = "My name is Timothy Axford II";


            //Give myself Attributes
            string wifeName = "Rebecca";
            int myAge = 36;
            int wifeAge = 34;
            double myHeight = 5.11;
            bool isMarried = true;
            bool hasChildren = true;
            bool isChild = false;
            char myGender = 'M';

            //introducing myself
            Console.WriteLine(greetingOne + greetingTwo);
            Console.WriteLine("I am " + myAge + " and my marriage status is " + isMarried);
            Console.WriteLine("Am I a child? " + isChild + " however, do I have children? This is " + hasChildren);

            //Mathmathmatic introduction
            Console.WriteLine("The diffrence in age between my wife and I is ");
            Console.WriteLine(myAge - wifeAge + " years");

            //Introduction of wife
            Console.WriteLine("My wifes name is " + wifeName);









        }
    }
}