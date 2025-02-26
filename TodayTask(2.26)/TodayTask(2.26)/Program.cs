using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_2._26_
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Q1
            //int[] num = new int[5];

            //num[0] = 10; num[1] = 20; num[2] = 30; num[3] = 40; num[4] = 50;

            //for(int i =0; i < 5; i++)
            //{
            //    Console.Write(num[i] + " ");
            //}


            //Q2

            //int[] num = new int[5];
            //int sum = 0;
            //Console.WriteLine("정수 5개를 차례대로 입력하세요 : ");

            //for (int i = 0; i < 5; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //    sum += num[i];
            //}

            //Console.WriteLine($"총 합 : {sum}");


            //Q3

            //int[] num = { 3, 8, 15, 6, 2 };
            //int large = 0;

            //foreach (int n in num)
            //{
            //    if (n > large)
            //    {
            //        large = n;
            //    }
            //}
            //Console.WriteLine("{ 3, 8, 15, 6, 2 }");
            //Console.WriteLine("가장 큰 값 : " + large);


            //Q4

            //for(int i = 0; i < 10; i ++)
            //{
            //    Console.Write(i + 1 +" ");
            //}

            //Q5

            //for(int i = 1; i < 11; i++)
            //{
            //    while (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //        break;
            //    }
            //}


            //Q6

            //int[] num = { 1, 2, 3, 4, 5 };

            //foreach(int n in num)
            //{
            //    Console.WriteLine(n);
            //}


            //Q7

            //Console.WriteLine("두개의 정수를 입력하시오");
            //Console.Write("첫번째 : ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("두번째 : ");
            //int b = int.Parse(Console.ReadLine());

            //int result = Add(a, b);
            //Console.WriteLine($"{a}과 {b}의 합 : " + result);


            //Q8

            //Console.Write("문자열 입력 : ");
            //string word = Console.ReadLine();
            //int word_length = Length(word);
            //Console.WriteLine("문자열 길이 : " + word_length);


            //Q9

            Console.Write("세 개의 정수를 차례대로 입력하시오 : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("가장 큰 수 : " + Large(a, b, c));

        }

        static int Large(int n1, int n2, int n3)
        {
            int large = n1;
            if (n2 > large) large = n2;
            if (n3 > large) large = n3;
            return large;
        }


        static int Length(string word)
        {
            return word.Length;
        }



        static int Add(int a, int b)
        {
            return (a + b);
        }

    }
}
