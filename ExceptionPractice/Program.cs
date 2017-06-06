using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        static Logger myLog = LogManager.CreateNullLogger();
        //public static void Main()
        //{
        //    try
        //    {
        //        try
        //        {
        //            var num = int.Parse("abc");
        //        }
        //        catch (Exception inner)
        //        {
        //            try
        //            {
        //                var openLog = File.Open("DoesNotExist", FileMode.Open);
        //            }
        //            catch
        //            {
        //                throw new FileNotFoundException("OutterException", inner);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        string inMes, outMes;
        //        if (e.InnerException != null)
        //            inMes = e.InnerException.Message;
        //        outMes = e.Message;
        //    }
        //}
        static void Main(string[] args)
        { Run(); }

        private static void Run()
        {
            Console.WriteLine("indtast 1. tal");

            //try
            //{
            //    int tal1 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Det sker en feje " + e.Message);
            //}
            //Console.WriteLine("indtast 2. tal");

            try
            {
                try
                {

                    int tal2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    try
                    {
                        var openlog = System.IO.File.Open("don't exist", FileMode.Open);
                    }
                    catch (FileNotFoundException)
                    {
                        throw new FileNotFoundException("OutterException", e);
                    }
                }
            }

            catch (Exception e)
            {
                if (e.InnerException != null)
                    Console.WriteLine(e.InnerException.Message);
            }
            finally
            {
                Console.WriteLine("Finally outer");
            }
            
            //int res = tal1 + tal2;
            //Console.WriteLine("resutatet er " + res);
        }

    }
}
