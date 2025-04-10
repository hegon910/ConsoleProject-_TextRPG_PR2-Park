using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        public static string prevSceneName;
        public static Player player = new Player();
        private static bool mentalOut = false;


        private static bool gameOver;
        private static bool hasEnded = false;
        public static void Run()
        {
            while (gameOver == false)
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
            }
        }

        public static void Start()
        {
            #region 씬 준비
            gameOver = false;
            hasEnded = false;
            Console.CursorVisible = false;
            player = new Player();
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("FaceStress", new FaceStress());
            sceneDic.Add("RunLeft", new RunLeft());
            sceneDic.Add("RunRight", new RunRight());
            sceneDic.Add("RunDown", new RunDown());
            curScene = sceneDic["FaceStress"];
            #endregion

        }

        public static void ChangeScene(string sceneName)
        {
            #region 씬 전환

            Console.WriteLine("현재씬 :" + curScene);


            prevSceneName = curScene.GetType().Name;
            if (sceneDic.ContainsKey(sceneName))
            {
                curScene = sceneDic[sceneName];
                curScene.Enter();
            }
            #endregion
        }


        public static void End()
        {
            int feelCount = 0;
            if (Game.player.inventory.Any(i => i.name == "용기")) feelCount++;
            if (Game.player.inventory.Any(i => i.name == "끈기")) feelCount++;
            if (Game.player.inventory.Any(i => i.name == "통찰")) feelCount++;
            #region 게임 엔딩들
            if (hasEnded) return;
            hasEnded = true;
            Console.Clear();
            gameOver = true;
            if (feelCount ==3)
            {
                Endings.TrueEnding();
            }
            else if(feelCount ==2)
            {
                Endings.GoodEnding();
            }
                else if (Game.player.inventory.Any(item => item.name == "용기"))
            {
                Endings.EndingA();
            }
            else if (Game.player.inventory.Any(item => item.name == "끈기"))
            {
                Endings.EndingB();
            }
            else if (Game.player.inventory.Any(item => item.name == "통찰"))
            {
                Endings.EndingC();
            }
            else if(mentalOut)
            {
                Endings.GameOverParamOut();
            }
            else
            {
                Endings.GameOver();
            }
            #endregion
        }
         public static void MentalOut()
        {
            mentalOut = true;
        }


    }
}
