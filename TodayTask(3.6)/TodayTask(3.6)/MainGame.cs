using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask_3._6_
{
    class MainGame
    {
        public Player p1 = null;

        public Field field = null;

        public void Initialize()
        {
            p1 = new Player();
            p1.SelectJob();

        }

        public void Progress()
        {

            while (true)
            {
                Console.Clear();
                p1.Render();
                Console.WriteLine("1. 사냥터 2. 종료");
                int input = int.Parse(Console.ReadLine());

                if (input == 2) break;
                if (input == 1)
                {
                    if(field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref p1);
                    }
                    field.Progress();
                }

            }

        }
        public MainGame()
        {

        }
        ~MainGame() { }

    }
}
