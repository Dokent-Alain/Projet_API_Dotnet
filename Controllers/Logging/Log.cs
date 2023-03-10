using NLog;
namespace PresenceManagement.Controllers.Log
{
    public class Log : Ilog
    {
        public static NLog.ILogger Logger = LogManager.GetCurrentClassLogger();
        public void Information(string msg)
        {
            Logger.Debug(msg);
        }
        public void warning(string message)
        {
            Logger.Debug(message);
        }
        public void Error(string message)
        {
            Logger.Debug(message);
        }
        public void Debug(string message)
        {
            Logger.Debug(message);
        }
    }
}
