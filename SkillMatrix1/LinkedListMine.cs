using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    public class LinkedListMine
    {
        string data;
        LinkedListMine next;

        //can i implement a linked list in C# without a static list, or an array?

        public LinkedListMine(string _data, LinkedListMine _next) //both data types can be null
        {
            this.data = _data;
            this.next = _next;
        }

        extern void Insert();
        extern void Delete();
        extern void Traverse();
    }
}
