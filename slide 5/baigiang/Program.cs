using System;

namespace baigiang
{
    class Program
    {
        // tao delegate
        delegate int MyDelegate(string s);
        // methods cho delegate
        static int ConvertStringToInt(string stringValue)
        {
            int valueInt = 0;
            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Da ep kieu thanh cong");
            return valueInt;
        }
        static void Main(string[] args)
        {
            MyDelegate convertToInt = new MyDelegate(ConvertStringToInt);
            //string numberStr = "35";
            int valueConverted = convertToInt("35");
            Console.WriteLine("Gia tri da convert thanh int: " + valueConverted);
            //Console.ReadLine();
        }
    }
}
