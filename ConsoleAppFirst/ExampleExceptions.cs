using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    public class ExampleExceptions
    {
        public void Run()
        {
            try
            {
                int a = 1;
                int b = 0;
                int result = a/b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error has been occured.");
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
