using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryGenericClass
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _arrayKey;
        private TValue[] _arrayValue;


        public MyDictionary()
        {
            _arrayKey = new TKey[0];
            _arrayValue = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            var tempArrayKey = _arrayKey;
            _arrayKey = new TKey[_arrayKey.Length + 1];

            var tempArrayValue = _arrayValue;
            _arrayValue = new TValue[_arrayValue.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                _arrayKey[i] = tempArrayKey[i];
                _arrayValue[i] = tempArrayValue[i];
            }

            _arrayKey[_arrayKey.Length - 1] = key;
            _arrayValue[_arrayValue.Length - 1] = value;
        }

        public object this[TKey key]
        {
            get
            {
                TValue _key = default(TValue);
                for(int i =0; i < _arrayKey.Length;i++)
                {
                    if (Equals(key, _arrayKey[i]))
                    {
                        _key = _arrayValue[i];
                        break;
                    }
                }
                return _key;
            }
        }
    }
}
