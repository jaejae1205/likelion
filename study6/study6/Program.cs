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

            int a = 5, b = 3;
            int sum = a % b;

            bool isEqual = (a == b);

            Console.WriteLine($"합: {sum}");
            Console.WriteLine($"a와 b가 같은가? {isEqual}");




        }
    }
}
