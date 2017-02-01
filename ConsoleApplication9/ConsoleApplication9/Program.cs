using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static bool pretty(string data)
        {
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            string temp = new string(charArray);

            if (Math.Abs(Int32.Parse(data) - Int32.Parse(temp))%6==0)
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
            for(int i=0;i<data.Length;i++)
            {
                if (pretty(data[i]))
                { c++; }
            }
            //Console.WriteLine(args);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
