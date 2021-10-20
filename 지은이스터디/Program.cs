using System;
using System.Text;

namespace 지은이스터디
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder a = new StringBuilder();
            //a.Append('a');
            //a.Append('b');
            //a.Append('c');

            Console.WriteLine(a);
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                    a.Append('*');
            }
            Console.WriteLine(a);
            //a.Clear();
            //Console.WriteLine(a);

            //a.Append('d');

            //Console.WriteLine(a);
        }
    }
}


//a.Clear();

//a.Clear();