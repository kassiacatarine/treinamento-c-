using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Base: iBase
    {
        public int Id { get; set; }
        public bool Removed { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }

        public void Print()
        {
            Console.WriteLine("|-------------------- Informações Básicas --------------------|");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Titulo: "  + Title);
            Console.WriteLine("Comments: " + Comments);
            Console.WriteLine("Removed: " + Removed);
            Console.WriteLine();
        }

        public bool SetRemoved()
        {
            Removed = true;
            return Removed;
        }

    }
}
