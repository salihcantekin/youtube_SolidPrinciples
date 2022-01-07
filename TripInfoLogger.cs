using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib
{
    public class TripInfoLogger
    {
        private readonly ILogger logger;

        public TripInfoLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string logInfo)
        {
            logger.Log(logInfo);
        }        
    }

    public interface ILogger
    {
        void Log(string logInfo);
    }

    public class LocalServerLogger : ILogger
    {
        public void Log(string logInfo)
        {
            // Istanbul server logging
        }
    }

    public class GermanyLogger : ILogger
    {
        public void Log(string logStr)
        {
            // Send the date to the Germany
        }
    }

    public class LocalStorageLogger : ILogger
    {
        public void Log(string logStr)
        {
            // Send the date to the Germany
        }
    }
}
