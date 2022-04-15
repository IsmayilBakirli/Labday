using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer1
{
    public class Indexer<T>
    {
        private T[] _array;
        public int Length { get { return _array.Length; } }
        public T this[int index]
        {
            get
            {
                if(index<Length&& index >= 0)
                {
                    return _array[index]; 
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if(index<Length && index >= 0)
                {
                    _array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }          
        }
        public Indexer()
        {
            _array = new T[0];
        }
        public Indexer(int len)
        {
            _array=new T[len];
        }
        public void Add(T value)
        {
            T[] newarray = new T[_array.Length+ 1];
            for (int i = 0; i <_array.Length; i++)
            {
                newarray[i] = _array[i];
            }
            newarray[_array.Length]=value;
            _array = newarray;
        }
    }
}
