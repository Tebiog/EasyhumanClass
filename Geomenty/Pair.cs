using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP.Geomenty
{
    class Pair <TKey, TValue>
    {
        public TKey Key { get; set; }

        public TValue Value { get; set; }

        public Pair()
        {
            Key = default;
            Value = default;
        }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"Key: {Key}; Value: {Value}";
        }
    }
}
