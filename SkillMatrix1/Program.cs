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
            SkillMeasurable smmll = new SkillMeasurable("modelling", Measurement.Lots);

            pz.skills.Add(smclo);
            pd.skills.Add(smclodo);
            po.skills.Add(smclo);
            po.skills.Add(smmll);

            SkillMeasurable sm11 = new SkillMeasurable("trig", Measurement.Lots); pz.skills.Add(sm11);
            SkillMeasurable sm12 = new SkillMeasurable("physics", Measurement.Lots); pz.skills.Add(sm12);
            SkillMeasurable sm13 = new SkillMeasurable("trig", Measurement.Lots); pz.skills.Add(sm13);
            SkillMeasurable sm14 = new SkillMeasurable("mono", Measurement.Lots); pz.skills.Add(sm14); pd.skills.Add(sm14);
            SkillMeasurable sm15 = new SkillMeasurable("xna", Measurement.Obsessed); pz.skills.Add(sm15); pd.skills.Add(sm15);
            SkillMeasurable sm16 = new SkillMeasurable("blender", Measurement.Lots); pt.skills.Add(sm16);
            SkillMeasurable sm17 = new SkillMeasurable("reflection", Measurement.Obsessed); pz.skills.Add(sm17); pd.skills.Add(sm17);
            SkillMeasurable sm18 = new SkillMeasurable("delegates", Measurement.Obsessed); pz.skills.Add(sm18); pd.skills.Add(sm18);
            SkillMeasurable sm19 = new SkillMeasurable("opengl", Measurement.Lots); pt.skills.Add(sm19);  po.skills.Add(sm19);
            SkillMeasurable sm20 = new SkillMeasurable("directx", Measurement.None); pt.skills.Add(sm20); po.skills.Add(sm20);
            SkillMeasurable sm21 = new SkillMeasurable("animation (2d)", Measurement.Lots); ph.skills.Add(sm21); pj.skills.Add(sm21);
            SkillMeasurable sm22 = new SkillMeasurable("jetbrains", Measurement.Obsessed); pd.skills.Add(sm22);
            SkillMeasurable sm23 = new SkillMeasurable("android studio", Measurement.Obsessed); pd.skills.Add(sm23);  






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
