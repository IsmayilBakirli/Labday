using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApplication.Models
{

    public abstract class Gun: Base
    {
        
        public string Bulletname { get; set; }
        public int MyProperty { get; set; }
        public int Bulletspeed { get; set; }

        public int BulletCount { get; set; }
        
        public double BulletPrice { get;  }
        public int MagazineCapacity { get; set; }
        public Gun(string name) :base(name)
        {
            Id++;   
        }
        public Gun(string name, double price, string bullet_name, int magazine_capacity, int bullet_speed, double bullet_price, int bullet_count) : base(name)
        {
            Price = price;
            Bulletname = bullet_name;
            MagazineCapacity = magazine_capacity;
            Bulletspeed = bullet_speed;
            BulletPrice = bullet_price;
            BulletCount = bullet_count;
            MagazineCapacity = magazine_capacity;           
        }
        

    }
}











