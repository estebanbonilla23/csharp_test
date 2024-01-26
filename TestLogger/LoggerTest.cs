using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Logger
{
    [TestClass]
    public class LoggerTest
    {
        static string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
        static string fullPath = Path.Combine(currentDir, "logger.txt");
        static string[] levels = { "INFO", "NOTICE", "WARNING", "ERROR", "FATAL" };
        Logger loogger = new Logger();

        [TestMethod]
        public void TestMethodInfo()
        {
            String message = "User logged in";
            loogger.logMessage(fullPath, levels[0], message);
            asserts(getLastLine(fullPath), levels[0], message);

        }

        [TestMethod]
        public void TestMethodNotice()
        {
            String message = "It is a new user";
            loogger.logMessage(fullPath, levels[1], message);
            asserts(getLastLine(fullPath), levels[1], message);
        }

        [TestMethod]
        public void TestMethodWarning()
        {
            String message = "Failed login attempt";
            loogger.logMessage(fullPath, levels[2], message);
            asserts(getLastLine(fullPath), levels[2], message);
        }

        [TestMethod]
        public void TestMethodError()
        {
            String message = "The service is out";
            loogger.logMessage(fullPath, levels[3], message);
            asserts(getLastLine(fullPath), levels[3], message);
        }

        [TestMethod]
        public void TestMethodFatal()
        {
            String message = "The server is down";
            loogger.logMessage(fullPath, levels[4], message);
            asserts(getLastLine(fullPath), levels[4], message);
        }



        public String getLastLine(String path)
        {
            return File.ReadLines(path).Last();
        }

        public void asserts(String line, String level, String message)
        {
            String timeStamp = line.Substring(1, 19);
            Assert.IsTrue(DateTime.TryParseExact(timeStamp, "yyyy-MM-dd-HH:mm:ss", null,
                DateTimeStyles.None, out DateTime result), "The timestamp format is not valid");
            Assert.IsTrue(line.Contains(String.Format("[{0}]", level)), "The level is not present");
            Assert.IsTrue(line.Contains(message), "The message is not present");
        }
    }
}