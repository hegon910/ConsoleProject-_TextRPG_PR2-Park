using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public class MentalSystem
    {
        private int mental;
        private int maxMental;
        private DateTime lastTick;
        private double intervalSeconds;
        private bool isLocked = false;

        public bool IsBroken => mental <= 0;
        public MentalSystem(int maxMental = 100, double intervalSecond = 0.1)
        {
            this.maxMental = maxMental;
            this.mental = maxMental;
            this.intervalSeconds = intervalSecond;
            this.lastTick = DateTime.Now;
        }

        public void Update()
        {
            if (isLocked) return;
            if ((DateTime.Now - lastTick).TotalSeconds >= intervalSeconds)
            {
                mental -= 1;
                if (mental < 0) mental = 0;
                lastTick = DateTime.Now;

               
            }
            if(mental == 0)
            {
                Game.MentalOut();
                Game.End();
               
            }
        }

        public void PrintMentalGauge()
        {
            int x = 35;
            int y = 1;
            Console.SetCursorPosition(x, y++);
            if (mental > 90)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (mental > 80)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else if (mental >60)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (mental >30)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            else if (mental >=20 )
                Console.ForegroundColor = ConsoleColor.Red;
            else if (mental <20)
                Console.ForegroundColor = ConsoleColor.DarkRed;


                Console.WriteLine("┌─ Your Heart ─────┐");

            string bar = new string('■', Math.Max(0, mental / 10)).PadRight(10, ' ');
            Console.SetCursorPosition(x, y++);
            Console.WriteLine($"|[{bar}]{mental}%|");

            Console.SetCursorPosition(x, y++);
            if (mental < 30)
                Console.WriteLine("|난 실패한다.         ");
            else if (mental < 70)
                Console.WriteLine("|불안해진다.          ");
            else
                Console.WriteLine("|마음이 안정된다.      ");
            Console.SetCursorPosition(x, y++);
            Console.WriteLine("└──────────────────┘");
            Console.ResetColor();
        }
        public void RecoverFull()
        {
            isLocked = true;
            mental = maxMental;
        }
        public void Unlock()
        {
            isLocked = false;
        }
        public void Reset()
        {
            mental = maxMental;
            lastTick = DateTime.Now.AddSeconds(1);
        }
    }
}
