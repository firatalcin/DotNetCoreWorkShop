using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Homework_5
{
    class MyDictionary<T1,T2>
    {
        T1[] key;
        T2[] value;

        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];
        }

        public void Add(T1 item1, T2 item2)
        {
            T1[] temp1 = key;
            T2[] temp2 = value;
            key = new T1[key.Length + 1];
            value = new T2[value.Length + 1];
            for (int i = 0; i < temp1.Length; i++)
            {
                key[i] = temp1[i];
                value[i] = temp2[i];
            }

            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;
        }

        public int Count { get { return key.Length; }  }

        public T1[] Keys { get { return key; }  }

        public T2[] Values { get { return value; } }


    }
}
