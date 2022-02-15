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
        public void Add(TKey key, TValue value)
        {
            TKey[] keysTempArray = keys;
            keys = new TKey[keys.Length + 1];
            for (int i = 0; i < keysTempArray.Length; i++)
            {
                keys[i] = keysTempArray[i];
            }
            keys[keys.Length - 1] = key;

            TValue[] valuesTempArray = values;
            values = new TValue[values.Length + 1];
            for (int i = 0; i < valuesTempArray.Length; i++)
            {
                values[i] = valuesTempArray[i];
            }
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }
        }
        public void Value(int key)
        {
            Console.WriteLine(values[key]);
        }
    }
}
