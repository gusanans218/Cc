using System;

namespace ConsoleApp5
{
    class Player
    {


    }
    class Knight:Player
    {

    }
    class Mage : Player
    {
        internal int mp;
    }

    class Program
    {
     /*   static void EnterGame(Knight knight)
        {

        }
        static void EnterGame(Mage mage)
        {

        }*/
        static void EnterGame(Player player)
        {
            //is = bool형
            bool isMage = (player is Mage);
            if(isMage)
            {
                Mage mage2 = (Mage)player;
                mage2.mp = 10;
                Console.WriteLine("생성");
            }
            //as
            Mage mage3 = (player as Mage);

            if(mage3 != null)
            {
                mage3.mp = 10;
                Console.WriteLine("as생성");
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            /*Player magePlayer = new Player();
            Mage mage2 = (Mage)magePlayer;
            mage2.mp = 10;*/

            EnterGame(knight);
            EnterGame(mage);

        }
    }
}
