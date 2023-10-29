using System.Reflection;
using System.Web;

namespace BusLocator.Client.Utilities
{
    public class QueryParams
    {
        public static string GenerateQueryParams<T>(T searchObject)
        {
            if (searchObject == null)
                return string.Empty;

            var queryString = string.Join("&", searchObject
                .GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(prop => $"{HttpUtility.UrlEncode(prop.Name)}={HttpUtility.UrlEncode(prop.GetValue(searchObject)?.ToString())}"));

            return queryString;
        }
    }
}
