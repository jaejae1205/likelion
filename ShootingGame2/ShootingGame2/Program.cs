using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    struct Player
    {
        public int X;
        public int Y;
        public string[] player;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            player = new string[]
            {
                "->",
                ">>>",
                "->",
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); 
            Console.SetBufferSize(80, 25); 


            ConsoleKeyInfo keyInfo;

            Player player = new Player(0, 12);

            Console.CursorVisible = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;




            while (true)
            {

                long currentSecond = stopwatch.ElapsedMilliseconds; 


                if (currentSecond - prevSecond >= 100)
                {

                    Console.Clear();

                    if (Console.KeyAvailable) //키가 눌렸을때 true
                    {
                        keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)
                                                         //방향키 입력에 따른 좌표 변경
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (player.Y > 0) player.Y--; break;
                            case ConsoleKey.DownArrow: if (player.Y < Console.WindowHeight - 1) player.Y++; break;
                            case ConsoleKey.LeftArrow: if (player.X > 0) player.X--; break;
                            case ConsoleKey.RightArrow: if (player.X < Console.WindowWidth - 1) player.X++; break;
                            case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                            case ConsoleKey.Escape: return; //ESC키로 종료 

                        }

                    }


                    for (int i = 0; i < player.player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(player.X, player.Y + i);
                        //문자열배열 출력
                        Console.WriteLine(player.player[i]);
                    }



                    prevSecond = currentSecond;//이전 시간 업데이트
                }

            }

        }
    }
}