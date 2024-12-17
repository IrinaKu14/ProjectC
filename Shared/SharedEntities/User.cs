using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.SharedEntities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public int Age { get; set; }
    public bool? Gender { get; set; }  
    public bool IsActive {  get; set; }

    public string? Name { get; set; }

}
