using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_3._6_
{
    class Monster
    {
        public INFO monster;

        public void SetDamage(int att)
        {
            monster.Hp -= att;
        }

        public void SetMonster(INFO mon)//
        {
            monster = mon;
        }

        public INFO GetMonster()//
        {
            return monster;
        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + monster.Name);
            Console.WriteLine("체력 : " + monster.Hp + "\t공격력 :  " + monster.Attack);
        }

        public Monster() { }

        ~Monster() { }
    }
}
