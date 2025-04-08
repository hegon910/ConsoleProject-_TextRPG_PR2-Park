namespace ConsoleProject__TextRPG_PR2_Park
{
   
    internal class Program
    {                   //✅ 기능 완성도   전투, 선택지, 승패 구조가 끝까지 잘 동작
                        //✅ 코드 구조 클래스, 메서드 분리가 깔끔(하드코딩 피하기)
                        //✅ 에러 처리 잘못된 입력 시도에도 크래시 없이 처리
                        //✅ 반복 가능 루프 구조가 명확, 다시 시작도 가능하면 플러스
                        //✅ 읽기 쉬움 변수/메서드 명 직관적, 불필요한 중복 없음
        static void Main(string[] args)
        {


            Game.Start();


            Game.Run();


            Game.End();
        }

    }
}

