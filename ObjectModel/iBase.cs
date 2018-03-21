using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public interface iBase
    {
        bool Removed { get; set; }

        Int32 Id { get; set; }

        void Print();
    }
}
