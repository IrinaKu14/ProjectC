using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC;

public class MemoryStorage : IStorage
{
    private Dictionary<string, string> 
        _memory = new Dictionary<string, string>();
    public void SetValue(string name, string value)
    {
        if (_memory.ContainsKey(name))
        { 
            _memory[name] = value;
        }
        _memory.Add(name, value);
    }

    public string? GetValue(string name)
    {
        if (_memory.ContainsKey(name))
        {
            return _memory[name];
        }
        return null;
        //SetString(new string[] { "1", "2" });
        //SetString(new List<string> { "3", "4" });
    }

    public string SetString()//IEnumerable<string> array)
    {
        //foreach (var item in array)
        //{
        //    //
        //}

        return string.Empty;
    }
}
