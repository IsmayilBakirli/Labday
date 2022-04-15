using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newgunapplication.Models
{
    public class Gun:Base
    {
        protected int capacity;
        public Gun(string name):base( name)
        {

        }
    }
}