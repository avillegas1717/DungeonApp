﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //MinDamage can't exceed Max and can't be less than 1
                _minDamage = (value > 0 && value < MaxDamage) ? value : 1;
            }
        }

        public string Description { get; set; }

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) 
            : base(name, hitChance, block, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster()
        {
            //added so we can create "default" monster subtypes
            //Name = "Baby Goblin"
            //HitChance = 15
            //Goblin babyGoblin = new Goblin()
        }

        public override string ToString()
        {
            return $"*********** MONSTER ***********\n" +
                $"{base.ToString()}\n" +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }

        public override int CalcDamage()
        {
            //throw new NotImplementedException();
            return new Random().Next(MinDamage, MaxDamage + 1);//+1 because it's exclusive
        }

        public static Monster GetMonster()
        {
            //TODO Come back to replace these monsters with your own monster subtypes later.
            Monster m1 = new("First Monster", 50, 20, 25, 8, 2, "This is a test monster");
            Monster m2 = new("Second Monster", 70, 20, 25, 8, 2, "This is a test monster");
            Monster m3 = new("Third Monster", 50, 20, 25, 8, 2, "This is a test monster");
            Monster m4 = new("Fourth Monster", 45, 25, 40, 12, 5, "This is a test monster");

            List<Monster> monsters = new()
            {
                m1, m1,
                m2, m2, m2, m2,
                m3, m3, m3,
                m4
            };

            Random rand = new Random();
            int index = rand.Next(monsters.Count);
            Monster monster = monsters[index];
            return monster;

            //return monsters[new Random().Next(monsters.Count)];
        }
    }//end class
}//end namespce
