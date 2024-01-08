using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment3
{
    struct Time
    {
        int hours;
        int minutes;

        public Time(int hours, int minutes = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public override string ToString()
        {
            return $"{hours}:{minutes}";
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            int min = Math.Abs(lhs.minutes - rhs.minutes);
            int hr = Math.Abs(lhs.hours - rhs.hours);
            int time = min + hr * 60;
            if (time < 15)
                return true;
            return false;
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            int min = Math.Abs(lhs.minutes - rhs.minutes);
            int hr = Math.Abs(lhs.hours - rhs.hours);
            int time = min + hr * 60;
            if (time < 15)
                return false;
            return true;
        }
    }

}

