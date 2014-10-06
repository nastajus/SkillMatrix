using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class SkillMeasurable : Measure // :Table   // : Skill
    {
        private static int IDCount;
        public Skill skill;

        public SkillMeasurable(string _name)
        {
            ID = ++IDCount;
            this.skill = new Skill(_name);
        }

        public SkillMeasurable(string _name, Measurement _level)
        {
            ID = ++IDCount;
            this.skill = new Skill(_name);
            this.level = _level;
        }

        public SkillMeasurable(string _name, Measurement _level, Measurement _desire)
        {
            ID = ++IDCount;
            this.skill = new Skill(_name);
            this.level = _level;
            this.desire = _desire;
        }

        //i'd waste memory if i allowed the following, so i won't
        //public SkillMeasurable(string _name, Measurement _level, Measurement _desire)
        //{
        //    new SkillMeasurable(_name, _level);
        //    //ID = ++IDCount;
        //    //this.skill = new Skill(_name);
        //    //this.level = _level;
        //    this.desire = _desire;
        //}


        public override string Print()
        {
            return base.Print() + ID + d + skill.name + d + IsNull(level) + d + IsNull(desire);
        }

        public override string PrintHeader()
        {
            return base.Print() + UtilSO.GetVariableName(() => ID) + d + UtilSO.GetVariableName(() => skill.name) + d + UtilSO.GetVariableName(() => level + d + UtilSO.GetVariableName(() => desire)) + d;
        }


        //the following accessors are depreciated by using properties in Measure instead.

       // public void ModifyLevel(Measurement _level)
       // {
       //     this.level = _level;
       // }
       // public void ModifyDesire(Measurement _desire)
       // {
       //     this.desire = _desire;
       // }


    }
}
