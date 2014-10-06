using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class Person : Table
    {
        private static int IDCount = 0;
        public List<SkillMeasure> skills;
        public string name;

        Person(string _name)
        {
            ID = ++IDCount;
            this.name = _name;

        }

        public bool AddSkill(Skill _skill){
            //this.skills.Add(_skill); //so now i'm wondering if there's a way to cast this, but i doubt it, since it's a component
            return false; 
        }
    }
}
