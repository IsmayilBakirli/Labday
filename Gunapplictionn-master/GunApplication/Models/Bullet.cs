using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApplication.Models
{
    public  class Bullet
    {
        public int AllBulletcount ;
        
        public  double BulletDiameter { get; set; }
        public int Bulletcount { get; set; }
        public bool check = true;
        
        public Bullet()
        {

        }
        //public void CreateBulletinfo()
        //{
        //    if(Name=="7.62 mm"||Name=="7.62mm")
        //    {
        //        if (check)
        //        {
        //            Bulletcount = 60;
        //            check = false;
        //        }

        //        BulletDiameter = 7.82;
        //        Price = 0.5;
        //        Createddate = DateTime.Now;
        //        Updateddate = DateTime.Now;
                

        //    }
        //    else if(Name=="5.56 mm" || Name == "5.56mm")
        //    {
        //        if (check)
        //        {
        //            Bulletcount = 60;
        //            check = false;
        //        }
        //        BulletDiameter = 5.70;
        //        Price = 0.6;
        //        Createddate = DateTime.Now;
        //        Updateddate = DateTime.Now;
        //    }
        //}
    }
}
