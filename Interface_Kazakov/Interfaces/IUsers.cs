using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Kazakov.Models;

namespace Interface_Kazakov.Interfaces
{
    public interface IUsers
    {
        void All(out List<Users> users);
    }
}
