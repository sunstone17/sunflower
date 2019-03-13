using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHolder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Run()
        {
            IRunable run = new BaseType();
            run.Run();
            Console.Read();
            return;
        }
    }
}
