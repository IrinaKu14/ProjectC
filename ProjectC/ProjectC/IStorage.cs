using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC
{
    public interface IStorage
    {
        public void SetValue(string name, string vallue);
        public string? GetValue(string name);
    }
}
