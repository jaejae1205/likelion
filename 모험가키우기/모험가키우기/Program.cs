using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace 모험가키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rand = new Random();
            int health = 100, gold = 700, power = 10;
            bool isAlive = true;

            Console.WriteLine(" 모험가 키우기 ");
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 상태: 체력 {health} | 골드 {gold} | 공격력 {power}");
                Console.WriteLine("\n1. 탐험하기 ");
                Console.WriteLine("2. 장비 뽑기 🎲 (1000골드)");
                Console.WriteLine("3. 휴식하기 (체력 +20)");
                Console.WriteLine("4. 게임 종료 ");
                Console.Write("입력: ");

                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다.");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다..");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다....");
                    Thread.Sleep(1000);

                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 20)
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($" 몬스터를 만났습니다! (체력 -{damage})");
                        health -= damage;
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(100, 301);
                        Console.WriteLine($"보물을 발견했습니다! (+{reward})");
                        gold += reward;

                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($" 신비한 약초를 발견했습니다! (+{heal})");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n체력이 0이 되어 사망했습니다.... 게임 오버");
                        Thread.Sleep(1000);
                        isAlive = false;
                    }
                    Thread.Sleep(3000);
                }  //input 1
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine(" 장비를 뽑습니다...");
                        Thread.Sleep(2000);

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 전설의 검 (공격력 +30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 전설의 검 (공격력 +10) 획득!");
                            power += 10;
                        }
                        else
                        {
                            Console.WriteLine("SS급 전설의 검 (공격력 +5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. 1000 골드 필요");
                        Thread.Sleep(2000);
                    }


                } //input 2

                else if (input == 3)
                {
                    Console.WriteLine("휴식을 취합니다...(+20 체력)");
                    health += 20;
                    Thread.Sleep(2000);

                }  //input 3
                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다..");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요. ");
                    Thread.Sleep(1000);
                }
                
                    
            }

        }
    }
}
