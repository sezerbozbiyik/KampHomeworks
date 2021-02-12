using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        
        public void Add(TKey key,TValue value)
        {
            TKey[] tempArrayKey = keys;
            keys = new TKey[keys.Length + 1];
            TValue[] tempArrayValue = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
                values[i] = tempArrayValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
           
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);
            }
        }
    }
}
