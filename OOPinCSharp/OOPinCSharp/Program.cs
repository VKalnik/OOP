using System;
using System.Text;

namespace OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var building = new Building(3,5,4,3);
            Console.WriteLine(building);

            Console.ReadKey();
        }

        //public static string Reverse(string s)
        //{
        //    var res = new StringBuilder();

        //    for (int i = s.Length - 1; i >= 0; --i)
        //    {
        //        res.Append(s[i]);
        //    }
        //    return res.ToString();
        //}

    }
}
