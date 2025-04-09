using System.Data;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public class Player
    {
        public Vector2 position;
        public bool[,] map;
        private Vector2 prevPosition = new Vector2(-1, -1); 
        public List<Item> inventory = new List<Item>(); // 인벤토리
        public bool inventoryVisible = false;
        public bool InventoryChanged { get; set; } = false;
        public MentalSystem mentalSystem = new MentalSystem();
        public void Print()
        {
            
            if (prevPosition.x >= 0 && prevPosition.y >= 0)
            {
                Console.SetCursorPosition(prevPosition.x, prevPosition.y);
                Console.Write(" ");
            }

            
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("♥"); 
            Console.ResetColor();

            
            prevPosition = new Vector2(position.x, position.y);
        }
        public void Move(ConsoleKey input)
        {
            Vector2 dir = new Vector2(0, 0);



            switch (input)
            {
                case ConsoleKey.UpArrow: dir = new Vector2(0, -1); break;
                case ConsoleKey.DownArrow: dir = new Vector2(0, 1); break;
                case ConsoleKey.LeftArrow: dir = new Vector2(-1, 0); break;
                case ConsoleKey.RightArrow: dir = new Vector2(1, 0); break;
            }

            Vector2 next = position + dir;

            if (next.y >= 0 && next.y < map.GetLength(0) &&
       next.x >= 0 && next.x < map.GetLength(1) &&
       map[next.y, next.x])
            {
                prevPosition = position;
                position = next;
            }


        }

        public void PrintInventoryWindow()
        {
            int x = 35;
            int y = 6;
            int maxLines = 10;

            for (int i = 0; i < maxLines; i++) //창 지우기
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(new string(' ', 25));
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x, y++);
            Console.WriteLine("┌────  마음 속 ────┐");

            if(inventory .Count == 0)
            {
                Console.SetCursorPosition(x, y++);
                Console.WriteLine("나의 마음은 비어있다.");
            }
            else
            {
                Console.SetCursorPosition(x, y++);
                Console.Write("|나의 마음에는..   |");
                foreach (Item item in inventory)
                {
                    Console.SetCursorPosition(x, y++);
                    Console.WriteLine($"|....{item.name,-12}|");
                    Console.SetCursorPosition(x, y++);
                    Console.WriteLine("|     가 느껴진다. |");
                }
            }
                Console.SetCursorPosition(x, y++);
                Console.WriteLine("└──────────────────┘");
            Console.ResetColor();
        }
        public void Additem(Item item)
        {
            inventory.Add(item);
            InventoryChanged = true;
        }

        public void ClearInventoryWindow()
        {
            int x = 35;
            int y = 2;
            int maxLines = 10;

            for (int i = 0; i < maxLines; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(new string(' ', 22));
            }
        }


    }
}
