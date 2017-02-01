using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static bool pretty(string data, int divi)
        {
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            string temp = new string(charArray);

            if (Math.Abs(Int32.Parse(data) - Int32.Parse(temp))%divi==0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            bool parse = false;
            string input,temp;
            int a = 0, b = 0,c = 0, x = 0, y = 0;
            temp = "";
            input = Console.ReadLine();
            string[] data = input.Split(' ');
            //Console.WriteLine(data.Length);
            for(int i=Int32.Parse(data[0]);i<Int32.Parse(data[1]);i++)
            {
                if (pretty( i.ToString()  , Int32.Parse(data[2])))
                { c++; }
            }
            //Console.WriteLine(args);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
