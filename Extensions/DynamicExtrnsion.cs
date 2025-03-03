using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend_Webshop.Extensions
{
    public static class DynamicExtension
    {

        public static T? Deserialize<T>(this object obj)
        {

            if (obj == null)
                return default(T);
            
            var data = obj as dynamic;

            return (T)System.Text.Json.JsonSerializer
                   .Deserialize<T>(
                                data.ToString(),
                                new System.Text.Json.JsonSerializerOptions()
                                {
                                    PropertyNameCaseInsensitive = true,
                                    NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
                                }
                   );

        }

    }
}
