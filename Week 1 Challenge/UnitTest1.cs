using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var firstName = "Norma";
            var lastName = "Bunton";
            var age = 42;

            var book = ["The Help", "The Bible", "Pride and Prejudice"];

            
            DateTime now = DateTime.Now;
            DateTime randomDate = new DateTime(2020, 01, 01);
            Console.WriteLine(randomDate);
            Console.WriteLine(now);

            var addNumToAge = 7;

            var sumAgePlusSeven = addNumToAge + age;
            Console.WriteLine(sumAgePlusSeven);  
        }

        namespace _Conditionals
    {
        [TestClass]
        public class SleepConditionals
        {
            [TestMethod]
            public void Booleans()
            {
                bool isTrue = 17 > 5;
                bool isFalse = 17 == 4;
            }

            [TestMethod]
            public void IfElseStatement()
            {
                bool isTrue = false;
                if (isTrue)
                {

                }

                int sleep = 10;

                if (sleep > 10)
                {
                    Console.WriteLine("Wow that is a lot of sleep!");
                }
                else if (sleep > 8)
                {
                    Console.WriteLine("You should be well rested");
                }
                else if (sleep > 4)
                {
                    Console.WriteLine("Bummer");
                }
                else
                {
                    Console.WriteLine("Get some sleep");
                }


                }
            }

        [TestMethod]
        public void SwitchCases()
        {
            int yourDay = 42;

            switch (yourDay)
            {
                case Great:
                    Console.WriteLine("I am having a Great Day!")
                    break;
                case Good:
                    Console.WriteLine("I am having a Good Day.")
                    break;
                case Okay:
                    Console.WriteLine("I am having an Okay Day.")
                    break;
                case Bad: 
                    Console.WriteLine("I am having a Bad Day, BooHoo.")
                default:
                    Console.WriteLine("We do not know how your day is.");
                    break;
            }
        }
        }
    }






