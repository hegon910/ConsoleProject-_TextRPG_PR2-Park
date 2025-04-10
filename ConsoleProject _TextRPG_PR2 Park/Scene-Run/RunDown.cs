using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    class RunDown : BaseScene
    {
        List<Item> downRoomItem = new List<Item>();
        List<char> visitedOrder = new List<char>();
        char[] correctOrder = { '①','②' , '③', '④', '⑤' };
        bool itemShow = false;
        #region 방구조

        char[,] mapdata = new char[,] //가로로 넓게 하기가 힘들다.
        //TODO: 디버깅용으로 빠른 탈출 공간 만듬. 나중에 지울것.
        {
                {'#','━','━','#','#','─','─','#','#','─','─','#','#','─','─','#','#','─','─','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','|','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','|','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#','#',' ',' ','#'},
                {'#',' ',' ','①','#',' ',' ','④','#',' ',' ','②','#',' ',' ','③','#',' ',' ','⑤'},
                {'#','2','4','#','#','3','5','#','#','1','4','#','#','5','1','#','#','2','3','#'}
        };

        #endregion

        private bool[,] map;
        private void InitMap(char[,] mapdata)
        {
            #region 맵 준비 
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
            Console.WriteLine("아래로 도망쳤다..문제를 풀 수 없다\n무능한 내가 싫다.\n" +
                        "Move to '1,2,3,4' to Warp Room\nPress  '①','②' , '③', '④', '⑤' to Get Feel" +
                        "Press 'I' on keyboard to \nCheck your heart");


            int height = mapdata.GetLength(0);
            int width = mapdata.GetLength(1);
            map = new bool[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    map[y, x] = mapdata[y, x] != '#' &&
                                mapdata[y, x] != '─' &&
                                mapdata[y, x] != '━' &&
                                mapdata[y, x] != '1' &&
                                mapdata[y, x] != '2' &&
                                mapdata[y, x] != '3' &&
                                mapdata[y, x] != '4' &&
                                mapdata[y, x] != '5' &&
                                mapdata[y, x] != '①' &&
                                mapdata[y, x] != '②' &&
                                mapdata[y, x] != '③' &&
                                mapdata[y, x] != '④' &&
                                mapdata[y, x] != '⑤';


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
            foreach (Item item in downRoomItem)
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



        public override void Update()
        {
            #region 아이템 습득 후 조건 달성
            for (int i = 0; i < downRoomItem.Count; i++)
            {
                Item item = downRoomItem[i];
                if (item.position.x == Game.player.position.x &&
                    item.position.y == Game.player.position.y)
                {
                    Console.Beep(523, 50);
                    Console.Beep(1046, 120);
                    Game.player.mentalSystem.RecoverFull();
                    Game.player.inventory.Add(item); // 인벤토리에 추가
                    downRoomItem.RemoveAt(i);        // 리스트에서 제거
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
                    Console.WriteLine($"\n\n\n'{item.name}'를 얻었다. 이제는\n 방법을 알 것 같다.                                  \n" +
                        "어려워 보였지만                                                         \n정답은 언제나 존재한다     \n" +
                        " Press 'I' on keyboard to \nFeel Your Heart!                                                       ");
                    Console.ResetColor();
                    
                       
                   
                }
        
                #endregion

            }
            Game.player.mentalSystem.Update();
        }

        public override void Enter()
        {
            Console.Beep(1500, 50);
            Console.Beep(1500, 50);
            #region 플레이어 셋
            Console.Clear();
            InitMap(mapdata);
            Game.player.map = map;
            Game.player.position = new Vector2(1, 2);

            Game.player.mentalSystem.Reset();
            Game.player.mentalSystem.Unlock();
            #endregion
        }
        private void TryInteract(ConsoleKey key)
        {
            #region 인터렉션
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
            if(char.IsDigit(tile))
            {
               
                Game.player.position = next;
                DoorInteract();
            }

            if (tile == '━'||tile=='|')
            {
                #region 루팅시 방 해금
                if (Game.player.inventory.Any(item => item.name == "통찰"))
                {
                    Console.SetCursorPosition(0, mapdata.GetLength(0) + 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n\n\n\n 침착하게 문고리를 막고 있던 장애물을 제거한다.");
                    Console.ResetColor();
                    Console.Beep(200, 700);
                    Thread.Sleep(300);
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
                    Console.WriteLine("\n\n\n\n\n마음이 급하다... 문이 열리질 않는다...");
                    Console.ResetColor();
                }
            }
            #endregion
            else
            {
                
                Game.player.Move(key); // 문 아니면 그냥 이동
              
            }
            CheckRoomNum(next);
            #endregion


        }
        public void DoorInteract()
        {
            #region 문 번호 간 이동
            Vector2 prevPos = new Vector2(Game.player.position.x, Game.player.position.y);
            //플레이어가
            char tile = mapdata[prevPos.y, prevPos.x];
            Console.SetCursorPosition(prevPos.x, prevPos.y-1);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(' ');
            Console.ResetColor();
            //숫자에 겹치면 이동
            switch (tile)
            {
                case '1':
                    Console.Beep(450, 50);
                    Console.Beep(500, 30);
                    Game.player.position = new Vector2(2, 1);
                    break;
                case '2':
                    Console.Beep(450, 50);
                    Console.Beep(500, 30);
                    Game.player.position = new Vector2(10, 1);
                    break;
                case '3':
                    Console.Beep(450, 50);
                    Console.Beep(500, 30);
                    Game.player.position = new Vector2(14, 1);
                    break;
                case '4':
                    Console.Beep(450, 50);
                    Console.Beep(500, 30);
                    Game.player.position = new Vector2(6, 1);
                    break;
                case '5':

                    Console.Beep(450, 50);
                    Console.Beep(500, 30);
                    Game.player.position = new Vector2(17, 1);
                    break;
            }
            #endregion
        }
        public void CheckRoomNum(Vector2 playerPos)
        {
            #region 번호 누르기 퍼즐(?)
            if (playerPos.y<mapdata.GetLength(0) && playerPos.x < mapdata.GetLength(1))
            {
                char tile = mapdata[playerPos.y, playerPos.x];

                if ("①②③④⑤".Contains(tile))
                {
                    if (visitedOrder.Count == 0 || visitedOrder.Last() != tile)
                    {
                        visitedOrder.Add(tile);

                        for (int y = 0; y < mapdata.GetLength(0); y++)
                        {
                            for (int x = 0; x < mapdata.GetLength(1); x++)
                            {
                                if (mapdata[y, x] == tile)
                                {
                                    Console.Beep(650, 50);
                                    Console.Beep(700, 30);
                                    Console.SetCursorPosition(x, y);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(tile);
                                    Console.ResetColor();
                                }
                            }
                        }

                        //순서체크
                        if (visitedOrder.Count == correctOrder.Length)
                        {
                            bool isCorrect = true;
                            for (int i = 0; i < correctOrder.Length; i++)
                            {
                                if (visitedOrder[i] != correctOrder[i])
                                {
                                    isCorrect = false;
                                    break;
                                }
                            }
                            if (isCorrect)
                            {
                                itemShow = true;
                                downRoomItem.Add(new Item("통찰", 'C', new Vector2(17, 3)));
                            }
                            else
                            {
                                visitedOrder.Clear();
                                Console.SetCursorPosition(0, mapdata.GetLength(0) + 5);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("처음부터 다시 해야할 것 같다..");
                                Console.ResetColor();
                            }
                        }
                    }
                }
            }

            #endregion
        }


    }
    
}
