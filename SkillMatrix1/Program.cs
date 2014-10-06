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

            SkillMeasurable sh = new SkillMeasurable("");
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
            Console.WriteLine("---------");

            //testing my code already::
            //not intended to exist solitarily, but does for now.
            SkillMeasurable smcll = new SkillMeasurable("code");
            smcll.level = Measurement.Lots;

            SkillMeasurable smsll = new SkillMeasurable("storyboarding");
            smsll.level = Measurement.Lots;


            Person pi = new Person("Ian");
            Person pa = new Person("Alex");
            Person pz = new Person("Zack");
            Person po = new Person("Oles");
            Person pt = new Person("Tran");
            Person pd = new Person("Dante");
            Person pj = new Person("Jordan");
            Person ph = new Person("Hunter");
            

            Console.WriteLine("---------");


            pi.skills.Add(smcll);
            ph.skills.Add(smsll);


            SkillMeasurable smclo = new SkillMeasurable("code", Measurement.Obsessed);
            SkillMeasurable smclodo = new SkillMeasurable("code", Measurement.Obsessed, Measurement.Obsessed);

            pz.skills.Add(smclo);
            pd.skills.Add(smclodo);
            po.skills.Add(smclo);




            Console.WriteLine(pd.PrintHeader());

            foreach (Person person in Person.persons)
            {
                Console.WriteLine(person.Print());
            }


            Console.ReadLine();


            //pj.skills.Add(new SkillMeasurable(""));
       

        }
    }
}
