using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    public class Node
    {
        public int num;
        public Node left;
        public Node right;

        public Node(int _num, Node _left, Node _right)
        {
            this.num = _num;
            this.left = _left;
            this.right = _right;
        }
    }
}
