using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        private static void exampleDivideByZeroException() {
            // 10/0
            throw new DivideByZeroException("Cannot divide by Zero");
        }

        private static void exampleNullReferenceException() {
            // string name
            // name.Length
            throw new NullReferenceException("Cant apply operations on null value");
        }

        private static void exampleIndexOutOfRangeException() {
            // string [] students = {"A", "B", "C"}
            // Console.WriteLine(students[5])
            throw new IndexOutOfRangeException("Index you referring is not present");
        }

        static void Main(string[] args)
        {
            int userInput;

            while (true)
            {
                Console.WriteLine("\nChoose an Exception Below :");
                Console.WriteLine("1. DivideByZeroException");
                Console.WriteLine("2. NullReferenceException");
                Console.WriteLine("3. IndexOutOfRangeException");
                Console.WriteLine("Enter 0 to exit");
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput) {
                    case 0:
                        Console.WriteLine("\nQuiting Menu.");
                        return;
                    case 1:
                        Console.WriteLine("\nDivideByZeroException");
                        try 
                        {
                            exampleDivideByZeroException();
                        }catch (Exception ex) 
                        { 
                            Console.WriteLine(ex.ToString()); 
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nNullReferenceException");
                        try
                        {
                            exampleNullReferenceException();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nIndexOutOfRangeException");
                        try
                        {
                            exampleIndexOutOfRangeException();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("\nWrongInput Please Try Again!");
                        break;
                }
            }
        }
    }
}
