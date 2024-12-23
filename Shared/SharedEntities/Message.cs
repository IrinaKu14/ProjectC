using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.SharedEntities;

//[Table("main_messages")]
public class Message
{
    //[Key]
    public int UniqId { get; set; }
    public string Title { get; set; }
    //[Column("message_body")]
    //[StringLength(1024)]
    public string Body { get; set; }
    //[ForeignKey(nameof(Producer))]
    public int AuthorID { get; set; }
    public User Producer { get; set; }

    //[NotMapped] -- не отслеживает 
    //public int Count { get; set; }

}
