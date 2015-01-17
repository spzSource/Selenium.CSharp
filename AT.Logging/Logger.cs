using NLog;

namespace ATF.Logging
{
    public static class Logger
    {
        private static readonly NLog.Logger InternalLogger;

        static Logger()
        {
            InternalLogger = LogManager.GetCurrentClassLogger();
        }

        public static void Info(string message)
        {
            InternalLogger.Info(message);
        }

        public static void Info(string message, params object[] parameters)
        {
            InternalLogger.Info(message, parameters);
        }

        public static void Error(string message)
        {
            InternalLogger.Error(message);
        }

        public static void Error(string message, params object[] parameters)
        {
            InternalLogger.Error(message, parameters);
        }
    }
}

