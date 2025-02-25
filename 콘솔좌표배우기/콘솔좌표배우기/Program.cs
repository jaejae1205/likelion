using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {

            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            //콘솔 버퍼 크기 설정(스크롤 없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false;

            Console.Clear(); //화면 지우기
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                                  FIFA 1994                                   ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");




            Thread.Sleep(10000);
            Console.Clear();
            Random rand = new Random();
            Console.Write("EA sports..");
            Thread.Sleep(3000);
            Console.Clear();

            bool isTrue = true;



            Console.CursorVisible = true;
            Console.Write("1. 나라를 입력하시오 : ");
            string country = Console.ReadLine();
            Console.Clear();
            Console.Write("2. 선수 이름을 입력하시오 : ");
            string player = Console.ReadLine();
            Console.Clear();

            while (isTrue)
            {
                int rnd = rand.Next(1, 4);
                Console.Clear(); //화면 지우기
                Console.SetCursorPosition(0, 0);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(0, 1);
                Console.Write("┃                                                 ┃");
                Console.SetCursorPosition(0, 2);
                Console.Write("┃                                                 ┃");
                Console.SetCursorPosition(0, 3);
                Console.Write("┃                                                 ┃");
                Console.SetCursorPosition(0, 4);
                Console.Write("┃                       ^-^                       ┃");
                Console.SetCursorPosition(0, 5);
                Console.Write("┃                        │                        ┃");
                Console.SetCursorPosition(0, 6);
                Console.Write("┃                       / \\                       ┃");
                Console.SetCursorPosition(0, 7);
                Console.Write("┃                                                 ┃");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.CursorVisible = true;
                Console.Write("\n차고 싶은 방향을 정하시오 ( 1. 왼쪽  2. 중앙  3. 오른쪽 ) : ");
                int dir = int.Parse(Console.ReadLine());


                if (dir == rnd)
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.Write("골~~~~~~~~~~~~~~~~");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.Write($"{player} 선수의 환상적인 페널티 킥!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.Write($"{country} 우승!!!!!");
                    Thread.Sleep(3000);
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine($"아.. {player} 선수의 실축..");
                    Thread.Sleep(2000);
                    Console.Write("다시 한번 기회가 주어집니다. 이번에는 넣을 수 있을까요?!");
                    Thread.Sleep(2000);
                }

            }

        }
    }
}
