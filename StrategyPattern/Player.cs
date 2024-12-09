using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Weapons;

namespace StrategyPattern
{
    public class Player
    {
        private IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void Attack()
        {
            if (_weapon != null) _weapon.UseWeapon();
            else Console.WriteLine("Оружие не выбрано.");
        }
    }
}