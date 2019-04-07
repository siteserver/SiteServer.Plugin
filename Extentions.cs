using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace SiteServer.Plugin
{
    public static class Extentions
    {
        private static int ToInt(string intStr, int defaultValue = 0)
        {
            if (!int.TryParse(intStr?.Trim(), out var i))
            {
                i = defaultValue;
            }
            return i;
        }

        private static decimal ToDecimal(string intStr, decimal defaultValue = 0)
        {
            if (!decimal.TryParse(intStr?.Trim(), out var i))
            {
                i = defaultValue;
            }
            return i;
        }

        private static bool ToBool(string boolStr, bool defaultValue = false)
        {
            if (!bool.TryParse(boolStr?.Trim(), out var boolean))
            {
                boolean = defaultValue;
            }
            return boolean;
        }

        private static T Get<T>(IDictionary<string, object> dict, string name, T defaultValue = default(T))
        {
            return To(Get(dict, name), defaultValue);
        }

        private static object Get(IDictionary<string, object> dict, string name)
        {
            if (string.IsNullOrEmpty(name)) return null;

            return dict.TryGetValue(name, out var extendValue) ? extendValue : null;
        }

        private static T To<T>(object value, T defaultValue = default(T))
        {
            switch (value)
            {
                case null:
                    return defaultValue;
                case T variable:
                    return variable;
                default:
                    try
                    {
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                    catch (InvalidCastException)
                    {
                        return defaultValue;
                    }
            }
        }

        public static IAuthenticatedRequest GetAuthenticatedRequest(this HttpRequestMessage request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            return Context.UtilsApi.GetAuthenticatedRequest(request);
        }

        public static IDictionary<string, string> GetQueryDirectory(this HttpRequestMessage request)
        {
            IDictionary<string, string> dict = null;
            if (request.Properties.ContainsKey("QueryDictionary"))
            {
                dict = Get<IDictionary<string, string>>(request.Properties, "QueryDictionary");
            }

            if (dict != null) return dict;

            dict = request.GetQueryNameValuePairs()
                .ToDictionary(kv => kv.Key, kv => kv.Value, StringComparer.OrdinalIgnoreCase);

            request.Properties["QueryDictionary"] = dict;

            return dict;
        }

        public static bool IsQueryExists(this HttpRequestMessage request, string name)
        {
            var dict = request.GetQueryDirectory();
            return dict.ContainsKey(name);
        }

        public static string GetQueryString(this HttpRequestMessage request, string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            var dict = request.GetQueryDirectory();
            return dict.TryGetValue(name, out var value) ? value : null;
        }

        public static int GetQueryInt(this HttpRequestMessage request, string name, int defaultValue = 0)
        {
            return ToInt(request.GetQueryString(name), defaultValue);
        }

        public static decimal GetQueryDecimal(this HttpRequestMessage request, string name, decimal defaultValue = 0)
        {
            return ToDecimal(request.GetQueryString(name), defaultValue);
        }

        public static bool GetQueryBool(this HttpRequestMessage request, string name, bool defaultValue = false)
        {
            return ToBool(request.GetQueryString(name), false);
        }

        public static IDictionary<string, object> GetPostDictionary(this HttpRequestMessage request)
        {
            IDictionary<string, object> dict = null;
            if (request.Properties.ContainsKey("PostDictionary"))
            {
                dict = Get<IDictionary<string, object>>(request.Properties, "PostDictionary");
            }

            if (dict != null) return dict;

            dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

            var json = request.Content.ReadAsStringAsync().Result;
            if (string.IsNullOrEmpty(json)) return dict;

            var originalDict = Context.UtilsApi.JsonDeserialize<Dictionary<string, object>>(json);
            if (originalDict != null)
            {
                foreach (var key in originalDict.Keys)
                {
                    dict[key] = originalDict[key];
                }
            }

            request.Properties["PostDictionary"] = dict;

            return dict;
        }

        public static T GetPostObject<T>(this HttpRequestMessage request)
        {
            var json = request.Content.ReadAsStringAsync().Result;
            return Context.UtilsApi.JsonDeserialize<T>(json);
        }

        public static T GetPostObject<T>(this HttpRequestMessage request, string name)
        {
            var json = request.GetPostString(name);
            return Context.UtilsApi.JsonDeserialize<T>(json);
        }

        public static bool IsPostExists(this HttpRequestMessage request, string name)
        {
            var dict = request.GetPostDictionary();
            return dict.ContainsKey(name);
        }

        private static object GetPostObject(this HttpRequestMessage request, string name)
        {
            if (string.IsNullOrEmpty(name)) return null;

            var dict = request.GetPostDictionary();

            return dict.TryGetValue(name, out var value) ? value : null;
        }

        public static string GetPostString(this HttpRequestMessage request, string name)
        {
            var value = request.GetPostObject(name);
            switch (value)
            {
                case null:
                    return null;
                case string s:
                    return s;
                default:
                    return value.ToString();
            }
        }

        public static int GetPostInt(this HttpRequestMessage request, string name, int defaultValue = 0)
        {
            var value = request.GetPostObject(name);
            switch (value)
            {
                case null:
                    return 0;
                case int _:
                    return (int)value;
                default:
                    return ToInt(value.ToString(), defaultValue);
            }
        }

        public static decimal GetPostDecimal(this HttpRequestMessage request, string name, decimal defaultValue = 0)
        {
            var value = request.GetPostObject(name);
            switch (value)
            {
                case null:
                    return 0;
                case decimal _:
                    return (decimal)value;
                default:
                    return ToDecimal(value.ToString(), defaultValue);
            }
        }

        public static bool GetPostBool(this HttpRequestMessage request, string name, bool defaultValue = false)
        {
            var value = request.GetPostObject(name);
            switch (value)
            {
                case null:
                    return false;
                case bool _:
                    return (bool)value;
                default:
                    return ToBool(value.ToString(), defaultValue);
            }
        }
    }
}
