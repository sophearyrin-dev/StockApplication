// See https://aka.ms/new-console-template for more information

namespace stockapp
{
  class Program
{

    //using enum
     public enum WeekOfTheDays {
      Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

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

        //single line comment
        /*
          multi line comment
        */

        //array
        int[] nums = new int[3];
        int[] nums2 = [1,2,3];

        // loop for each
        foreach(var num in nums2){
          Console.WriteLine(num);
        }

        //single dimention array
        int[] nums3 = [1,2,3,4,5];

        //trim in string
        string str = "  hello world  ";
        str = str.Trim();
        Console.WriteLine("After trim: {0}", str); //hello world

        Person person = new Person("Sopheary","Rin");
        person.output();
        


    }
}
}

