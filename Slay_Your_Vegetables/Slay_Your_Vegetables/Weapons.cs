using System;
using System.Collections.Generic;

namespace Slay_Your_Vegetables
{
    public enum WeaponType
    {
        Knife,
        Axe,
        Torch,
        Blender
    }

    public class Enemy
    {
        public string Name;
        public float Health;
        public float Position; 

        public Enemy(string name, float health, float position)
        {
            Name = name;
            Health = health;
            Position = position;
        }
        // Is the enemy still alive?
        public void TakeDamage(float damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} took {damage} damage. Remaining HP: {Health}");

            if (Health <= 0)
                Console.WriteLine($"{Name} has been destroyed!");
        }
        // Used for Blender ultimate (pushes enemies back)  
        public void PushBack(float distance)
        {
            Position += distance;
            Console.WriteLine($"{Name} was pushed back -> New position: {Position}");
        }
    }

    public class Weapons
    {
        public WeaponType CurrentWeapon;

        // DAMAGE VALUES FOR EACH WEAPON 
        private float knifeDamage = 50f;
        private float axeStartDamage = 75f;
        private float torchSmallDamage = 15f;
        private float torchBigDamage = 40f;
        private float blenderDamage = 30f;


    
    }
}