using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1.practice_oo
{
    class Banana : Fruit
    {
        public Banana()
        {
            color = ConsoleColor.DarkYellow;
        }

       
        public void Eat()
        {
            base.Eat();
            Console.WriteLine("Baaannnaaannnaaa eating");
        }

        public override void Peel() { 
            Console.WriteLine("Ba Peel");
        }

        void vv() { ; }

        void vvtest() { Console.Write("vv ba"); }

        public override void aa() {  }
        //{
        //    //throw new NotImplementedException();
        //}

        //public override void aa_body() { ; }

        //sealed override void sn();
    }
}
