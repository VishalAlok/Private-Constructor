
// C# Program to illustrate calling
// a Private constructor
using System;
namespace privateConstructorExample
{
    public class Geeks
    {
        private Geeks()
        {
        }
        public static int count_geeks;
        public static int geeks_Count()
        {
            return ++count_geeks;
        }
        public static void Main()
        {
            // Geeks s = new Geeks(); // Error
            Geeks.count_geeks = 99;
            Geeks.geeks_Count();
        }
    }
}