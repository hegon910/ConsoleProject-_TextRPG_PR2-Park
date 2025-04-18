﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    class RunRight : BaseScene
    {
        List<Item> rightRoomItem = new List<Item>();

        #region 방구조


        char[,] mapdata = new char[,] //가로로 넓게 하기가 힘들다.
        //TODO: 디버깅용으로 빠른 탈출 공간 만듬. 나중에 지울것.
        {
        
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#',' ',' ',':',' ',' ','#',' ',' ',':',' ',' ','#',' ',' ',':',' ',' ',' ',' ',' ','#',' ',' ',':',' ',' ','#',' ',' ','#' },
                {'#',' ',' ','#',' ',' ','#','‥','#','#',' ',' ','#',' ',' ','#','‥','#','#','#','#','#',' ',' ','#',' ',' ','#',' ',' ','#' },
                {'#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#' },
                {'#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#','#','#','#','#','‥','#',' ',' ','#',' ',' ','#','#','‥','#' },
                {'#',' ',' ','#',' ',' ','#','#','‥','#',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#' },
                {'#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','#','#','‥','#','#','#','#','#',' ',' ','#',' ',' ','#',' ',' ','#' },
                {'#',' ',' ','#','#','‥','#','‥','#','#',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#',' ','#','#' },
                {'#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#','#','#','#','#','‥','#',' ',' ','#',' ',' ','#',' ',' ','#' },
                {'#',' ',' ','#',' ',' ','#','#','‥','#',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#' },
                {'|',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','#','#','‥','#','#','#','#','#',' ',' ','#',' ',' ','#',' ',' ','|' },
                {'|',' ',' ','#',' ',' ',':',' ',' ','#',' ',' ',':',' ',' ','#',' ',' ',' ',' ',' ',':',' ',' ','#',' ',' ',':',' ',' ','|' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
        };

        #endregion
        private bool[,] map;
        private void InitMap(char[,] mapdata)
        {
            #region 맵준비
            for (int y = 0; y < mapdata.GetLength(0); y++)
            {
                for (int x = 0; x < mapdata.GetLength(1); x++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(mapdata[y, x]);
                    Console.ResetColor();
                }
                Console.WriteLine();

            }
            Console.WriteLine("오른쪽으로 도망쳤다...무기력하다...\n실패할 것이다.\n" +
                        "':', '-' is Door\n '#' is wall\n" +
                        "Press 'I' on keyboard to \nCheck your heart");


            int height = mapdata.GetLength(0);
            int width = mapdata.GetLength(1);
            map = new bool[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    map[y, x] = mapdata[y, x] != '#' &&
                                mapdata[y, x] != '[' &&
                                mapdata[y, x] != '←' &&
                                mapdata[y, x] != '^' &&
                                mapdata[y, x] != '|' &&
                                mapdata[y, x] != '→';
                            
                }
            }
            #endregion
        }

        public override void Input()
        {
            #region 키 입력 및 상호작용
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.I)
                {
                    Game.player.inventoryVisible = !Game.player.inventoryVisible;
                    Game.player.InventoryChanged = true;
                }
                else if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                {
                    TryInteract(key);
                }


                else
                {
                    Game.player.Move(key);
                }
            }
            #endregion
        }

        public override void Render()
        {
            Console.SetCursorPosition(0, 0);
            Game.player.Print();

            #region 인벤토리
            foreach (Item item in rightRoomItem)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(item.position.x, item.position.y);
                Console.Write(item.symbol);
                Console.ResetColor();
            }
            if (Game.player.InventoryChanged)
            {
                if (Game.player.inventoryVisible)
                {
                    Game.player.PrintInventoryWindow();
                }
                else
                {
                    Game.player.ClearInventoryWindow();
                }
                Game.player.InventoryChanged = false;
            }
            Game.player.mentalSystem.PrintMentalGauge();
            #endregion
        }

        public override void Enter()
        {
            Console.Beep(523, 50);
            Console.Beep(1046, 120);
            #region 아이템 습득
            Console.Clear();
            InitMap(mapdata);
            Game.player.map = map;
            Game.player.position = new Vector2(1, 10);
            Game.player.mentalSystem.Reset();
            rightRoomItem.Clear();
            rightRoomItem.Add(new Item("끈기", 'A', new Vector2(29, 1)));
            Game.player.mentalSystem.Unlock();
            #endregion
        }

        public override void Update()
        {
            #region 아이템 습득 후 조건 달성
            for (int i = 0; i < rightRoomItem.Count; i++)
            {
                Item item = rightRoomItem[i];
                if (item.position.x == Game.player.position.x &&
                    item.position.y == Game.player.position.y)
                {
                    Console.Beep(400, 50);
                    Console.Beep(400, 50);
                    Game.player.mentalSystem.RecoverFull();
                    Game.player.inventory.Add(item); // 인벤토리에 추가
                    rightRoomItem.RemoveAt(i);        // 리스트에서 제거
                    i--; // 제거했으니까 인덱스도 하나 줄여줘야 안전

                    int msgY = mapdata.GetLength(0);
                    Console.SetCursorPosition(0, msgY);
                    for (int j = 0; j < 3; j++)
                    {
                        Console.SetCursorPosition(0, msgY + j);
                        Console.Write(new string(' ', Console.WindowWidth));
                    }

                    Console.SetCursorPosition(0, msgY - 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\n\n'{item.name}'를 얻었다. 이제는\n그것을 마주할 것이다.                     \n" +
                        "나를 쫓아오지 않았다. 나 혼자\n포기했던 것 뿐일까?                          \n" +
                        "Press 'I' on keyboard to \nFeel Your Heart!");
                    Console.ResetColor();
                    #endregion

                }
            }
            Game.player.mentalSystem.Update();


        }
    
        private void TryInteract(ConsoleKey key)
        {
            #region 인터렉숀

            Vector2 dir = key switch
            {
                ConsoleKey.UpArrow => new Vector2(0, -1),
                ConsoleKey.DownArrow => new Vector2(0, 1),
                ConsoleKey.LeftArrow => new Vector2(-1, 0),
                ConsoleKey.RightArrow => new Vector2(1, 0),
                _ => new Vector2(0, 0)
            };

            Vector2 next = Game.player.position + dir;
            char tile = mapdata[next.y, next.x];

            if (tile == '|')
            {
                if (Game.player.inventory.Any(item => item.name == "끈기"))
                {
                    Console.SetCursorPosition(0, mapdata.GetLength(0) + 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n\n\n\n끈기를 갖고 끝까지 문을 열어보려 노력했다.");
                    Console.ResetColor();
                    Console.Beep(200, 700);
                    Thread.Sleep(300);
                    Console.Beep(180, 1000);
                    Thread.Sleep(1000);
                    Console.Beep(210, 1000);
                    Thread.Sleep(1000);
                    Console.Beep(300, 200);
                    Console.Beep(450, 300);
                    
                    Game.ChangeScene("FaceStress"); // 또는 다른 문으로 이동
                }
                else
                {
                    Console.SetCursorPosition(0, mapdata.GetLength(0) + 2);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n\n\n\n열리지 않는다... 문을 열 수가 없을 것 같다...");
                    Console.ResetColor();
                }
            }
            #endregion
            else
            {
                Game.player.Move(key); // 문 아니면 그냥 이동
            }
        }
    }
}
