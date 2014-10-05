using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class SkillHave : Skill
    {
        private static int IDCount;
        public new int ID;
        public SkillHave()
        {
            ID = ++IDCount;
        }
    }
}
