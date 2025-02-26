using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study11
{
    class Program
    {

        static void Loading()
        {
            Console.WriteLine("로딩화면");
        }


        static void AttackFunction(int a)
        {

            Console.WriteLine("공격력은 : " + a);
        }

        static int BaseAttack()
        {
            int attack = 10;

            return attack;


        }

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static void Main(string[] args)
        {
            //int Attack = 0;
            //int bAttack = 0;

            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            //bAttack = BaseAttack();

            //AttackFunction(bAttack + Attack);


            //int result = Add(10, 20);
            //Console.WriteLine($"10+20 = {result}");


            string[] fruits = { "사과", "바나나", "체리" };

            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }



        }
    }
}
