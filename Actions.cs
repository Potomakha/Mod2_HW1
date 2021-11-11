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
            var result = new Result { Status = true, Text = "Start method : InfoMethod()" };
            Logger logger = Logger.GetInstance();
            logger.MakeLog(LoggerTypes.Info, result.Text);
            return result;
        }

        public Result WarningMethod()
        {
            var result = new Result { Status = true, Text = "Skipped logic in method: WarningMethod()" };
            Logger logger = Logger.GetInstance();
            logger.MakeLog(LoggerTypes.Warning, result.Text);
            return result;
        }

        public Result ErrorMethod()
        {
            var result = new Result { Status = false, Text = "I broke a logic" };
            return result;
        }
    }
}
