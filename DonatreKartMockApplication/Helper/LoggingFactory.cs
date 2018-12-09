using log4net;

namespace DonatreKartMockApplication.Helper
{
    public static class LoggingFactory
    {
        private static ILog _logger;

        private static ILog CreateLogger()
        {
            return LogManager.GetLogger("Logger");
        }

        public static ILog GetLogger()
        {
            return _logger ?? (_logger = CreateLogger());
        }
    }
}
