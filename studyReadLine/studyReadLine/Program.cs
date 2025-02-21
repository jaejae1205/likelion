using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");

            Console.Write("루인 스킬 피해를 입력하세요: ");
            string input1 = Console.ReadLine();
            float ruin = float.Parse(input1);

            Console.Write("카드 게이지 획득량을 입력하세요: ");
            float card = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해를 입력하세요: ");
            float ult = float.Parse(Console.ReadLine());

            Console.Write("최대 마나를 입력하세요: ");
            int mana = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량을 입력하세요: ");
            int mana_fight = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량을 입력하세요: ");
            int mana_no_fight = int.Parse(Console.ReadLine());

            Console.Write("이동 속도를 입력하세요: ");
            float speed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도를 입력하세요: ");
            float ride_speed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도를 입력하세요: ");
            float carry_speed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소를 입력하세요: ");
            float cooltime = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"루인 스킬 피해            : {ruin}%");
            Console.WriteLine($"카드 게이지 획득량        : {card}%");
            Console.WriteLine($"각성기 피해               : {ult}%");
            Console.WriteLine($"최대 마나                 : {mana}");
            Console.WriteLine($"전투 중 마나 회복량       : {mana_fight}");
            Console.WriteLine($"비전투 중 마나 회복량     : {mana_no_fight}");
            Console.WriteLine($"이동 속도                 : {speed}%");
            Console.WriteLine($"탈 것 속도                : {ride_speed:F1}%");
            Console.WriteLine($"운반 속도                 : {carry_speed:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {cooltime}%");

        }
    }
}
