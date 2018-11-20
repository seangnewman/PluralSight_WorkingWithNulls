﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_WorkingWithNulls
{
    class PlayerCharacter
    {
        private readonly SpecialDefense _specialDefense;

        public PlayerCharacter(SpecialDefense specialDefense)
        {
            this._specialDefense = specialDefense;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if(_specialDefense != null)
            //{
            //    damageReduction = _specialDefense.CalculateDamageReduction(damage);
            //}


            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefense.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }
    }
}
