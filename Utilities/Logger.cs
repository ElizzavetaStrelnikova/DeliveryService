namespace DeliveryServiceSystem.Utilities
{
    public class Logger
    {
        private string logFilePath;

        public Logger(string path)
        {
            logFilePath = path;
        }

        public void Log(string message)
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}\n");
        }
    }
}
