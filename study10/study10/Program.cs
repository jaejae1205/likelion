using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] num = new int[3];

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            ////Console.WriteLine(num[0]);
            ////Console.WriteLine(num[1]);



            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = new int[] { 1, 2, 3 };

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}




            //int[] kor = new int[3];
            //int[] eng = new int[3];
            //int[] math = new int[3];

            //int[] sum = new int[3];
            //float[] aver = new float[3];



            //for (int i = 0; i < 3; i ++)
            //{
            //    Console.WriteLine("학생의 성적을 순서대로 입력하시오: ");
            //    Console.Write("국어: ");
            //    kor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어: ");
            //    eng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학: ");
            //    math[i] = int.Parse(Console.ReadLine());

            //    sum[i] = kor[i] + eng[i] + math[i];

            //    aver[i] = sum[i] / 3;

            //}


            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("1번 학생");
            //    Console.WriteLine($"국어: {kor[i]}, 영어: {eng[i]}, 수학: {math[i]}");
            //    Console.WriteLine("총점 : " + sum[i]);
            //    Console.WriteLine("평균 : " + aver[i].ToString("F2"));
            //}

            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{scores[i]}        ");
            //}

            /*double value = 123.456789;

            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점둘째자리:{value:F2}");*/

            //double value = 12314123.14124;

            //Console.Write(value.ToString("N2"));

            //int[,] matrix = new int[2, 3]
            //{
            //    {1,2,3 }, {4,5,6}
            //};

            //for(int i =0; i < 2; i++)
            //{


            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //}

            //int a = 10;
            //int b = 20;
            //int t = 0;
            //t = a;
            //a = b;
            //b = t;

            int[] iArray = new int[25];

            for(int i=0; i<25; i++)
            {
                iArray[i] = i + 1;
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }

            Random rand = new Random();

            for(int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;

            }
            Console.WriteLine("---------------------------");

            int input = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (iArray[i * 5 + j] == 0)
                        {
                            Console.Write(" *");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");

                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());

                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }

            }




        }
    }
}
