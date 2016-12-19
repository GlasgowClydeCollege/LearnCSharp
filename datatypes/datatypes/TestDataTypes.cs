using NUnit;
using System;
using System.Collections.Generic;
using Microsoft.Win32;
using NUnit.Framework;


/*
 public static string JoinStrings(String firstString,String secondString)
        {
            var resultString = firstString + ' ' + secondString;
            Console.WriteLine(resultString);
            return resultString;
        }

        public static int Arithmetic(int A, int B, char Operator)
        {
            var result =0;
            if (Operator == '+')
            {
                result = A + B;


            }
            if (Operator == '-')
            {
                result = A - B;


            }
            if (Operator == '*')
            {
                result = A * B;


            }
            if (Operator == '/')
            {
                result = A / B;


            }
            Console.Write(result);
            return result;
        }
        public static void WriteStringArray(string[] myStrings)
        {
            foreach (var text in myStrings)
            {
                Console.Write(text +" ");
            }

        }

*/
namespace datatypes
{

    [TestFixture]
    public class ExpectedExceptionTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void HandlesArgumentExceptionAsType()
        {
            throw new ArgumentException();
        }
    }

    [TestFixture]
    public class TestDataTypes
    {
        [Test]
        public void TestTestingIsWorking()
        {
            Assert.True(true);
        }

        [Test]
        public void TestJoinStrings()
        {
            var myResult = Program.JoinStrings("Dave", "Ball");
            Assert.AreEqual(myResult, "Dave Ball");
            //Assert.AreEqual(this.GetLastTextWrittenInConsole,"Dave Ball" );
        }

        [Test]
        public void TestArithmeticAddition()
        {
            int myResult = Program.Arithmetic( 1, 2 ,'+');
            Assert.That(myResult, Is.EqualTo(3));
            //Assert.AreEqual(this.GetLastTextWrittenInConsole,"3" );
        }

        [Test]
        public void TestArithmeticSubtraction()
        {
            int myResult = Program.Arithmetic( 1, 2 ,'-');
            Assert.That(myResult, Is.EqualTo(-1));
           // Assert.AreEqual(this.GetLastTextWrittenInConsole,"-1" );
        }

        [Test]
        public void TestArithmeticMultiply()
        {
            int myResult = Program.Arithmetic( 4, 2 ,'*');
            Assert.That(myResult, Is.EqualTo(8));
            //Assert.AreEqual(this.GetLastTextWrittenInConsole,"8" );
        }

        [Test]
        public void TestArithmeticDivision()
        {
            int myResult = Program.Arithmetic( 4, 2 ,'/');
            Assert.That(myResult, Is.EqualTo(2));
            //Assert.AreEqual(this.GetLastTextWrittenInConsole,"2" );
        }



        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestArithmeticDivisionByZero()
        {
            int myResult = Program.Arithmetic( 4, 0 ,'/');


        }

        [Test]
        public void TestWriteStringArray()
        {
            string[] myStrings = new string[3];
            myStrings[0] = "hello";
            myStrings[1] = "world";
            myStrings[2] = "!!!";
            //Assert.AreEqual(this.GetLastTextWrittenInConsole, "hello world !!! ");


        }


    }
}