using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<Tkey,Tvalue>
    {
        Tkey[] _key;
        Tvalue[] _value;
        public MyList()
        {
            _key = new Tkey[0];
            _value = new Tvalue[0];
        }
        public void Add(Tkey item1,Tvalue item2)
        {
            Tkey[] _tempkey = _key;
            Tvalue[] _tempvalue = _value;
            _key = new Tkey[_key.Length + 1];
            _value = new Tvalue[_value.Length + 1];
            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];
            }
            _key[_key.Length - 1] = item1;

            for (int j = 0; j < _tempvalue.Length; j++)
            {
                _value[j] = _tempvalue[j];
            }
            _value[_value.Length - 1] = item2;

        }
        public int Count
        {
            get { return _key.Length; }
        }
    }
}
