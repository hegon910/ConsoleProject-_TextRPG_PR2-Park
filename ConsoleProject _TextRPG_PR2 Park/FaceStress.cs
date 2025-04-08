using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public class FaceStress : BaseScene
    {
        public override void Input()
        {
            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.LeftArrow:
                    Game.ChangeScene("RunLeft");
                    break;
                case ConsoleKey.RightArrow:
                    Game.ChangeScene("RunRight");
                    break;
                case ConsoleKey.DownArrow:
                    Game.ChangeScene("RunDown");
                    break;

            }

        }

        public override void Render()
        {
            #region 오프닝 시퀀스
            Console.Clear();
            string noise = "나렇생는.이살인쁘은나않냥지게늘오람쁘는이도그사다다나간나그지않.아은고";
            string doubt = "하에말?자위네그지끼끄선있고럽지까마새제주럴냐.자랄하부,.위변정명도않지선";
            for (int i = 0; i < 50; i++)
            {
                Console.Write(noise); Console.Write(noise); Console.Write(noise); Console.Write(noise); Console.Write(noise);
                Thread.Sleep(15);
            }
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(noise);
                Console.WriteLine(noise);
                Console.WriteLine(noise);
                Thread.Sleep(10);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Console.WriteLine(doubt);
                Thread.Sleep(100);
                Console.ResetColor();


            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" +
                "                                                    □□□□□□□□□□□□□\r\n" +
                "                                                    □■■□□□□□□□■■□\r\n" +
                "                                                    □■■□□□□□□□■■□\r\n" +
                "                                                    □■■□□□□□□□■■□\r\n" +
                "                                                    □■■□□□■■■■■■□\r\n" +
                "                                                    □■■□□□□□□□■■□\r\n" +
                "                                                    □■■□□□□□□□■■□\r\n" +
                "                                                    □■■□□□□□□□■■□\r\n" +
                "                                                    □■■■■■■■□□■■□\r\n" +
                "                                                    □□□□□□□□□□■■□\r\n" +
                "                                                    □□□□□□□□□□■■□\r\n" +
                "                                                    □□□□□□□□□□■■□");
            Thread.Sleep(100);
            Console.ResetColor();
            Console.Beep(300, 700);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"■■■■■■■□□■■\
                                                    □   □□■■□□□□■■\
                                      □□□■■□□□□■■\
                                                                                          □□□■■□■■■■■\
                                                    □□■■                            ■■□□□■■\
                                                    ■■■□□■          ■□□■■\
                 ■■□□□□      ■□□■■\
                                                                                                       □□■■■■■■■■■\
                                      □□□□□□□                                          □□■■\
                                                                          □□□□□□□□□■■\
                            □□□□□□□□□■■\
                                                                                                                □□□□□□□□□■■");
            Console.ResetColor();
            Thread.Sleep(100);
            Console.Clear();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                                                                ■■■■■■■□□■■\
                           □                                     □□■■□□□□■■\
                                                                                                      □□□■■□□□□■■\
                                                                        □□□■■□■■■■■\
                                                    □□■■             ■■□□□■■\
                                                    ■■■□□■       ■□□■■\
                 ■■□□□□      ■□□■■\
                                                                     □□■■■■■■■■■\
                                                       □□□□□□□                □□■■\
                                                                          □□□□□□□□□■■\
                                                             □□□□□□□□□■■\
                                                    □□□□□□□□□■■");
            Console.ResetColor();
            Thread.Sleep(100);
            Console.Clear();

            Console.Beep(1500, 50);
            Console.Beep(1500, 50);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                                                    □□□□□□□□□□□□□□
                                                    □■■■■■■■□□■■□□
                                                    □□□□■■□□□□■■□□
                                                    □□□□■■□□□□■■□□
                                                    □□□□■■□■■■■■□□
                                                    □□□■■■■□□□■■□□
                                                    □■■■□□■■□□■■□□
                                                    □■■□□□□■□□■■□□
                                                    □□□■■■■■■■■■□□
                                                    □□□□□□□□□□■■□□
                                                    □□□□□□□□□□■■□□
                                                    □□□□□□□□□□■■□□
                                                    □□□□□□□□□□■■□□");
            Console.ResetColor();



            Console.Beep(250, 500); // 낮고 길게
            Thread.Sleep(700);

            Console.Beep(220, 400); // 조금 더 낮게
            Thread.Sleep(1000);

            Console.Beep(300, 350); // 살짝 올라가며 위협감
            Thread.Sleep(600);

            Console.WriteLine("                                                      도망쳐");
            Console.Beep(180, 700); // 가장 낮고 끈적한 울림         
            Thread.Sleep(1500);
            Console.WriteLine("                                                          도망쳐?");
            Console.Beep(190, 1500); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         

            Console.WriteLine("                                                            도망쳐!");
            Console.WriteLine("                               ");

            Console.Beep(270, 100);
            Thread.Sleep(300);
            Console.Beep(270, 100);
            Thread.Sleep(500);
            Console.Beep(270, 500);
            Console.Beep(200, 300);
            Console.Beep(180, 600);
            Console.WriteLine("                                         1.도망  ←     3.도망  →       4.도망  ↓ ");

            Thread.Sleep(1000);

            int count = 0;
            while (true)
            {
                if (count % 3 == 0)
                    Console.Beep(270, 500);
                Console.Beep(200, 300);  // 가끔 변칙음

                Console.Beep(180, 600);
                Thread.Sleep(1000);

                count++;
                Input();
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.UpArrow)
                    {
                        Game.GameOver();
                        return;
                    }
                }

            }
            #endregion
        }

        public override void Update()
        { }


        public override void Result()
        { }


    }
}
