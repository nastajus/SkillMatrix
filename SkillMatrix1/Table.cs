using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    /**
     * The purpose of this class isn't to instantiate literal tables, just pass on contract enforcement by exploring 
     * what's possible with variables and functions. So far it seems I've ruled out enforcing fields. I also tried sealed
     * but nope. 
     * 
     */
    public class Table //think of as TableRowEntry
    {
        private static int IDCount2 = 0;
        public int ID {get;set;}

        public Table()
        {
            ID = ++Table.IDCount2;
            Console.WriteLine("when");
            //eureka. now i realize the parent constructor is being invoked every time i create a child.
            //at this point i should examine abstract classes or interfaces.
        }

        public virtual bool Modify() { return true; }

    }
}
