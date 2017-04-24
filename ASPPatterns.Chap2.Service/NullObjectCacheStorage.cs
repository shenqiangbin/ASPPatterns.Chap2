using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap2.Service
{
    public class NullObjectCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
           
        }

        public T Retrieve<T>(string key)
        {
            return default(T);
        }

        public void Store(string key, object data)
        {
            
        }
    }
}
