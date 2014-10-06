using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class SkillMeasure : Measure // :Table   // : Skill
    {
        private static int IDCount;

        public SkillMeasure(string _name)
        {
            ID = ++IDCount;
            //this.skill = _skill;
        }

        public void ModifyLevel(Measurement _level)
        {
            this.level = _level;
        }
        public void ModifyDesire(Measurement _desire)
        {
            this.desire = _desire;
        }


    }
}
