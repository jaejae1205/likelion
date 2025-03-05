using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_3._5_
{


    class Champions
    {
        public string Name;
        public int Health;
        public int Mana;

        public Champions()
        {
            Name = "Unknown";
            Health = 0; 
            Mana = 0;

        }

        public virtual void Qskill()
        {
            Console.WriteLine($"{Name}이(가) Q 스킬을 사용합니다. ");
        }

        public virtual void Wskill()
        {
            Console.WriteLine($"{Name}이(가) W 스킬을 사용합니다. ");
        }

        public virtual void Eskill()
        {
            Console.WriteLine($"{Name}이(가) E 스킬을 사용합니다. ");
        }





    }

    class Jhin : Champions
    {
        public Jhin()
        {
            Name = "Jhin";
            Health = 100;
            Mana = 50;

        }


        public override void Qskill()
        {
            Console.WriteLine("춤추는 유탄 사용");
        }

        public override void Wskill()
        {
            Console.WriteLine("살상연희 사용");
        }

        
    }

    class Yone : Champions
    {
        public Yone()
        {
            Name = "Yone";
            Health = 150;
            Mana = 0;
        }

        public override void Qskill()
        {
            Console.WriteLine("필멸의 검 사용");
        }

        public override void Eskill()
        {
            Console.WriteLine("영혼해방 사용");
        }

        public void Rskill(Champions champ)
        {
            Console.WriteLine($"요네가 {champ.Name}에게 R 스킬을 사용합니다");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Champions> champions = new List<Champions>();

            champions.Add(new Jhin()); //업캐스팅
            champions.Add(new Yone());

            foreach(var champ in champions)
            {
                champ.Qskill();
                champ.Wskill();
                champ.Eskill();
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");

            Yone yone = new Yone();
            Jhin jhin = new Jhin();
            yone.Rskill(jhin);

            Console.WriteLine("----------------------");

            

            Champions cham = new Yone();
            Yone jin = (Yone)cham;
            jin.Rskill(jhin);


        }
    }
}
