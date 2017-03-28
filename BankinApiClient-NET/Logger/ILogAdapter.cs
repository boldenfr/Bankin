namespace BankinApi.Client.Logger
{
    public interface ILogAdapter
    {
        void Warn(string message);
        void Debug(string message);
        void Trace(string debug);
    }
}
