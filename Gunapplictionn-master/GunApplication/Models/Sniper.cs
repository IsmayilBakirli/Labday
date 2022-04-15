﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApplication.Models
{
    public class Sniper:Gun,ISingleShot
    {
        
        
        public Sniper(string name, double price, string bullet_name, int magazine_capacity, int bullet_speed, double bullet_price , int bullet_count) : base(name, price, bullet_name, magazine_capacity, bullet_speed, bullet_price, bullet_count)
        {
            
        }
        public string InfoSnipper()
        {
            return $"{Name} id:{Id}\nSniper name is:{Name}\n{Name} price is about:{Price}$\n{Name}'s bullet name:{Bulletname}\nbullet speed is about:{Bulletspeed}m/s\n{Name} bullet price is:{BulletPrice}$\n" +
                $"1 magazine capacity: {MagazineCapacity}\nbullet count is:{BulletCount}\nall bullet count:{1500}\nCreated date:{DateTime.Now},\n{singleshot()}";


        }

        public string singleshot()
        {
            return "sniper can only single shot";
        }
    }
}




















