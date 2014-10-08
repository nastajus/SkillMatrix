using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1.practice_oo
{
    abstract class Fruit
    {
        public ConsoleColor color;
        public float sugarGrams;
        public float days;

        public void Eat() //do i need an implementation body in the parent in simple inheritence?
        {
            Console.WriteLine("Fruit is delicious to eat.");
        }

        public abstract void Peel();


        void vv() { ; }

        void vvtest() { Console.Write("vv fruit"); }

        public abstract void aa();

        //not acceptable to run
        //public abstract void aa_body()
        //{
        //    Console.Write("aa_body");
        //}

        //public abstract void aa_new();

        public void an() { Console.Write("an must has body"); }

        protected void sn() {  Console.Write("sn must has body"); }

    }
}
