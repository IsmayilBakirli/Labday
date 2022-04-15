using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newgunapplication.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Kind { get; }
        private  static int _idcounter{ get; set; }

        static Base()
        {
            _idcounter = 0;
        }
        public Base(string name)
        {
            Name = name;
        }


    }
}
