using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    //TODO : 브금과 입력처리 병렬화
    public class FaceStress : BaseScene
    {

        private bool hasPlayedOp = false;
        public override void Input()
        {
            #region 키입력과 인벤토리(심리상태)에 따른 분기 세분화
            ConsoleKey input = Console.ReadKey(true).Key;
            bool hasCourage = Game.player.inventory.Any(i => i.name == "용기");
            bool hasPatience = Game.player.inventory.Any(i => i.name == "끈기");
            bool hasInsight = Game.player.inventory.Any(i => i.name == "통찰");
            switch (input)
            {
                case ConsoleKey.LeftArrow:
                    if (hasCourage&&hasPatience&&hasInsight)
                    {
                        Game.End();
                        return;
                    }
                    else if (hasCourage&&hasPatience || hasInsight && hasCourage)
                    {
                        Game.End();
                        return;
                    }
                    else if (hasCourage)
                    {
                        Game.End();
                        return;
                    }
                    else
                    {
                        Game.ChangeScene("RunLeft");
                        return;
                    }

                case ConsoleKey.RightArrow:
                    if (hasCourage&&hasInsight&&hasPatience)
                    {
                        Game.End();
                        return;
                    }
                    else if(hasPatience&&hasInsight||hasPatience&&hasCourage)
                    {
                        Game.End();
                            return;
                    }
                    else if (hasPatience)
                    {
                        Game.End();
                        return;
                    }
                    else
                    {
                        Game.ChangeScene("RunRight");
                        return;
                    }
                case ConsoleKey.DownArrow:
                    if(hasInsight&&hasCourage&&hasPatience)
                    {
                        Game.End();
                            return;
                    }
                    else if (hasInsight&&hasCourage||hasPatience&&hasInsight)
                    {
                        Game.End();
                        return;
                    }
                    else if(hasInsight)
                    {
                        Game.End();
                        return;
                    }
                    else
                    {
                        Game.ChangeScene("RunDown");
                        return;
                    }
                case ConsoleKey.UpArrow:
                    Endings.GameOver();
                    return;
                default:
                    Console.SetCursorPosition(0, 19);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("누군가가 나를 비웃는다.");
                    Console.Beep(550, 100);
                    Console.Beep(550, 100);
                    Console.Beep(600, 50);
                    Console.ResetColor();
                    break;
            }
            #endregion


        }
        public void Debug()
        {
            #region 디버그 화면 코드
            Console.WriteLine("[DEBUG] 오프닝 스킵됨, 디버그할 방향키를 누르세요.");
            ConsoleKey nextKey = Console.ReadKey(true).Key;
            while (Console.KeyAvailable) Console.ReadKey(true);

            switch (nextKey)
            {
                case ConsoleKey.LeftArrow:
                    Game.ChangeScene("RunLeft");
                    return;
                case ConsoleKey.RightArrow:
                    Game.ChangeScene("RunRight");
                    return;
                case ConsoleKey.DownArrow:
                    Game.ChangeScene("RunDown");
                    return;
                case ConsoleKey.UpArrow:
                    Endings.GameOver();
                    return;
                default:
                    break;
            }
            #endregion

        }
        public override void Render()
        {
            #region 오프닝 스킵용 디버그 화면
            if (!hasPlayedOp)
            {
                Console.Clear();
                Console.WriteLine("Press Any Key to Start.........");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("────────────────────────────────────────────");
                Console.WriteLine("      아무 키나 눌러 게임을 시작합니다...");
                Console.WriteLine("      (numpad:1 키를 누르면 오프닝 연출을 건너뜁니다)");
                Console.WriteLine("────────────────────────────────────────────");
                Console.ResetColor();
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.NumPad1)
                {
                    Debug();
                }
                else
                {
                    PlayOpening();
                }
                hasPlayedOp = true;
            }
                #endregion
        }

        public override void Update()
        { }


        public override void Enter()
        {


            PlayOpening();
        

        }

        private void PlayOpening()
        {
            #region 오프닝 시퀀스
            Console.Clear();
            bool skipped = false;
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
                "□□□□□□□□□□□□□\r\n" +
                "□■■□□□□□□□■■□\r\n" +
                "□■■□□□□□□□■■□\r\n" +
                "□■■□□□□□□□■■□\r\n" +
                "□■■□□□■■■■■■□\r\n" +
                "□■■□□□□□□□■■□\r\n" +
                "□■■□□□□□□□■■□\r\n" +
                "□■■□□□□□□□■■□\r\n" +
                "□■■■■■■■□□■■□\r\n" +
                "□□□□□□□□□□■■□\r\n" +
                "□□□□□□□□□□■■□\r\n" +
                "□□□□□□□□□□■■□");
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
            Console.WriteLine(@"□□□□□□□□□□□□□□
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

            Console.WriteLine("KI Academy");
            Console.Beep(180, 700); // 가장 낮고 끈적한 울림         
            Thread.Sleep(1500);
            Console.WriteLine("    Console proect II");
            Console.Beep(190, 1500); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         
            Console.Beep(250, 100); // 가장 낮고 끈적한 울림         

            Console.WriteLine("         Text RPG");
            Console.WriteLine("                               ");

            Console.Beep(270, 100);
            Thread.Sleep(300);
            Console.Beep(270, 100);
            Thread.Sleep(500);
            Console.Beep(270, 500);
            Console.Beep(200, 300);
            Console.Beep(180, 600);
            if (Game.player.inventory.Any(item => item.name == "용기") && Game.player.inventory.Any(item => item.name == "끈기"))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("용기←  끈기→ ");
                Console.ResetColor();
                Console.WriteLine("             도망↓");
            }
            else if (Game.player.inventory.Any(item => item.name == "끈기"))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("      끈기→ ");
                Console.ResetColor();
                Console.WriteLine("도망←         도망↓ ");
            }
            else if (Game.player.inventory.Any(item => item.name == "용기"))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("용기← ");
                Console.ResetColor();
                Console.WriteLine("      도망→   도망↓ ");

            }
            else
            {
                Console.WriteLine("도망←  도망→  도망↓ ");
            }
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true); // 버퍼에 남은 키 날려버림
            }
            Thread.Sleep(1000);

            int count = 0;
            bool isRunning = true;
            while (isRunning)
            {
                if (count % 3 == 0) // TODO : 브금이 3번 루프하고나서야 키입력이 가능해짐 일단 보류
                
                    Console.Beep(270, 500);
                    if (Console.KeyAvailable) { Input(); break; }

                    Console.Beep(200, 300);
                    if (Console.KeyAvailable) { Input(); break; }

                    Console.Beep(180, 600);
                    if (Console.KeyAvailable) { Input(); break; }

                    Thread.Sleep(1000);
                    count++;
                

                if (Console.KeyAvailable)
                {
                    Input();
                    isRunning = false;
                }



            }
            #endregion
        }

    }
}
