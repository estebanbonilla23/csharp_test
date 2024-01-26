namespace Logger
{
    class Logger
    {

        public void logMessage(string path, string level, string message)
        {

            DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
            string timestamp = now.ToString("yyyy-MM-dd-HH:mm:ss");
            string result = String.Format("[{0}][{1}] {2}\n", timestamp, level, message);
            File.AppendAllText(path, result);
        }
    }
}
