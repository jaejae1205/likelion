using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_3._6_
{
    public class Player
    {
        public INFO Information;


        public void SelectJob()
        {
            Information = new INFO();

            Console.WriteLine("직업을 선택하세요(1. 전사 2. 마법사 3. 도적)");
            int Input = int.Parse(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    Information.Name = "전사";
                    Information.Attack = 10;
                    Information.Hp = 100;
                    break;
                case 2:
                    Information.Name = "마법사";
                    Information.Attack = 15;
                    Information.Hp = 90;
                    break;
                case 3:
                    Information.Name = "도적";
                    Information.Attack = 13;
                    Information.Hp = 85;
                    break;
            }
        }

        public void SetDamage(int Att)
        {
            Information.Hp -= Att;
        }

        public INFO GetInfo()
        {
            return Information;
        }

        public void SetHp(int iHp)
        {
            Information.Hp = iHp;
        }

        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("직업 이름 : "+ Information.Name);
            Console.WriteLine("체력: " + Information.Hp + "\t공격력 : " + Information.Attack);
            
        }

        public Player() { }

        ~Player() { }





    }
}
