using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    /**
     * The purpose of this class isn't to instantiate literal tables, just pass on variables and functions.
     * 
     */
    public class Table //think of as TableRowEntry
    {
        private static int IDCount = 0;
        public int ID;

        public Table()
        {
            ID = ++IDCount;
        }

        public virtual bool Modify() { return true; }

    }
}
