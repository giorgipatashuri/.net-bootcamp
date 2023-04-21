
using System;

namespace task2{
  class Program {
      static void Main(string[] args) {
        Console.Write("sheiyvane ricxvi: ");
        string? numberFromConsole = Console.ReadLine();

        if (int.TryParse(numberFromConsole, out int number))
        {
          int decimalNumber = int.Parse(numberFromConsole);
          string binaryNumber = Convert.ToString(decimalNumber, 2);
          Console.WriteLine($"es ricxvi -> {decimalNumber} orobitshi aris -> {binaryNumber}");
          
        }
        else
        {
            Console.WriteLine("sheiyvane ricxvi !!!!!");
            return;
        }
      }
  }
}