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
        public List<SkillMeasurable> skills;
        public string name;

        public static List<Person> persons = new List<Person>();

        public Person(string _name)
        {
            ID = ++IDCount;
            this.name = _name;
            skills = new List<SkillMeasurable>();
            if (!Exists(_name))
            {
                persons.Add(this);
                Console.WriteLine("Added " + _name);
            }
        }

        public Person(string _name, SkillMeasurable _skill)
        {
            ID = ++IDCount;
            this.name = _name;
            skills = new List<SkillMeasurable>();
            skills.Add(_skill);
            if (!Exists(_name))
            {
                persons.Add(this);
                Console.WriteLine("Added " + _name);
            }
        }

        public bool Add(Skill _skill){
            //this.skills.Add(_skill); //so now i'm wondering if there's a way to cast this, but i doubt it, since it's a component
            skills.Add(new SkillMeasurable(_skill.name));
            return false; 
        }

        public bool Add(SkillMeasurable _skill)
        {
            //this.skills.Add(_skill); //so now i'm wondering if there's a way to cast this, but i doubt it, since it's a component
            skills.Add(_skill);
            return false;
        }

        //there should be a way to use Generics to promote my Exists methods up to a common ancestor and implement in children...
        public static bool Exists(string _person)
        {
            foreach (Person person in persons)
            {
                if (_person == person.name)
                {
                    //Console.WriteLine("Already exists: " + _person);
                    return true;
                }
            }
            //Console.WriteLine("Doesn't exist: " + _person);
            return false;
        }

        public override string Print()
        {
            string outputSkills = "";
            foreach (var skill in skills)
            {
                outputSkills += n + "+" + skill.Print();
            }
            return /*skills[0].PrintHeader() + */ base.Print() + ID + d + name + d + outputSkills + d;
        }

        public override string PrintHeader()
        {
            return base.Print() + UtilSO.GetVariableName(() => ID) + d + UtilSO.GetVariableName(() => name) + d;
        }
    }
}
