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

        public static void EndingB()
        {
            Console.WriteLine("엔딩B");
        }
        public static void EndingC()
        {
            Console.WriteLine("엔딩C");
        }

        
        public static void TrueEnding()
        {
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
        }

        public static void GoodEnding()
        {
            Console.WriteLine("굿엔딩");
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

            Console.WriteLine("\n\nR to Restart? or you can chose 'Escape' for this.");

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

            Console.WriteLine("\n\nR to Restart? or you can chose 'Escape' for this.");

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
