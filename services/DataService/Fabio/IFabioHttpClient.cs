using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fabio
{
    public interface IFabioHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}
