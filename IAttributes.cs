using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace SiteServer.Plugin
{
    public interface IAttributes
    {
        void Load(object dataItem);

        void Load(IDataReader rdr);

        void Load(NameValueCollection attributes);

        void Load(string str);

        object Get(string name);

        void Set(string name, object value);

        void Remove(string name);

        string GetString(string name, string defaultValue = "");

        bool GetBool(string name, bool defaultValue = false);

        int GetInt(string name, int defaultValue = 0);

        decimal GetDecimal(string name, decimal defaultValue = 0);

        DateTime GetDateTime(string name, DateTime defaultValue);

        bool ContainsKey(string name);

        string ToString();

        string ToString(List<string> lowerCaseExcludeAttributeNames);

        Dictionary<string, object> ToDictionary();
    }
}
