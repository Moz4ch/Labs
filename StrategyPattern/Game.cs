using StrategyPattern.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player(new Sword());
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите оружие: 1 - Меч, 2 - Лук, 3 - Топор, 0 - Выход");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        _player.SetWeapon(new Sword());
                        Console.WriteLine("Вы выбрали меч.");
                        break;
                    case "2":
                        _player.SetWeapon(new Bow());
                        Console.WriteLine("Вы выбрали лук.");
                        break;
                    case "3":
                        _player.SetWeapon(new Axe());
                        Console.WriteLine("Вы выбрали топор.");
                        break;
                    case "0":
                        Console.WriteLine("Игра завершена.");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        continue;
                }
                _player.Attack();
            }
        }
    }
}