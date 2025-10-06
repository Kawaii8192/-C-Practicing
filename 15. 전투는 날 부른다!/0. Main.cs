using System;
using CHARACTER;
using DIRECTOR;

namespace ReadyForBattle
{
    class Program
    {
        static void Main(String[] args)
        {
            Kerrigan.RESET();
            Fenix.RESET();

            Director.BattleGround();
        }
    }
}