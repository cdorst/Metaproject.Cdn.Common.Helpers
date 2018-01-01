using DevOps.ContentDelivery.Structures.AzureBlob;
using static DevOps.ContentDelivery.Functions.DownloadAndExtractAzureCdnBlobZip.BlobArchiveDownloader;
using static DevOps.ContentDelivery.Functions.DownloadAzureCdnBlob.CdnBlobDownloader;

namespace Metaproject.Cdn.Common.Helpers
{
    public static class CDorstCdnHelper
    {
        private const string EndpointName = "cdorst-dev";

        public static void Download(Blob blob, string destinationPath)
            => DownloadBlob(EndpointName, blob, destinationPath);

        public static void ExtractZip(Blob blob, string destinationPath)
            => Extract(EndpointName, blob, destinationPath);
    }
}
