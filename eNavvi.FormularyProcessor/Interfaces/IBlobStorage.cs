using eNavvi.FormularyProcessor.Models;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eNavvi.FormularyProcessor.Interfaces
{
    public interface IBlobStorage
    {
        public Task<string> DownloadBlob(string containerId, string blobId);
        public Task UploadBlob(string containerId, string blobId, string content);
        public Task MergeFormulary(string blobId, List<StandardizePlan> content, bool IsProcessed);
        public Task MergeRxcui(List<string> rxcuis);
        public List<string> ListAllBlobs(string containerId);
        void DeleteBlobs(string containerId, List<string> planSettings);
    }
}
