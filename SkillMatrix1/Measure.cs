using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    public enum Measurement { None, Some, Moderate, Lots, Obsessed };

    public abstract class Measure : Table
    {
        public Measurement? level;
        public Measurement? desire;
    }
}
