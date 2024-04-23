using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    internal class Equipment : Player
    {

        public Equipment(string weaponname, int weight, int damage)
        {
            _weaponname = weaponname;
            _weight = weight;
            _damage = damage;
        }


        public string _weaponname { get; set; }
        public int _weight { get; set; }
        public int _damage { get; set; }

        public override string ToString()
        {
            return $"{_weaponname} - Weight: {_weight} - Damage: {_damage}";
        }

    }
}
