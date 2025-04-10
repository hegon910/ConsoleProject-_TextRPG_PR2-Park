using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public static class Endings
    {
        private static bool gameOver;
        public static void EndingA()
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine
               ("엔딩 - 용기 -");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("나를 향하는 손가락들" +
                "\n'이래야만 한다'는 스스로의 억압\n");
            Thread.Sleep(3500);
            Console.WriteLine("사람들은 자신이 손가락질 받기 두려워, 남에게 손가락질 하는 것이다.\n");
            Console.WriteLine();
            Thread.Sleep(2500);
            Console.WriteLine
               ("\n\n이겨내기 위해 조금의 용기를 가지고");
            Console.WriteLine();
            Thread.Sleep(4500);
            Console.WriteLine("고개를 들었을 때, 나를 향하는 손가락 같은 건 애초부터 없었다.");

            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("스스로 숨을 필요는 없었다.");

            Console.WriteLine("\n\nR to Restart? or you can choose 'Escape' for this.");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.R)
                    {
                        Game.Start();
                        Game.Run();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public static void EndingB()
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.WriteLine("엔딩 - B 끈기");
            Thread.Sleep(1000);
            Console.WriteLine("'어차피, 안 될 것이다.'");
            Thread.Sleep(3000);
            Console.WriteLine("'갈 길이 너무 멀다.'");
            Thread.Sleep(3000);
            Console.WriteLine("그렇게 포기해 왔던 길들을 만약에 지금까지 걷고 있었더라면...");
            Thread.Sleep(4000);
            Console.WriteLine("조금 멀리 돌아도 괜찮다.");
            Thread.Sleep(2000);
            Console.WriteLine("편법이면 어떻고, 스스로가 부끄러울 때가 있더라도 어떤가.");
            Thread.Sleep(3000);
            Console.WriteLine("멈춰 설 필요는 없다. 오늘도 조금이라도 한 걸음이라도 이 길 위에서");
            Thread.Sleep(3000);
            Console.WriteLine("발을 내딛기만 한다면, 언젠가는 도착할 것이다.");
            Thread.Sleep(2000);
            Console.WriteLine("\n\nR to Restart? or you can choose 'Escape' for this.");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.R)
                    {
                        Game.Start();
                        Game.Run();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
        public static void EndingC()
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.WriteLine("엔딩 - C 통찰");
            Thread.Sleep(1000);
            Console.WriteLine("'아는 것은 모르는 것을 제외한 것'");
            Thread.Sleep(3000);
            Console.WriteLine("'모르는 것은 앞으로 알아갈 수 있는 것'");
            Thread.Sleep(3000);
            Console.WriteLine("지금 모르는 것을 알아갈 즐거움에 더 신경 쓰자.");
            Thread.Sleep(4000);
            Console.WriteLine("남들만큼 알지 못한다고 부끄러워하는 것은, 자신이 아는 것을 부정하는 일이다.");
            Thread.Sleep(2000);
            Console.WriteLine("나만이 아는 것을 이해하고, 모르는 것을 배우는 걸 즐거워 하자");
            Thread.Sleep(3000);
            Console.WriteLine("가장 무서운 것은 흥미를 잃는 것이요, 무관심에 귀를 닫는 것이다.");
            Thread.Sleep(4000);
            Console.WriteLine("언젠가는 이해할 것이니, 흩어진 조각을 하나 씩 놓아보자.");
            Thread.Sleep(5000);
            Console.WriteLine("\n\nR to Restart? or you can choose 'Escape' for this.");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.R)
                    {
                        Game.Start();
                        Game.Run();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        
        public static void TrueEnding()
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.WriteLine("세상은 내가 누비는 무대이며");
            Thread.Sleep(3000);
            Console.WriteLine("내가 쓰는 각본에 따라 내용이 바뀌고");
            Thread.Sleep(4000);
            Console.WriteLine("나의 받아드림에 따라 장르가 바뀌며");
            Thread.Sleep(4000);
            Console.WriteLine("나의 감정에 따라 음악이 깔린다.");
            Thread.Sleep(5000);
            Console.WriteLine("\n\n                           그리고 이 무대의 가장 중요한 관객도 내 마음 속의 나 자신 뿐이다.");
            Thread.Sleep(3000);
            Console.WriteLine("\n                                      커튼을 열고 오늘도 무대로 향하자.");
            Thread.Sleep(7000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("□□□□□□□□□□□□□□□□□■□■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□\r" +
                "\n□■□□□□□■□□□□□□□□□■□■□□□□□□□□□□□□□□■■□□□■■□□□□■■□□■■■■■■□□■■■■■■□□■□□□□□□□■■■■■■□□□■■□\r" +     
                "\n□■□□□□□■□□□□□□□□□■□■□□□□□□□□□□□□□□■■□□□■■■□□□■□□■■■□□■■■□■□□□■■□□■□□□□□□□■□□□■■■□□■■□\r" +     
                "\n□■□□□□□■□■■■■■■□□■□■□□■■■■■■□□□□□□□■□□□■■■□□■■□□■■□□□□■■□■□□□□■□□■□□□□□□□■□□□□■■□□■■□\r" +     
                "\n□■■■■■■■□■■□□■■□□■□■□□■■□□■■□□□□□□□■■□■■□■□□■■□□■□□□□□□■□■□□□■■□□■□□□□□□□■□□□□□■□□■■□\r" +     
                "\n□■□□□□□■□■□□□□■□□■□■□□■□□□□■□□□□□□□■■□■■□■■□■□□□■□□□□□□■□■■■■■■□□■□□□□□□□■□□□□□■□□■■□\r" +     
                "\n□■□□□□□■□■■■■■■□□■□■□□■□□□□■□□□□□□□□■□■□□■■■■□□□■□□□□□□■□■□□■■□□□■□□□□□□□■□□□□□■□□■■□\r" +     
                "\n□■□□□□□■□■□□□□□□□■□■□□■□□□□■□□□□□□□□■■■□□■■■■□□□■■□□□□■■□■□□□■■□□■□□□□□□□■□□□□■■□□■■□\r" +     
                "\n□■□□□□□■□■■□□□■□□■□■□□■■□□■■□□□□□□□□■■■□□□■■□□□□■■■□□■■■□■□□□■■□□■□□□□□□□■□□□■■■□□□□□\r" +     
                "\n□■□□□□□■□■■■■■■□□■□■□□■■■■■■□■■□□□□□■■■□□□■■□□□□□■■■■■■□□■□□□□■□□■■■■■■□□■■■■■■□□□■■□\r" +     
                "\n□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□\r" +     
                "\n□□□□□□□□□□□□□□□□□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.ResetColor();
            Thread.Sleep(6000);
            Console.WriteLine("Thank You For Playing\n press Enter or Esc to Exit");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape || key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                }
            }

        }

        public static void GoodEnding()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("오늘도 하루가 다르지 않다.");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("나는 같은 하루지만 이 기분은 뭘까.");
            Thread.Sleep(3000);
            Console.WriteLine("한결 편해진 마음.");
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.WriteLine("\n 설령 거센 바람이 분다해도, 이제는 그것마저 즐거움이 된다. ");
            Thread.Sleep(3000);
            Console.WriteLine("\n 내게 필요한 것은 그다지 많지 않았다. ");
            Thread.Sleep(3000);
            Console.WriteLine("\n 댓가가 노력보다 적을까 두려워, 달려나갈 수 없던 그날들은 지났다. ");
            Thread.Sleep(4000);
            Console.WriteLine("\n 나는 오늘도 즐겁다. ");
            Thread.Sleep(5000);
            Console.WriteLine("\n\nR to Restart? or you can choose 'Escape' for this.");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.R)
                    {
                        Game.Start();
                        Game.Run();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public static void GameOver()
        {
            #region 엔딩 시퀀스
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine
               ("                                              나에게는 능력이 없었다.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("                                            많은 일이 일어났던 것 같다." +
                "\n                                                      하지만...\n");
            Thread.Sleep(3500);
            Console.WriteLine("                               어떤 일이 일어났었는지, 왜 그런 기분인지 조차 생각나질 않는다.\n");
            Console.WriteLine();
            Thread.Sleep(2500);
            Console.WriteLine
               ("\n\n                                    평화로운 하  루   가 시작된다. 남은 것 하나 없다는 공허함과 함께...");
            Console.WriteLine();
            Thread.Sleep(4000);
            Console.Beep(270, 500);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\n\n\n\n                                        늘 ");
            Console.Write("똑");
            Console.Beep(200, 300);
            Thread.Sleep(500);
            Console.Write("  ");
            Console.Write("같");
            Console.Beep(180, 600);
            Thread.Sleep(500);
            Console.Write("은");
            Console.Beep(270, 500);
            Thread.Sleep(1300);
            Console.Write(" ");
            Console.Write("하");
            Console.Beep(200, 1000);
            Thread.Sleep(300);
            Console.Write("      ");
            Console.Write("루");
            Console.Beep(270, 500);
            Thread.Sleep(300);
            Console.Write("가");
            Console.Beep(240, 500);
            Thread.Sleep(300);
            Console.Write(" ");
            Console.Write("시");
            Console.Beep(270, 1400);
            Thread.Sleep(100);
            Console.Write(" ");
            Console.Write("    작");
            Console.Beep(200, 300);
            Thread.Sleep(1866);
            Console.Write("     ");
            Console.Write("된");
            Console.Beep(230, 300);
            Thread.Sleep(666);
            Console.Write("다");
            Console.Beep(180, 300);
            Thread.Sleep(66);
            Console.Write(".");


            Console.WriteLine();
            Console.ResetColor();
            Thread.Sleep(3666);
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(666);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(".");
                Console.ResetColor();
            }
            gameOver = true;

            Console.WriteLine("\n\nR to Restart? or you can choose 'Escape' for this.");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.R)
                    {
                        Game.Start();
                        Game.Run();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            #endregion
        }

        public static void GameOverParamOut()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("난 움직이는 것도 할 수 없었다.");
            Thread.Sleep(5000);
            Console.WriteLine("아.");
            Console.Beep(180, 1000);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("아.");
            Console.ResetColor();
            Console.Beep(200, 1000);
            Thread.Sleep(2000);
            string failed = "실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.실패했다.";
            Console.Clear();
            for(int i = 0; i <= 30; i++)
            {
                Console.Beep(700, 50);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(failed);
                Console.ResetColor();
            }
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠻⠫⠊⠉⠁⠀⠀⠈⠁⠁⠛⡙⢿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢙⡉⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⠈⠸⢗⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⠇⡰⠂⠔⠒⠌⠄⡀⠈⡀⠂⠠⠀⠀⢀⡀⠀⡀⠁⠈⢳⣏⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r");
            Thread.Sleep(5);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣋⢷⣭⣭⣌⣉⢉⠓⢢⠠⠀⠘⢂⠲⡋⣡⠀⠀⠐⢄⢠⣨⣟⣷⣝⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣿⡿⠿⣿⠽⢿⢷⣌⢠⠑⡇⠀⡆⢰⠔⠀⡦⣀⣳⣤⣭⣉⣤⣴⣿⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡯⠂⢧⠀⠈⢀⠀⠞⣿⣿⣾⣋⣸⢳⣼⡿⣶⣽⣿⣿⡿⠿⢿⢿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡱⠀⢂⣷⣆⠁⢂⠖⣩⣿⡿⣽⡯⢾⣯⣿⣿⣿⡿⠋⠀⠀⣀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r");
            Thread.Sleep(5);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⣫⢠⠎⠏⢁⠴⡁⠁⢻⣿⣿⢻⡀⢱⣿⡿⣿⣿⢥⠁⣠⣾⣿⡆⠀⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣧⠖⣀⢭⢀⢣⣄⣽⣿⣿⡿⠽⢰⠟⣯⣿⣿⣿⡿⣑⠈⠛⠟⠃⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠟⣟⣿⠿⣮⣷⢿⣻⡿⣫⢮⣶⡼⣷⣴⠻⣍⣿⣿⣿⣿⣷⣦⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡽⡆⠳⠮⠵⠖⡚⣉⣨⡾⣇⠹⣿⢓⢻⣿⣿⣻⣇⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣌⠡⣠⠖⢬⢾⣼⠏⡁⠋⢋⠁⠊⠀⠹⢷⠿⢿⣇⣿⢿⣏⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r");
            Thread.Sleep(5);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣧⡛⣵⣧⣟⢇⣵⣾⣷⣦⣶⣦⣕⣬⡀⠇⣻⣿⣻⣿⣯⢿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣗⣿⣟⡿⣿⣿⡿⣿⡿⣿⣿⣿⣿⣿⣗⡾⣿⡗⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⠿⣾⢸⢻⣿⢸⣷⣽⣥⢹⣇⣼⣏⣿⣿⣯⣿⣏⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡎⣿⢼⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣯⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡞⣧⡟⢼⣺⣿⣿⣿⣿⢿⡿⣿⢿⣿⣿⣿⣿⣿⡯⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⢿⣽⣹⢾⣿⣿⣿⡽⣿⣯⣼⣿⣿⣿⣿⣿⣿⡷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r");
            Thread.Sleep(5);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⣾⢼⣹⣿⢿⣿⣾⢭⣭⣭⣿⣿⣿⣿⣿⣷⡷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⢸⢻⣿⣻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡾⣍⠿⣿⣾⣼⣿⣾⣵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠻⣷⣩⢉⣻⢙⣛⠛⠿⢿⣟⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠹⠿⠿⡿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r");
            Thread.Sleep(5);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣵⣤⣢⣝⣬⣟⡿⣯⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⣭⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣾⡗⣿⡾⣽⣿⣯⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⢻⣎⣷⣿⢏⣼⣿⢿⡽⣞⣿⢿⣿⣾⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r" +
                            "\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡻⢝⢒⣬⣾⣿⡿⢋⣾⡿⣿⡷⣸⢿⣾⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣿⣿⣿⣿⣿⣿⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.Beep(180, 400); 
            Thread.Sleep(100);

            Console.Beep(130, 700);
            Thread.Sleep(150);

            Console.Beep(300, 100);
            Thread.Sleep(80);

            Console.Beep(220, 500);  
            Thread.Sleep(200);

            Console.Beep(170, 1000);
            Console.Beep(470, 100);
            Console.Beep(570, 100);
            Console.Beep(570, 1000);

            Console.WriteLine("G A M E O V E R");
            Console.ResetColor();
            gameOver = true;

            Console.WriteLine("\n\nR to Restart? or you can choose 'Escape' for this.");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.R)
                    {
                        Game.Start();
                        Game.Run();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }

        }
    }
}
