using System;

namespace b1
{
    delegate void updateNameHandler(string name);
    class Program
    {
        class HocSinh
        {
            public event updateNameHandler NameChanged;
            private string name;
            public string Name
            {
                get => name;
                set
                {
                    name = value;
                }
            }
        }
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Vannn";
            Console.WriteLine("Ten tu class : " + hs.Name);

            hs.Name = "Hanhh";
            Console.WriteLine("Ten tu class : " + hs.Name);
        }

        private static void Hs_NameChanged(string name)
        {
            Console.WriteLine("Ten moi : " + name);
        }
    }
}
