using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateRange
{
    public class DateRange
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public DateRange (DateTime start, DateTime end) => SetDateRange(start, end);

        public void SetDateRange(DateTime start, DateTime end) {
            if (start > end)
                throw new ArgumentException("The argument \"start\" can't be greater than \"end\"");

            this.Start = start;
            this.End = end;
        }

    }
}
