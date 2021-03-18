using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.textRPG
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        //몬스터 타입 및 구조체 생성
        enum MonsterTpye
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }

        static ClassType ChoiseClass()
        {
            Console.WriteLine("> 직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 아처");
            Console.WriteLine("[3] 메이지");

            ClassType choise = ClassType.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choise = ClassType.Knight;
                    break;
                case "2":
                    choise = ClassType.Archer;
                    break;
                case "3":
                    choise = ClassType.Mage;
                    break;

                default:
                    break;
            }

            return choise;
        }

        static void CreatePlayer(ClassType choise, out Player player)
        {

            player.hp = 0;
            player.attack = 0;

            switch (choise)
            {
                case ClassType.None:
                    break;
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    break;
            }
        }

        struct Player
        {
            public int hp;
            public int attack;

        }

        //2. 마을에 접속해 필드로 갈지 로비로 갈지 결정하는 코드 작성
        static void EnterGame(ref Player player)
        {

            while (true)
            {
                Console.WriteLine("> 마을에 접속했습니다 <");

                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        EnterField(ref player);
                        break;

                    case "2":

                        return;

                    default:
                        break;
                }

            }

        }

        //3. 랜덤으로 몬스터를 생성
        private static void EnterField(ref Player player)
        {

            while (true)
            {
                Console.WriteLine("> 필드에 접속했습니다 <");
                //랜덤으로 1-3몬스터 중 하나를 리스폰
                //[1] 전투모드 돌입
                //[2] 일정확률로 마을로 도망

                //몬스터 생성
                Monster monster;
                //4. 랜덤으로 몬스터를 만들 함수를 작성
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투모드 돌입");
                Console.WriteLine("[2] 일정확률로 마을로 도망");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("전투모드");
                    Fight(ref monster, ref player);
                }
                else if (input == "2")
                {
                    Console.WriteLine("마을로 도망");
                    return;
                }
            }

        }

        private static void Fight(ref Monster monster, ref Player player)
        {
            while (true)
            {
                monster.hp -= player.attack;

                if (monster.hp <= 0)
                {
                    Console.WriteLine("이겼습니다");
                    Console.WriteLine($"남은체력 : {player.hp}");
                    break;
                }

                player.hp -= monster.attack;

                if (player.hp <= 0)
                {
                    Console.WriteLine("졌습니다");
                    break;
                }

            }
        }

        //4. 랜덤으로 몬스터를 만든다.
        private static void CreateRandomMonster(out Monster monster)
        {
            //랜덤 타입의 몬스터 만든다.
            //슬라임 hp:20, attack=2 오크 hp:40, attack = 4, 스켈레톤 hp: 30, attack -3
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            monster.hp = 0;
            monster.attack = 0;
            switch (randMonster)
            {
                case (int)MonsterTpye.Slime:
                    Console.WriteLine("---------------------");
                    Console.WriteLine("슬라임이 등장했습니다");
                    Console.WriteLine("---------------------");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterTpye.Orc:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("오크가 등장했습니다");
                    Console.WriteLine("--------------------");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterTpye.Skeleton:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("스켈레톤이 등장했습니다");
                    Console.WriteLine("-----------------------");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:

                    break;
            }


        }

        static void Main(string[] args)
        {
            ClassType choise = ClassType.None;

            while (true)
            {
                choise = ChoiseClass();
                if (choise != ClassType.None)
                {

                    Player player;
                    CreatePlayer(choise, out player);
                    Console.WriteLine($"  hp : {player.hp} attack : {player.attack}  ]");

                    //1. 실제 게임이 진행될 함수 생성
                    EnterGame(ref player);


                }

            }
        }


    }

}