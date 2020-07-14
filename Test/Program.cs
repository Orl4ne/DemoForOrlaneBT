using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }

    class MyException : Exception
    {
        private string myTrace { get; set; }
        public MyException()
        {
            myTrace = "Test d'ajout au stacktrace";
        }

        public override string StackTrace
        {
            get
            {
                return $"{base.StackTrace}{Environment.NewLine}{myTrace}";
            }
        }
    }
}
