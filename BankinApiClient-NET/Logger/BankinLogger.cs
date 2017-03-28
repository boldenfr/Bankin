namespace BankinApi.Client.Logger
{
    public static class BankinLogger
    {
        private static ILogAdapter logger;

        public static ILogAdapter Logger
        {
            get
            {
                if (logger == null)
                {
                    logger = new ConsoleLogger();
                }
                return logger;
            }
            set { logger = value; }
        }
    }
}
