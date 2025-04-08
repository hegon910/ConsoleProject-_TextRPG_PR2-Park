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
        private bool[,] map;
        private void InitMap(char[,] mapdata)
        {
            int height = mapdata.GetLength(0);
            int width = mapdata.GetLength(1);
            map = new bool[height, width];
            
            for (int y=0; y<height; y++)
            {
                for(int x =0; x<width; x++)
                {
                    map[y, x] = mapdata[y, x] != '#';
                }
            }
        }
        public override void Input()
        {
            
        }

        public override void Render()
        {

            Console.Clear(); //플리커링, 입력 대기받으면 개선될것으로 추정.
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("왼쪽방");
            #region 방구조
           
            char[,] mapdata = new char[,] //가로로 넓게 하기가 힘들다.
            {
                {'#','#',' ','#','#','#','#','[','-',']','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
            };
            
            #endregion
            InitMap(mapdata);
            for(int y = 0; y<mapdata.GetLength(0); y++) // 맵그리기
            {
                for(int x = 0; x<mapdata.GetLength(1); x++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(mapdata[y, x]);
                    Console.ResetColor();
                }
                Console.WriteLine();

            }
          
        }


        public override void Result()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
