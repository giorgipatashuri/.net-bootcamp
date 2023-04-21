
using System;

namespace task1{
  class Program {
      static void Main(string[] args) {
          Console.Write("daaregistrire useris saxeli: ");
          string? username = Console.ReadLine();
          Console.Write("daaregistrire useris paroli: "); 
          string? password = Console.ReadLine();
          int attempts = 0;
          while (attempts < 5)
          {
            Console.Write("sheiyvane iuzeris saxeli : ");
              string? inputUsername = Console.ReadLine();
              
              if(inputUsername != username){
                  attempts++;
                  if(attempts!=5){
                    Console.WriteLine("iuzeris saxeli arasworia shen dagrcha => " + (5 - attempts)+" cda");
                  }
                  continue;
              }else{
                
                  break;
              };
          }
          if(attempts==5){
              Console.WriteLine("tqven ver gaiaret avtorizacia 5 cdashi");
              return;
          }
          while (5-attempts!=0)
          {
              Console.Write("sheiyvane iuzeris paroli : ");
              string? inputPassword = Console.ReadLine();
              if(inputPassword != password){
                attempts++;
                if(attempts!=5){
                  Console.WriteLine("iuzeris paroli arasworia shen dagrcha => " + (5 - attempts)+" cda");
                }
                continue;
              }else{
                Console.WriteLine("shen warmatebit gaiare avtorizacia!");
                return;
              };
          }
      }
  }
}