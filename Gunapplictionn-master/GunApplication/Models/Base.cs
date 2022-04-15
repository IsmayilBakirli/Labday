using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApplication
{
    public abstract class Base
    {
        private static  int  _idcounter;
        public int Id { get; set; }
        public string Name { get; set; }
        public double  Price { get; set; }
        public DateTime Createddate{ get; set; }
        public DateTime Updateddate { get;set; }
        static Base()
        {
            _idcounter = 0;
        }
        public Base(string name)
        {
            Id = ++_idcounter;
            Name = name;
            
        }
        
    }
}







