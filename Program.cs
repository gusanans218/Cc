using System;

namespace ConsoleApp3
{
    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성되었습니다");
        }

        public Knight(int hp) : this()
        {
            hp = 100;
            Console.WriteLine("생성되었습니다");
        }
        public Knight(int hp, int attack):this(hp)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("hp 생성자 호출");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight(50,50);

            Console.WriteLine($"hp : {knight.hp} attack : {knight.attack}");
        }
    }
}
