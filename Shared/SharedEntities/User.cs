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
    //public string PasswordHash { get; set; }
    public int Age { get; set; }
    public bool? Gender { get; set; }
    public bool? IsActiv { get; set; }

    public ICollection<Message> Message { get; set; }

    // =================PASSWORD
    //public string Password { get; set; }

    // минусы: 1- можно узнать на любом этапе
    //2- можно узать из бд
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
}
