using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    /**
     * This was repurposed from a class to an interface, since it's goals became enforcing a contract of methods, 
     * and it was proven infeasible to inherit a class. The disliked qualities of that inheritance relationship were
     * it called the parent constructor. I had wanted a way to enforce fields, which I can still do with an abstract 
     * class Table and inheriting a field... which I am going to explore now.
     * 
     * The purpose of this class was to just pass on contract enforcement by exploring 
     * what's possible with variables and functions. So far it seems I've ruled out enforcing fields. I also tried sealed
     * but nope. 
     * 
     */
    public abstract class Table //think of as TableRowEntry
    {
        public int ID;

        bool Modify() { return true; }

    }
}
