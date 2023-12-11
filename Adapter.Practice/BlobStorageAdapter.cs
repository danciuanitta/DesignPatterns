using Azure.Storage.Blobs;

namespace Adapter.Practice
{
    //this is the adapter, that actually knows of azure sdk and steps needed to save a file to blob
    //object adapter
    internal class BlobStorageAdapter : IBlobStorage
    {
        private readonly BlobContainerClient blobStorageClient;

        public BlobStorageAdapter(BlobContainerClient blobStorageClient)
        {
            this.blobStorageClient = blobStorageClient;
        }

        public async Task SaveToBlob(string path)
        {
            string fileName = Path.GetFileName(path);
            BlobClient blobClient = blobStorageClient.GetBlobClient(fileName);

            FileStream fileStream = File.OpenRead(path);
            var result = await blobClient.UploadAsync(fileStream, true);
            fileStream.Close();
        }
    }
}
