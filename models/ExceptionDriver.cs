using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_30_a_strings.models
{
    public static class ExceptionDriver
    {
        public static void Run()
        {
            IndexOutOfRangeExceptionDemo();
            NullReferenceExceptionDemo();
            IOExceptionDemo();
        }

        public static void IndexOutOfRangeExceptionDemo()
        {
            int[] numbers = { 1, 2, 3 };
           
            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException caught {ex.Message}");
            }
        }

        public static void NullReferenceExceptionDemo()
        {
            string message = null;
            try
            {
                Console.WriteLine(message.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"NullReferenceException caught {ex.Message}");
            }
        }
        public static void IOExceptionDemo()
        {
            string filePath = "this-file-does-not-exist.txt";

            try
            {
                string content = File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException caught {ex.Message}");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Console.WriteLine($"IOException Demo is finally here");
            }
        }
    }
}
