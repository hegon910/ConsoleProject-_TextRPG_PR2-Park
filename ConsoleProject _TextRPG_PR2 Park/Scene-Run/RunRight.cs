using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    class RunRight : BaseScene
    {
        List<Item> rightRoomItem = new List<Item>();
        

        private bool[,] map;
        private void InitMap(char[,] mapdata)
        {
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
                        "I, - : Door\n" +
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

        }
        #region 방구조

        char[,] mapdata = new char[,] //가로로 넓게 하기가 힘들다.
        //TODO: 디버깅용으로 빠른 탈출 공간 만듬. 나중에 지울것.
        {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#',' ','#',' ','I',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','#','W','h','I',' ',' ','#','N','o','I',' ',' ','#',' ',' ','#' },
                {'#',' ','#',' ','#',' ',' ','#','-','#','#',' ',' ','#',' ',' ','#','a','t','#',' ',' ','#','w','Y','#',' ',' ','#',' ',' ','#' },
                {'#',' ','#',' ','#',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#','c','a','#',' ',' ','#','o','u','#',' ',' ','#','#','-','#' },
                {'#',' ','#',' ','#',' ',' ','#','#','-','#',' ',' ','#',' ',' ','#','n','y','#',' ',' ','#','c','a','#',' ',' ','#',' ',' ','#' },
                {'#',' ','#',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','#','I','o','u','#',' ',' ','#','n','\'','#',' ',' ','#',' ',' ','#' },
                {'#',' ','I',' ','#','#','-','#','-','#','#',' ',' ','#',' ',' ','I','d','o','#',' ',' ','#','t','G','#',' ',' ','#',' ','#','#' },
                {'#',' ','#',' ','#',' ',' ','#',' ',' ','#',' ',' ','#','#',' ','#','J','u','#',' ',' ','#','o','B','#',' ',' ','#',' ',' ','#' },
                {'#',' ','#',' ','#',' ',' ','#','#','-','#',' ',' ','#',' ',' ','#','s','t','#',' ',' ','#','a','c','#',' ',' ','#','#',' ','#' },
                {'|',' ','#',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','#','#','R','u','#',' ',' ','#','k','L','#',' ',' ','#',' ',' ','#' },
                {'|',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ','I',' ',' ','#','n','!','#',' ',' ','I','O','L','#',' ',' ','I',' ',' ','#' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
        };

        #endregion
        public override void Input()
        {
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

        }

        public override void Render()
        {
            Console.SetCursorPosition(0, 0);



            Game.player.Print();


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

        }

        public override void Result()
        {
          
        }
        public override void Enter()
        {

            Console.Clear();
            InitMap(mapdata);
            Game.player.map = map;
            Game.player.position = new Vector2(1, 10);
            Game.player.mentalSystem.Reset();
            rightRoomItem.Clear();
            rightRoomItem.Add(new Item("끈기", 'A', new Vector2(30, 1)));
            Game.player.mentalSystem.Unlock();
        }

        public override void Update()
        {
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
                    Console.WriteLine($"\n\n\n       '{item.name}'를 얻었다. 이제는\n 그것을 마주할 것이다. \n" +
                        "       나를 쫓아오지 않았다. 나 혼자\n포기했던 것 뿐일까?\n" +
                        "       Press 'I' on keyboard to \nFeel Your Heart!");
                    Console.ResetColor();


                }
            }
            Game.player.mentalSystem.Update();


        }
    
        private void TryInteract(ConsoleKey key)
        {

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
            else
            {
                Game.player.Move(key); // 문 아니면 그냥 이동
            }
        }
    }
}
