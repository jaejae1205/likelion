using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_TIMEATTACK
{
    class MainGame
    {
        public Player player =null;

        public Field field=null;

        public void Initialize()
        {
            player = new Player();
            player.SelectJob();
            
        }

        public void Progress()
        {

            while (true)
            {
                player.Render();
                Console.WriteLine("============================");
                Console.WriteLine("1. 전투 2. 게임종료");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    if(field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref player);
                    }
                    
                    field.Progress();
                }
                else if (input == 2)
                {
                    break;
                }
            }

            



        }
        public MainGame() { }

        ~MainGame() { }

    }
}
