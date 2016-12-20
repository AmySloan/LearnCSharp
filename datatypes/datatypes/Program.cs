using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using Microsoft.SqlServer.Server;
using Microsoft.Win32;


namespace datatypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // create a method  called  JoinStrings which takes in two strings then output the result to the console and
            //return a string of these stings joined with a space  between them make sure it is public
            // call JoinStrings with your first and last name

            string[] myStrings = new string[] {"Test1", "Test2", "Test3"};
            for(int i = 0; i < myStrings.Length; i++)
            {
                Console.WriteLine(myStrings[i]);
            }

            string myResult = JoinStrings("Amy", "Sloan");

        }

        public static string JoinStrings(String one, String two)
        {
            var result = one + " " + two;
            Console.WriteLine(result);
            return result;
        }

        // create a method  called  Arithmetic which takes in two  numbers and returns a result  of a  mathematical
            //function which is also sent a a single character the result sould be  printed  to the console
            // call  arithmetic with an example of each type of calculation




        public static int Arithmetic(int A, int B, char op)
        {
            var result = 0;
            if (op == '+')
            {
                result = A + B;

            }
            if (op == '-')
            {

                result = A - B;

            }
            if (op == '*')
            {
                result = A * B;
            }
            if (op == '/')
            {
                result = A / B;
            }
            Console.Write(result);
            return result;
        }



        //Create a method called WriteStringArray which writes the contents

        public static void WriteStringArray(String[] myStrings)
        {
            foreach (var text in myStrings)
            {
                Console.Write(text + " ");
            }

    }

    }




        }
