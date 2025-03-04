using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_3._04_
{

    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }

        public Warrior(string name, int score, int strength)
        {

            Name = name;
            Score = score;
            Strength = strength;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            //Warrior warrior = new Warrior("멋사", 100, 200);
            ////warrior.Name = "멋사";
            ////warrior.Score = 100;
            ////warrior.Strength = 200;

            //Console.WriteLine($"Name : {warrior.Name}, " +
            //    $"Score : {warrior.Score}, Strength : {warrior.Strength}");  


            //Console.Write("정수를 입력하시오 : ");

            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    Console.Write($"입력한 숫자 : {number}");
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}


            //List<string> fruits = new List<string>{ "사과", "바나나", "포도" };

            //Queue<string> que = new Queue<string>();
            //que.Enqueue("첫 번째 작업");
            //que.Enqueue("두 번째 작업");
            //que.Enqueue("세 번째 작업");

            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);

            //foreach (var fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Console.WriteLine("-----------------------");

            //while(que.Count > 0)
            //{
            //    Console.WriteLine(que.Dequeue());
            //}

            //Console.WriteLine("-----------------------");

            //while (numbers.Count > 0)
            //{
            //    Console.WriteLine(numbers.Pop());
            //}


            //Console.Write("문자열을 입력하시오 : ");
            //string str = Console.ReadLine();

            //Console.WriteLine($"대문자 : {str.ToUpper()}");
            //Console.WriteLine($"문자열 변경 : {str.Replace("C#", "CSharp")}");
            //Console.WriteLine($"문자열 길이 : {str.Length}");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine(numbers.Sum());


        }
    }
}
