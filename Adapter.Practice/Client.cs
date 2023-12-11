
namespace Adapter.Practice
{
    internal class Client
    {
        private readonly IBlobStorage blobStorage;

        public Client(IBlobStorage blobStorage)
        {
            this.blobStorage = blobStorage;
        }

        public async Task Operation()
        {
            string path = "some path to file";

            await blobStorage.SaveToBlob(path);
        }
    }
}
