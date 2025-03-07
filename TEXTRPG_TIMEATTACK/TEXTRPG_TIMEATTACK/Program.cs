using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_TIMEATTACK
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame maingame = new MainGame();
            maingame.Initialize();
            maingame.Progress();

        }
    }
}
