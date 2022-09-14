using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Operators
{
    public class BooleanLogical
    {
        public bool AndLogic(bool x, bool y)
        {
            if (x && y)
            {
                return true;
            }
            return false;
        }
        public bool OrLogic(bool x, bool y)
        {
            if (x || y)
            {
                return true;
            }
            return false;
        }
        public bool NotLogic(bool x)
        {
            return !x;
        }

    }
}
