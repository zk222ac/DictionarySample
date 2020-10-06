using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySample
{
   public class Country
    {
        string _code;
        string _name;

        public Country(string code, string name)
        {
            _code = code;
            _name = name;
        }

        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return $" the country whose code is {Code} is called: {Name}";
        }
      
    }
}
