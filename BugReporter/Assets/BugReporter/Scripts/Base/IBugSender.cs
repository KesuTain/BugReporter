namespace Utilities.BugReporter
{
    public interface IBugSender
    {
        void SendData(IBugModel bugReport);
    }
}

