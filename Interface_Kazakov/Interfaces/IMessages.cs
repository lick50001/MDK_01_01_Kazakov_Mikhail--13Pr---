using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Kazakov.Models;

namespace Interface_Kazakov.Interfaces
{
    public class IMessages
    {
        void All(out List<Messages> Messages);

        void Save(bool Update = false);

        void Delete();
    }
}
