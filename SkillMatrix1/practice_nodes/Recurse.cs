using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    public static class Recurse
    {

        /*
         *  1
         *  3
         *  2
         *  6
         *  8
         *  7
         *  4
         *  5
         */


        //start at root node, go down to lowest root, print as unstacking
        public static void TraverseBU(Node node) //Bottom Up
        {
            if (node.left != null) TraverseBU(node.left);
            Console.WriteLine(node.num);

            if (node.right != null) TraverseBU(node.right);
            

        }
    }
}
