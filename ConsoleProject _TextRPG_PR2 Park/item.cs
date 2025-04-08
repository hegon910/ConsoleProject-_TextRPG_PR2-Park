using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public class Item
    {
        public string name;
        public char symbol;
        public Vector2 position;

        public Item(string name, char symbol, Vector2 position)
        {
            this.name = name;
            this.symbol = symbol;
            this.position = position;
        }
    }
}
