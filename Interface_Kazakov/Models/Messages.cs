using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kazakov.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Create {  get; set; }

        public int IdUser { get; set; }
        public Messages() { }

        public Messages(int Id, DateTime Create, int IdUser)
        {
            this.Id = Id;
            this.Create = Create;
            this.IdUser = IdUser;
        }
    }
}
