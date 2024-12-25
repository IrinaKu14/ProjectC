using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC;

public interface IRepository<T>
    where T : User
{
   T? GetById(int id);
    bool Create(T user);
    bool Update(T user);
    bool Delete(int id);

}
public class EntityRepository<T> : IRepository<T>
    where T : User
{
    public bool Create(T user)
    { 
        throw new NotImplementedException();
    }
    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
    public T? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(T user)
    {
        throw new NotImplementedException();
    }
}
public class User 
{ 
    public int Id { get; set; }
    public string Name { get; set; }

}
public class Admin: User
{
    public int Id { get; set; }
    //public string Name { get; set; }
    //public string Description { get; set; }

}
