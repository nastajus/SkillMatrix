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
        private Measurement? _level;
        public Measurement? level
        {
            get
            {
                return _level;
            }
            set
            {
                var measures = Enum.GetValues(typeof(Measurement));
                foreach (var measure in measures) 
                {
                    if (value.ToString() == measure.ToString())
                    {
                        _level = value;
                    }
                }
            }
        }

        //is there a way to re-use the above code below? it's identical except for the variable used.
        //public Measurement? desire { get; }

        private Measurement? _desire;
        public Measurement? desire
        {
            get
            {
                return _desire;
            }
            set
            {
                var desires = Enum.GetValues(typeof(Measurement));
                foreach (var desire in desires)
                {
                    if (value.ToString() == desire.ToString())
                    {
                        _desire = value;
                    }
                }
            }
        }


    }
}
