using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string fileSkills = "hier.txt";
            string appPath = Path.Combine( Path.GetDirectoryName( location ), fileSkills );

            //
	        // It will free resources on its own.
	        //
	        string line;
            using (StreamReader reader = new StreamReader(appPath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    

                    //count tabs
                    //new skill
                    Skill s = new Skill();
                }
                line = reader.ReadLine();
                Console.WriteLine(line);
            }

            Console.ReadLine();

        }
    }
}
