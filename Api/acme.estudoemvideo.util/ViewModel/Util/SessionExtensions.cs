using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            var elemento = value == null ? default(T) :
                                  JsonConvert.DeserializeObject<T>(value);
            return elemento;
        }

        public static void Remove<T>(this ISession session, string key)
        {
            session.Remove(key);
        }
    }
}
