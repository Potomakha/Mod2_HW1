using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_HW1
{
    /// <summary>
    /// Starter calss.
    /// </summary>
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();
            var result = new Result();
            for (int i = 0; i < 100; i++)
            {
                int rand = new Random().Next(1, 4);
                switch (rand)
                {
                    case 1:
                        result = actions.InfoMethod();
                        break;
                    case 2:
                        result = actions.WarningMethod();
                        break;
                    case 3:
                        result = actions.ErrorMethod();
                        break;
                    default:
                        break;
                }

                if (!result.Status)
                {
                    Logger logger = Logger.GetInstance();
                    logger.MakeLog(LoggerTypes.Error, "Action failed by a reason: " + result.Text);
                }
            }

            Logger.SaveLog();
        }
    }
}
