using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHolder
{


    public struct SomeValue
    {
        public int Num;
        public SomeClass SC;
    }

    public class SomeClass
    {
        public int Num;
    }

    public class BaseType : IRunable
    {

        public void Run()
        {
            Parallel.For(1, 3, i => { Console.WriteLine(i); });


            string s1 = "a";

            string s2 = s1;

            s1 = "b";//s2 is still "a"

            SomeValue[] array = new SomeValue[100];

            foreach(var i in array)
            {
                Console.WriteLine(i.Num);
            }

            SomeClass[] scArray = new SomeClass[10];
            foreach(var i in scArray)
            {
                Console.WriteLine(i);
            }
        }

        private void Run1()
        {
            var t = string.Empty;
            SomeClass sc1 = new SomeClass()
            {
                Num = 10,
            };

            SomeClass sc2 = sc1;
            sc2.Num = 11;

            SomeValue sv1 = new SomeValue
            {
                Num = 1,
            };

            SomeValue sv2 = sv1;
            sv2.Num = 2;

            Console.WriteLine($"sc1.Num: {sc1.Num}, sc2.Num:{sc2.Num}");
            Console.WriteLine($"sv1.Num: {sv1.Num}, sv2.Num:{sv2.Num}");
        }
    }
}
