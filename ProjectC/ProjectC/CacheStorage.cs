using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC
{
    public class CacheStorage : IStorage
    {
        public string? GetValue(string name)
        {
            return name;
        }

        public void SetValue(string name, string value)
        {
            name = value;
        }
    }
}
