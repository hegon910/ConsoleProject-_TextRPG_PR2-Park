using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public class Player
    {
        public Vector2 position;
        public bool[,] map;

        public void Print()
        {
            Dictionary<char, string> tileEmojis = new Dictionary<char, string>
            {
                {'P', "P" }
            };
            char tile = 'P';
            string output = tileEmojis.ContainsKey(tile) ? tileEmojis[tile] : tile.ToString();
            Console.SetCursorPosition(position.y, position.x);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(output);
            Console.ResetColor();
        }
        public void Move(ConsoleKey input)
        {
            Vector2 dir = new Vector2(0, 0);

      

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    position.y--;
                    break;
                case ConsoleKey.DownArrow:
                    position.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    position.x--;
                    break;
                case ConsoleKey.RightArrow:
                    position.x++;
                    break;
            }

            Vector2 next = position + dir;

            if (map!= null && next.y >=0 && next.y < map.GetLength(0) && next.x>=0 && next.x < map.GetLength(1) && map[next.y, next.x])
            {
                position = next;
            }

            
        }

        
    }
}
