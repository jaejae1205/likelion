using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study12
{
    class Program
    {
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int GetNumber()
        {
            return 42;
        }

        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        enum StatusCode
        {
            Seccess = 200,
            BadRequest = 400,
            Unaduthorizex = 401,
            NotFoune = 404
        }

        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            if(weapon == WeaponType.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");
            }

            else if (weapon == WeaponType.Bow)
            {
                Console.WriteLine("활을 선택했습니다.");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine("지팡이를 선택했습니다.");
            }
        }

        static void Main(string[] args)
        {
            //PrintHello();
            //PrintMessage("반갑습니다");

            //int num = GetNumber();
            //Console.WriteLine(num);
            //Greet();

            //StatusCode status = StatusCode.NotFoune;
            //Console.WriteLine(status);
            //Console.WriteLine((int) status);

            ChooseWeapon(WeaponType.Bow);
        }
    }
}
