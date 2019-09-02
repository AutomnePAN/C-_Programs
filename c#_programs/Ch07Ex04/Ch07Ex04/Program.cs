using System;

namespace Ch07Ex04
{
    class Program
    {
        static string[] etypes = { "none", "simple", "index", "nested index", "filter" };
        static void Main(string[] args)
        {
            foreach(string etype in etypes)
            {
                try
                {
                    Console.WriteLine("Main() function reached!");
                    ThrowException(etype);
                    Console.WriteLine("Main() function continue");
                }
                catch (IndexOutOfRangeException) when (etype == "filter")
                {
                    Console.WriteLine("Index Exception catched with filter");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index Exception catched without filter");
                }
                catch
                {
                    Console.WriteLine("Defaut catcher of exception!");
                }
                finally
                {
                    Console.WriteLine("Finished");
                }
                Console.WriteLine("------------------------------------------------------");
            }
            Console.WriteLine("Hello World!");
        }

        static void ThrowException(string etype)
        {
            Console.WriteLine("ThrowException reached");
            Console.WriteLine("\t the error type is : " + etype);
            switch(etype)
            {
                case  "none" :
                    Console.WriteLine("We do nothing");
                    break;
                case "simple":
                    throw (new Exception("Simple Exception"));
                case "index":
                    Console.WriteLine("A index Exception thrown");
                    throw new IndexOutOfRangeException();
                case "nested index":
                    try
                    {
                        Console.WriteLine("A nested index Exception thrown");
                        ThrowException("filter");
                    }
                    catch(IndexOutOfRangeException) when (etype == "filter")
                    {
                        Console.WriteLine("A nested index Excperion catched");
                        throw;
                    }
                    finally
                    {
                    }
                    break;
                case "filter":
                    Console.WriteLine("A filter Exception is thrown");
                    throw (new IndexOutOfRangeException());
                default:
                    Console.WriteLine("The wrong word to trigger the exception");
                    break;
            }
        }
    }
}
