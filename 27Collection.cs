# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExplicitInterfaceExample
{
    class Collection : IEnumerable
    {
        int[] Array;
        public Collection(int[] array)
        {
            Array = array;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ENumaralandirma(this); 
        }
        class ENumaralandirma : IEnumerator 
        {
            int index;
            Collection collection;
            public ENumaralandirma(Collection collection)
            {
                this.collection = collection;
                index = -1;
            }
            public void Reset()
            {
                index = -1;
            }
            public bool MoveNext()
            {
                index++;
                if (index < collection.Array.Length)
                    return true;
                else
                    return false;
            }
            public object Current
            {
                get
                {
                    return (collection.Array[index]);
                }
            }
        }
    }
}
