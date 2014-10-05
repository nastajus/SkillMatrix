using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    public class Skill : Table
    {
        private static int IDCount;
        public new int ID;

        public Skill()
        {
            ID = ++IDCount;
        }
    }
}
