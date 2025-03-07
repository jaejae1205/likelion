using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_TIMEATTACK
{
    class Monster
    {
        public INFO monster;

        public void Render()
        {
            monster = new INFO();
            Console.WriteLine("============================");
            Console.WriteLine("몬스터 이름 : " + monster.name);
            Console.WriteLine("공격력 : " + monster.attack);
            Console.WriteLine("체력 : " + monster.hp);

        }

        public INFO GetMonster()
        {
            return monster;
        }

        public void SetDamage(int att)
        {
            monster.hp -= att;
        }

        public void SetMonster(INFO mon)
        {
            monster = mon;
        }

        public Monster()
        {

        }

        ~Monster() { }
    }
}
