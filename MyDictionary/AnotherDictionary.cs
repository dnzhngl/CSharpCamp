using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class AnotherDictionary<TKey, TVal>
    {
        private List<TKey> keys;
        private List<TVal> values;

        public AnotherDictionary()
        {
            keys = new List<TKey>();
            values = new List<TVal>();
        }

        public void Add(TKey key, TVal val)
        {
            keys.Add(key);
            values.Add(val);
        }

        public int Count
        {
            get { return keys.Count; }
        }
        public List<TVal> Values
        {
            get { return values; }
        }
        public List<TKey> Keys
        {
            get { return keys; }
        }

        public TVal GetValue(TKey key)
        {
            int index = keys.IndexOf(key);
            return values[index];
        }
        public TKey GetKey(TVal val)
        {
            int index = values.IndexOf(val);
            return keys[index];
        }
    }
}
