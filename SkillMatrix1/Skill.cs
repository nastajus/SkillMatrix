using System;
using System.Collections.Generic;
using System.IO;
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
            ID = ++IDCount;   //this won't make sense if this will be the parent of SkillHave.
            this.name = _name;
            if (!Exists(_name))
            {
                skills.Add(this);
                Console.WriteLine("Added " + _name);
            }
        }

        public bool Parent(int _parentID)
        {
            this.parentID = _parentID;
            return true;
        }

        public static string GetName(int ID)
        {
            foreach (Skill skill in skills)
            {
                if (skill.ID == ID)
                {
                    return skill.name;
                }
            }
            return null;
        }

        public static bool Exists(string _skill)
        {
            foreach (Skill skill in skills)
            {
                if (_skill == skill.name)
                {
                    //Console.WriteLine("Already exists: " + _skill);
                    return true;
                }
            }
            //Console.WriteLine("Doesn't exist: " + _skill);
            return false;
        }


        private bool HasParent(string _skill)
        {
            //verify list of skills has or not. 
            //i can use a singleton with this containing a static list, or i can use the database instance i created.
            foreach (Skill skill in skills)
            {
                if (skill.name == _skill && skill.parentID != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static int LoadSkills()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string fileSkills = "hier.txt";
            string appPath = Path.Combine(Path.GetDirectoryName(location), fileSkills);

            //
            // It will free resources on its own.
            //
            string line;
            using (StreamReader reader = new StreamReader(appPath))
            {
                int? tabCountParent = null;
                //int tabCountPrev;
                Skill skillParent = null;
                while ((line = reader.ReadLine()) != null)
                {
                    //parse out tabs
                    int tabCount = 0;                    
                    

                    string[] words = line.Split('\t');
                    foreach (string word in words){
                        if (word == ""){
                            tabCount++;
                        }
                    }

                    string skillName = words[words.Length - 1];
                    Skill skill = new Skill(skillName);
                    skills.Add(skill);




                    //when any previous line has LESS tabs, the parent can be set on the current skill to THAT skill. 

                    //this assigns the parent, when a difference is detected
                    if (tabCountParent < tabCount)
                    {
                        skill.parentID = skillParent.ID;
                        //Console.WriteLine(skill.name + "'s parent: " + Skill.GetName((int)skill.parentID));
                    }


                    //this establishes a reference for the next iteration, and refreshes for latest parent.
                    if (tabCountParent == null || tabCountParent == tabCount)
                    {
                        tabCountParent = tabCount;
                        skillParent = skill;
                        //tabCountPrev = tabCount;
                    }

                    
   


                    //Console.WriteLine(tabCount + " | " + words[words.Length - 1]);


                    //



                    //count tabs
                }
                line = reader.ReadLine();
                Console.WriteLine(line);
            }

            Console.ReadLine();
            return 0;
        }
    }
}
