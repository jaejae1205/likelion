using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TEXTRPG_TIMEATTACK
{
    class Field
    {
        Player player = null;
        Monster monster = null;

        public void SetPlayer(ref Player pPlayer)
        {
            player = pPlayer;
        }

        public void Progress()
        {
            while (true)
            {
                Console.Clear();

                player.Render();
                Map();

                while (true)
                {

                    int input = int.Parse(Console.ReadLine());
                    if (input <= 3)
                    {
                        CreateMonster(input);
                        Fight();
                    }
                    else if (input == 4)
                    {
                        break;
                    }
                }



            }
        }



        public void Map()
        {
            Console.WriteLine("1. 초급");
            Console.WriteLine("2. 중급");
            Console.WriteLine("3. 상급");
            Console.WriteLine("4. 이전");
            Console.WriteLine("난이도를 정하시오..");


        }

        public void Create(string str, int hp, int att, out Monster pmonster)
        {
            pmonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.name = str;
            tMonster.hp = hp;
            tMonster.attack = att;

            pmonster.SetMonster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 50, 5, out monster);
                    break;
                case 2:
                    Create("중수몹", 60, 10, out monster);
                    break;
                case 3:
                    Create("고수몹", 100, 15, out monster);
                    break;

            }
        }

        public void Fight()
        {
            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();

                Console.WriteLine("1. 싸운다  2. 도망간다");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    player.SetDamage(monster.GetMonster().attack);
                    monster.SetDamage(player.GetPlayer().attack);

                    if (player.GetPlayer().hp <= 0)
                    {
                        Console.WriteLine("게임 오버..");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }


                }
                else if (input == 2)
                {
                    break;
                }
            }

        }
    }
}
