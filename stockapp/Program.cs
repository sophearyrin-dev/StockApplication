// See https://aka.ms/new-console-template for more information

namespace stockapp
{
  class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello Sopheary");

        // Parsing string to int 
        string s = "12";
        int i = int.Parse(s) + 1;
        Console.WriteLine(i);

        // Postfix increnment
        int a = 1;
        int b = a++;
        Console.WriteLine(a); // a=2
        Console.WriteLine(b); // b=1

        // Prefix
        int c = 1;
        int d = ++c;
        Console.WriteLine(c); // c=2
        Console.WriteLine(d); // d=2


    }
}
}

