using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로 변환: {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");

            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");

            //string defaultString = default;
            //int defaultInt = 0;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");

            //int a = 5, b = 3;
            //int sum = a % b;

            //bool isEqual = (a == b);

            //Console.WriteLine($"합: {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            //var adc = "안녕";

            //bool flag = true;
            //Console.WriteLine(!flag);
            //Console.WriteLine($"문자 :{adc} " + adc);

            //double pi = 3.14;
            //int integerPi = (int)pi;

            //Console.WriteLine(integerPi);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);

            //int a = 10;

            //a += 5;
            //Console.WriteLine(a);

            //Console.WriteLine("국어 점수를 입력하세요: ");
            //int language = int.Parse(Console.ReadLine());
            //Console.WriteLine("영어 점수를 입력하세요: ");
            //int english = int.Parse(Console.ReadLine());
            //Console.WriteLine("수학 점수를 입력하세요: ");
            //int math = int.Parse(Console.ReadLine());

            //int sum = language + english + math;
            //float avg = (float)sum / 3;

            //Console.WriteLine($"총점 : {sum} , 평균 : {avg:F2}");

            //Console.WriteLine("정수를 입력하세요: ");
            //int num = int.Parse(Console.ReadLine());
            //int num2 = ~num;

            //Console.WriteLine($"원래 값: {num} , 비트 반전 후의 값: {num2}");

            //int b = 3;
            //b++;
            //Console.WriteLine(b);


            //Console.WriteLine(--b);
            //Console.WriteLine(b);


            //int x = 5, y = 10;
            //Console.WriteLine(x < y);
            //Console.WriteLine(x == y);

            //bool a = true;
            //bool b = false;
            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(!a);


            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y);
            //Console.WriteLine(x | y);
            //Console.WriteLine(x ^ y);  //같은거는 0, 다른거는 1 출력: 0110
            //Console.WriteLine(~x);

            //int value = 4;
            //Console.WriteLine(value << 1);
            //Console.WriteLine(value >> 1);

            /*            int a = 10, b = 20;
                        int max = (a > b) ? a : b;   // true이면 처음꺼 출력, false이면 다음꺼 출력
                        Console.WriteLine(max);*/


            //int key = 2;
            //string str;
            //str = (key == 1) ? "문이열렸습니다" : "문을 열지 못했습니다";

            //Console.WriteLine(str);

            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);

            //int score = 95;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else
            //{
            //    Console.WriteLine("90점 미만");
            //}

            //    int score = 75;
            //    if (score >= 90)
            //    {
            //        Console.WriteLine("a");

            //    }
            //    else if (score >= 80)
            //    {
            //        Console.WriteLine("b");

            //    }
            //    else if(score >= 70)
            //    {
            //        Console.WriteLine("c");
            //    }
            //    else
            //    {
            //        Console.WriteLine("fail");
            //    }
            //}

            /*Console.Write("가지고 있는 소지금을 입력하세요: ");
            int money = int.Parse(Console.ReadLine());
            int attack = 0;
            string weapon = "";

            if (money >=0 && money <=100)
            {
                Console.WriteLine("무한의 대검을 획득하였습니다.");
                attack += 1;
                weapon = "무한의 대검";
            }
            else if (money >100 && money <= 200)
            {
                Console.WriteLine("카타나를 획득하였습니다.");
                attack += 2;
                weapon = "카타나";
            }
            else if (money > 200 && money <= 300)
            {
                Console.WriteLine("진은검을 획득하였습니다.");
                attack += 3;
                weapon = "진은검";
            }
            else if (money > 300 && money <= 400)
            {
                Console.WriteLine("집판검을 획득하였습니다.");
                attack += 4;
                weapon = "집판검";
            }
            else if (money > 400 && money <= 500)
            {
                Console.WriteLine("엑스칼리버를 획득하였습니다.");
                attack += 5;
                weapon = "엑스칼리버";
            }
            else if (money > 500 && money <= 600)
            {
                Console.WriteLine("유령검을 획득하였습니다.");
                attack += 6;
                weapon = "유령검";
            }
            else if (money > 600)
            {
                Console.WriteLine("전설의 검을 획득하였습니다.");
                attack += 7;
                weapon = "전설의 검";
            }

            Console.WriteLine();
            Console.WriteLine("<캐릭터 멋사검존>");
            Console.WriteLine($"무기 : {weapon}");
            Console.WriteLine($"공격력 : 100 + {attack}");*/

            //문제 1
            /*            Console.Write("3개의 정수를 입력하시오 (첫번째) : ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("3개의 정수를 입력하시오 (두번째) : ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("3개의 정수를 입력하시오 (세번째) : ");
                        int c = int.Parse(Console.ReadLine());

                        int large = 0;

                        if (a >= b)
                        {
                            large = a;
                        }
                        else if (a < b)
                        {
                            large = b;
                        }
                        if (large >= c)
                        {
                            Console.WriteLine($"최대값 : {large}");
                        }
                        else if (large < c)
                        {
                            Console.WriteLine($"최대값 : {c}");
                        }*/


            //문제 2
            /*            Console.Write("점수를 입력하시오 : ");
                        int score = int.Parse(Console.ReadLine());

                        if (score >= 90)
                        {
                            Console.WriteLine("A 학점");

                        }
                        else if (score >= 80)
                        {
                            Console.WriteLine("B 학점");

                        }
                        else if (score >= 70)
                        {
                            Console.WriteLine("C 학점");
                        }
                        else if (score >= 60)
                        {
                            Console.WriteLine("D 학점");
                        }
                        else
                        {
                            Console.WriteLine("F 학점");
                        }
            */

            //문제 3
            int answer = 0;
            Console.Write("첫번째 숫자를 입력하시오 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하시오 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("사용할 연산자를 입력하시오(+, -, *, /) : ");
            string op = Console.ReadLine();


            if (op == "+")
            {
                answer = num1 + num2;
            }
            else if (op == "-")
            {
                answer = num1 - num2;
            }
            else if (op == "*")
            {
                answer = num1 * num2;
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error");
                    return;
                }
                answer = num1 / num2;
                int remainder = num1 % num2;
                Console.Write($"결과 : {answer}, 나머지 : {remainder}");
                return;
            }

            Console.Write($"결과 : {answer}");


        }
    }
}
