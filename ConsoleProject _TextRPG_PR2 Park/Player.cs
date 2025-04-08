namespace ConsoleProject__TextRPG_PR2_Park
{
    public class Player
    {
        public Vector2 position;
        public bool[,] map;
        private Vector2 prevPosition = new Vector2(-1, -1); // 클래스 안에 추가

        public void Print()
        {
            // 이전 위치 지우기
            if (prevPosition.x >= 0 && prevPosition.y >= 0)
            {
                Console.SetCursorPosition(prevPosition.x, prevPosition.y);
                Console.Write(" ");
            }

            // 현재 위치에 이모지 출력
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("♥"); // 
            Console.ResetColor();

            // 위치 기록
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


    }
}
