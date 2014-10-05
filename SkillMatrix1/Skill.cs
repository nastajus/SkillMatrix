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
        public string name { get; set; }
        public int? parentID = null;

        public static List<Skill> skills = new List<Skill>();

        public Skill(string _name)
        {
            ID = ++Skill.IDCount;   //this won't make sense if this will be the parent of SkillHave.
            this.name = _name;
            skills.Add(this);
        }

        public bool Parent(int _parentID)
        {
            this.parentID = _parentID;
            return true;
        }


        //private bool HasParent(string _parent)
        //{
            //verify list of skills has or not. 
            //i can use a singleton with this containing a static list, or i can use the database instance i created.
        //}
    }
}
