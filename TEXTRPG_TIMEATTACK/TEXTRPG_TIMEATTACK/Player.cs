using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_TIMEATTACK
{
    public class Player
    {
        public INFO information;


        public void SelectJob()
        {
            information = new INFO();

            Console.WriteLine("직업을 선택하시오 : (1. 전사  2. 마법사  3. 도적 )");
            int Input = int.Parse(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    information.name = "전사";
                    information.attack = 20;
                    information.hp = 110;
                    break;
                case 2:
                    information.name = "마법사";
                    information.attack = 40;
                    information.hp = 90;
                    break;
                case 3:
                    information.name = "도적";
                    information.attack = 30;
                    information.hp = 100;
                    break;

            }
        }

        public void Render()
        {
            Console.WriteLine("============================");
            Console.WriteLine("직업 : " + information.name);
            Console.WriteLine("공격력 : " + information.attack);
            Console.WriteLine("체력 : " + information.hp);
        }

        public void SetDamage(int att)
        {
            information.hp -= att;
        }

        public INFO GetPlayer()
        {
            return information;
        }



        public Player(){}

        ~Player() { }


    }
}
