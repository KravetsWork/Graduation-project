using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FoodDeliveryShop.Infrastructure
{
    /// <summary>
    /// Session status tool in ASP.NET Core stores only int values, string and byte [].
    /// To preserve the Cart object, you need to define extensible methods for the ISession
    /// interface that will provide access to the session state data in order to serialize 
    /// the Cart objects to the JSON format and convert them back.
    /// </summary>
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null
                ? default(T)
                : JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}
