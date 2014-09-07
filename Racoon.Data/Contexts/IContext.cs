using StackExchange.Redis;

namespace Racoon.Data
{
    public interface IContext
    {
        void Open();
        void Close(bool allowOperationsToFinish);
    }
}