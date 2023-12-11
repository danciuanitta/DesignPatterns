
namespace Adapter.Practice
{
    //this is ITarget
    internal interface IBlobStorage
    {
        Task SaveToBlob(string path);
    }
}
