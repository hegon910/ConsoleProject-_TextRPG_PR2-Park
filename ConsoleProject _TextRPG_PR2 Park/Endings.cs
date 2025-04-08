using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public static class Endings
    {
    public static void EndingA()
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine
               ("                                              너무나도 두려웠다.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("                                            나를 욕하는 손가락들과" +
                "\n                                                      '이래야만 한다'는 스스로의 억압..\n");
            Thread.Sleep(3500);
            Console.WriteLine("                           사람들은 자신이 손가락질 받기 두려워, 남에게 손가락질 하는 것이다.\n");
            Console.WriteLine();
            Thread.Sleep(2500);
            Console.WriteLine
               ("\n\n                                             이겨내기 위해서는 조금의 용기면 되었다.");
            Console.WriteLine();
            Thread.Sleep(4500);
            Console.WriteLine("                        그 손가락들은 결코, 내가 용기를 가질 때까지 도망가도 나를 쫓아오지 못했다.");

            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("                                                  Ending A :뻔뻔한 용기");
            
        }
        
    }
}
