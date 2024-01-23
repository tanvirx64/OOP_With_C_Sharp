namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string errorMessage);
        void LogInfo(string message);
    }
}
