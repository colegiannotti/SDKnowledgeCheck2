using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Warrior : Adventurer
    {
        public int Strength { get; set; }
        public override string ToString()
        {
            return String.Format("Warrior {0} has {1} strength.", Name, Strength);
        }
    }

    
}
