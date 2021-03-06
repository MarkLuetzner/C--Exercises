﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace theQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        private IPotion potion;

        public bool CheckPotionUsed(string potionName)
        {
            IPotion potion;
            bool potionUsed = false;

            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == potionName && weapon is IPotion)
                {
                    potion = weapon as IPotion;
                    potionUsed = potion.Used;
                }
            }

            return potionUsed;
        }


        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location) : base(game, location)
        { HitPoints = 10; }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health+1);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 30))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (!(this.equippedWeapon == null))
            this.equippedWeapon.Attack(direction, random);

            else
            MessageBox.Show("First Collect Weapon!!");
        }

    }
}
