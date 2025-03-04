using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace study22
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("프로그램 종료");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");
            //Environment.Exit(0);

            //Random random = new Random();

            //int randomNumber = random.Next(1, 100);
            //Console.WriteLine(randomNumber);


            //Stopwatch stopwatch = Stopwatch.StartNew();

            //int valueType = 10;
            //int referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}"); //20
            //Console.WriteLine($"ReferenceType: {referenceType}");


            //object obj = "Hello";

            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); //false

            //object obj = "Hello";

            //string str = obj as string;

            //Console.WriteLine(str is string);

            //string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");


            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속할수있습니다.
            //try catch 

            //while (true)
            //{

            //    try
            //    {
            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine(numbers[5]); //오류 발생
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"Error : {ex.Message}");
            //    }
            //}

            //Exception 클래스 
            //모든예외의 기본 클래스입니다.

            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> list = new List<int>();

            //Stack 

            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}



            //ArrayList 생성
            //크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            ArrayList arrayList = new ArrayList();

            //요소추가
            arrayList.Add(1);  //정수
            arrayList.Add("Hello");  //문자열
            arrayList.Add(3.14);    //실수


            //요소 접근
            Console.WriteLine("ArrayList 요소: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //요소 제거
            arrayList.Remove(1);

            Console.WriteLine("\n ArrayList요소 제거 후: ");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
