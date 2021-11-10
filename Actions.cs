using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_HW1
{
    /// <summary>
    /// imitation of call logger.
    /// </summary>
    public class Actions
    {
        public Result InfoMethod()
        {
            var result = new Result { Status = true };
            return result;
        }

        public Result WarningMethod()
        {
            var result = new Result { Status = true };
            return result;
        }

        public Result ErrorMethod()
        {
            var result = new Result { Status = false, Text = "I broke a logic" };
            return result;
        }
    }
}
