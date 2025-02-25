using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {

            //int day = 1;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않는 요일");
            //        break;
            //}



            //Console.Write("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적");
            //int num = int.Parse(Console.ReadLine());
            //int att, def;

            //switch(num){
            //case 1:
            //att = 100;
            //def = 90;
            //break;
            //case 2:
            //att = 110;
            //def = 80;
            //break;
            //case 3:
            //att = 115;
            //def = 70;
            //break;

            //}
            //int k=0;
            //for(int i =0; i<=9; i++)
            //{
            //    k += i;

            //}
            //Console.WriteLine(k);

            //int count = 1;

            //while (count <= 5)
            //{
            //    Console.WriteLine("Count : " + count);
            //    count++;
            //}

            //Random rand = new Random();

            //int rnd;

            //rnd = rand.Next(1, 101);

            //if (rnd >= 1 && rnd <= 10)
            //{
            //    Console.WriteLine("도끼등급 SSS");
            //}
            //else if (rnd >= 11 && rnd <= 40)
            //{
            //    Console.WriteLine("도끼등급 SS");
            //}
            //else
            //{
            //    Console.WriteLine("도끼등급 S");
            //}
            //Thread.Sleep(500);

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다");
            //    x--;
            //} while (x > 0);

            //for(int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //for(int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            int n = 1;

            start:
            if (n < 5)
            {
                Console.WriteLine(n);
                n++;

                goto start;

            }


        }
    }
}
