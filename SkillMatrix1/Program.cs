using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class Program
    {
        static void Main(string[] args)
        {

            Skill s = new Skill("art");
            Console.WriteLine(s.ID);
            Skill ss = new Skill("code");
            Console.WriteLine(ss.ID);

            SkillMeasure sh = new SkillMeasure("");
            Console.WriteLine(sh.ID);

            Skill sss = new Skill("management");
            Console.WriteLine(sss.ID);



            Console.WriteLine("COUNT: " + Skill.skills.Count());
            //Console.WriteLine(Skill.skills.ElementAt(1).ID);
            


            //Database db = new Database();
            //db.skills;

            /*
             *  What are the pros/cons of allowing a variable to be accessible statically or as an instance member?
             */





            Skill.LoadSkills();



       

        }
    }
}
