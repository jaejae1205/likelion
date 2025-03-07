using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_3._6_
{
    class Field
    {
        Player p1 = null;

        Monster monster = null;


        public void SetPlayer(ref Player pPlayer)
        {
            p1 = pPlayer;
        }

        public void Progress()
        {
            while (true)
            {
                Console.Clear();

                p1.Render();
                DrawMap();

                int input = int.Parse(Console.ReadLine());

                if (input == 4) break;

                if(input <= 3)
                {
                    Createmonster(input);
                    Fight();

                }
            }

        }

        public void Create(string str, int hp, int att , out Monster pmonster)
        {
            pmonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.Name = str;
            tMonster.Hp = hp;
            tMonster.Attack = att;

            pmonster.SetMonster(tMonster);//

        }

        public void Createmonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out monster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out monster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out monster);
                    break;

            }
        }

        public void Fight()
        {
            while (true)
            {
                Console.Clear();
                p1.Render();
                monster.Render();

                Console.WriteLine("1.공격 2.도망");
                int input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    p1.SetDamage(monster.GetMonster().Attack);
                    monster.SetDamage(p1.GetInfo().Attack);

                    if(p1.GetInfo().Hp <= 0)
                    {
                        p1.SetHp(100);
                        break;
                    }
                }

                if (input == 2 || monster.GetMonster().Hp <= 0)
                {
                    monster = null;
                    break;
                }
            }
        }


        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
