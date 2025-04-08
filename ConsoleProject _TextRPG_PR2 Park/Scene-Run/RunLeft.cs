using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    class RunLeft : BaseScene
    {
        List<Item> leftRoomItem = new List<Item>();
       
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
            
                
   
                

            
            int height = mapdata.GetLength(0);
            int width = mapdata.GetLength(1);
            map = new bool[height, width];
            
            for (int y=0; y<height; y++)
            {
                for(int x =0; x<width; x++)
                {
                    map[y, x] = mapdata[y, x] != '#' &&
                                mapdata[y, x] != '[' &&
                                mapdata[y, x] != '←' &&
                                mapdata[y, x] != '^' &&
                                mapdata[y, x] != '|' &&
                                mapdata[y, x] != '→' &&
                                mapdata[y, x] != 'F' &&
                                mapdata[y, x] != 'a' &&
                                mapdata[y, x] != 'c' &&
                                mapdata[y, x] != 'e' &&
                                mapdata[y, x] != 'i' &&
                                mapdata[y, x] != 't' &&
                                mapdata[y, x] != '!' &&
                                mapdata[y, x] != ']';
                }
            }
            
        }
        public override void Input()
        {
            if(Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if(key==ConsoleKey.I)
                {
                    Game.player.inventoryVisible = !Game.player.inventoryVisible;
                    Game.player.InventoryChanged = true;
                }
                else if(key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                {
                    TryInteract(key);
                }


                else
                {
                    Game.player.Move(key);
                }
            }
            
        }
        public override void Enter()
        {
            Console.Clear();
            InitMap(mapdata);
            Game.player.map = map;
            Game.player.position = new Vector2(30, 1);

            leftRoomItem.Clear();
            leftRoomItem.Add(new Item("용기", 'B', new Vector2(3, 10)));
        }
        #region 방구조

        char[,] mapdata = new char[,] //가로로 넓게 하기가 힘들다.
        {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#','#',' ',' ','I',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','|' },
                {'#','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','→','|' },
                {'#','#','^',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','F','#' },
                {'#','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','a','#' },
                {'#','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','c','#' },
                {'#','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','e','#' },
                {'#','#','-','^','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#' },
                {'#','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','i','#' },
                {'#','#','#',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','t','#' },
                {'#','#','#',' ','#',' ',' ','I',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','#',' ',' ','I',' ',' ','#',' ',' ','I',' ','!','#' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
        };

        #endregion

        public override void Render()
        {

             //플리커링, 입력 대기받으면 개선될것으로 추정.
            Console.SetCursorPosition(0, 0);
            
         

            Game.player.Print();


            foreach (Item item in leftRoomItem)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(item.position.x, item.position.y);
                Console.Write(item.symbol);
                Console.ResetColor();
            }
            if( Game.player.InventoryChanged)
            {
                if (Game.player.inventoryVisible)
                {
                    Game.player.PrintInventoryWindow();
                }
                else {
                    Game.player.ClearInventoryWindow();
                        }
                    Game.player.InventoryChanged = false;
            }
            


        }


        public override void Result()
        {
            
        }

        public override void Update()
        {
            for (int i = 0; i < leftRoomItem.Count; i++)
            {
                Item item = leftRoomItem[i];
                if (item.position.x == Game.player.position.x &&
                    item.position.y == Game.player.position.y)
                {
                    Game.player.inventory.Add(item); // 인벤토리에 추가
                    leftRoomItem.RemoveAt(i);        // 리스트에서 제거
                    i--; // 제거했으니까 인덱스도 하나 줄여줘야 안전

                    Console.SetCursorPosition(0, mapdata.GetLength(0) + 2);
                    if (Game.player.inventory.Any(item => item.name == "용기"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n\n\n'{item.name}'을(를) 얻었다. 이제는 그것을 마주할 것이다." +
                          "       I, - : Door\n" +
                          "       Press 'I' on keyboard to check your Emotion");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("       왼쪽으로 도망쳤다...쫓기고 있다... 무섭다.\n" +
                          "       I, - : Door\n" +
                          "       Press 'I' on keyboard to check your Emotion");
                    }
                }
            }
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
                if (Game.player.inventory.Any(item => item.name == "용기"))
                {
                    Console.SetCursorPosition(0, mapdata.GetLength(0) + 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n\n\n\n용기를 내어 문을 열었다!");
                    Console.ResetColor();
                    Game.ChangeScene("FaceStress"); // 또는 다른 문으로 이동
                }
                else
                {
                    Console.SetCursorPosition(0, mapdata.GetLength(0) + 2);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n\n\n\n문을 열기엔 아직 마음의 준비가 되지 않았다...");
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
