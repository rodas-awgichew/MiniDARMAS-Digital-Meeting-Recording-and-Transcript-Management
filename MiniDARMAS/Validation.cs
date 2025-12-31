using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDARMAS
{
    public static class Validation
    {
        public static bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }

}
