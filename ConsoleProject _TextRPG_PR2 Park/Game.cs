using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        public static Player player = new Player();

        private static bool gameOver;
        public static void Run()
        {
            while (gameOver == false)
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
        }

        public static void Start()
        {
            gameOver = false;
            Console.CursorVisible = false;
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("FaceStress", new FaceStress());
            sceneDic.Add("RunLeft", new RunLeft());
            sceneDic.Add("RunRight", new RunRight());
            sceneDic.Add("RunDown", new RunDown());
            curScene = sceneDic["FaceStress"];


        }

        public static void ChangeScene(string sceneName)
        {
            Console.WriteLine("현재씬 :" + curScene);
            if (sceneDic.ContainsKey(sceneName))
            {
                curScene = sceneDic[sceneName];
                curScene.Enter();
            }
        }


        public static void End()
        { }
        public static void GameOver()
        {
            #region 엔딩 시퀀스
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine
               ("                                              평화로운 하루가 시작된다.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("                                            많은 일이 일어났던 것 같다." +
                "\n                                                      하지만...\n");
            Thread.Sleep(3500);
            Console.WriteLine("                               어떤 일이 일어났었는지, 왜 그런 기분인지 조차 생각나질 않는다.\n");
            Console.WriteLine();
            Thread.Sleep(2500);
            Console.WriteLine
               ("\n\n                                    평화로운 하  루   가 시작된다. 오늘은 날씨가 맑다.");
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

    }
}
