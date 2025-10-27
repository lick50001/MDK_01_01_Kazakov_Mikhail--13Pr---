using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kazakov.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public Users() { }
        public Users(int Id, string FIO)
        {
            this.Id = Id;
            this.FIO = FIO;
        }
    
    }
}
