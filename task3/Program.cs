using System;

namespace task2{
  class Base{
    public static void Add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Result is {result}");
    }
    public void Add(int a, int b, int c)
    {
        int result = a + b + c;
        Console.WriteLine($"Result is {result}");
    }
  };
  
  class Program {
      public static void get(int length, int width)
      {
          Console.WriteLine($"fartobi aris {length*width}");
      }
      public static void get(int length, int width,int height)
      {
          Console.WriteLine($"moculoba aris {length*width*height}");
      }
      static void Main(string[] args) {
        get(2,3);
        get(2,5,8);
      }
  }
}