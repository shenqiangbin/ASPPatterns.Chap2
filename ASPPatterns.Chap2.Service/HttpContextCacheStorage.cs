using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ASPPatterns.Chap2.Service
{
    public class HttpContextCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public T Retrieve<T>(string key)
        {
            return (T)HttpContext.Current.Cache.Get(key);
        }

        public void Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }
    }
}
