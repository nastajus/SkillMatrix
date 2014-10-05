using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class SkillHave : Table // : Skill
    {
        private static int IDCount;
        //Skill skill;

        public SkillHave(string _name)
        {
            ID = ++SkillHave.IDCount;
            //this.skill = _skill;
        }


    }
}
