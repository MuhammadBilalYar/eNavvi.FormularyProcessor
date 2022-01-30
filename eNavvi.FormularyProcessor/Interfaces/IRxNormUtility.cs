using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eNavvi.FormularyProcessor.Interfaces
{
    public interface IRxNormUtility
    {
        Task<List<T>> GetData<T>(string blobId) where T : class;
    }
}
